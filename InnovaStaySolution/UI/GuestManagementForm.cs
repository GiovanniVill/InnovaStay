using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class GuestManagementForm : Form
    {
        private readonly GuestController _guestController;
        private int _selectedGuestId = 0;
        private List<GuestModel> _allGuests = new List<GuestModel>();

        private readonly Color OliveGold = Color.FromArgb(184, 172, 102);
        private readonly Color OliveHover = Color.FromArgb(160, 150, 85);
        private readonly Color DangerRed = Color.FromArgb(220, 53, 69);
        private readonly Color DangerHover = Color.FromArgb(200, 35, 51);

        public GuestManagementForm()
        {
            InitializeComponent();
            _guestController = new GuestController();
            WireHoverEffects();
        }

        private void GuestManagementForm_Load(object sender, EventArgs e)
        {
            RefreshGridAndInputs();
        }

        private void WireHoverEffects()
        {
            Button[] oliveBtns = { btnAddGuest, btnEditGuest, btnViewGuest, btnClearSearch };
            foreach (var btn in oliveBtns)
            {
                btn.MouseEnter += (s, e) => btn.BackColor = OliveHover;
                btn.MouseLeave += (s, e) => btn.BackColor = OliveGold;
            }

            btnDeleteGuest.MouseEnter += (s, e) => btnDeleteGuest.BackColor = DangerHover;
            btnDeleteGuest.MouseLeave += (s, e) => btnDeleteGuest.BackColor = DangerRed;
        }

        private void RefreshGridAndInputs()
        {
            _allGuests = _guestController.GetAllGuests() ?? new List<GuestModel>();
            ApplySearchFilter();
            ResetToAutomatedDefaults();
        }

        private void ApplySearchFilter()
        {
            string query = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(query))
            {
                dgvGuests.DataSource = null;
                dgvGuests.DataSource = _allGuests;
            }
            else
            {
                var filtered = _allGuests.Where(g =>
                    (g.FirstName != null && g.FirstName.ToLower().Contains(query)) ||
                    (g.LastName != null && g.LastName.ToLower().Contains(query)) ||
                    (g.FullName != null && g.FullName.ToLower().Contains(query)) ||
                    (g.PhoneNumber != null && g.PhoneNumber.ToLower().Contains(query)) ||
                    (g.Address != null && g.Address.ToLower().Contains(query)) ||
                    (g.Email != null && g.Email.ToLower().Contains(query))
                ).ToList();

                dgvGuests.DataSource = null;
                dgvGuests.DataSource = filtered;
            }

            if (dgvGuests.Columns.Contains("CreatedAt"))
                dgvGuests.Columns["CreatedAt"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";
            if (dgvGuests.Columns.Contains("UpdatedAt"))
                dgvGuests.Columns["UpdatedAt"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";
        }

        private void ResetToAutomatedDefaults()
        {
            _selectedGuestId = 0;

            int nextId = _allGuests.Any() ? _allGuests.Max(g => g.GuestId) + 1 : 1;
            txtGuestId.Text = nextId.ToString();

            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtBarangay.Clear();
            txtMunicipality.Clear();
            txtProvince.Clear();

            btnAddGuest.Enabled = true;
            dgvGuests.ClearSelection();
        }

        private GuestModel BuildGuestModelFromInputs()
        {
            string first = txtFirstName.Text.Trim();
            string middle = txtMiddleName.Text.Trim();
            string last = txtLastName.Text.Trim();

            string combinedFirstName = string.IsNullOrWhiteSpace(middle) ? first : $"{first} {middle}";

            var addressParts = new[]
            {
                txtBarangay.Text.Trim(),
                txtMunicipality.Text.Trim(),
                txtProvince.Text.Trim()
            }.Where(s => !string.IsNullOrWhiteSpace(s));

            return new GuestModel
            {
                GuestId = _selectedGuestId,
                FirstName = combinedFirstName,
                LastName = last,
                PhoneNumber = txtContact.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = string.Join(", ", addressParts)
            };
        }

        // --- Designer-Wired Events ---

        private void dgvGuests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvGuests.Rows[e.RowIndex];
            if (row.DataBoundItem is not GuestModel guest) return;

            _selectedGuestId = guest.GuestId;
            txtGuestId.Text = guest.GuestId.ToString();
            txtLastName.Text = guest.LastName ?? "";
            txtContact.Text = guest.PhoneNumber ?? "";
            txtEmail.Text = guest.Email ?? "";

            var nameParts = (guest.FirstName ?? "").Trim().Split(new[] { ' ' }, 2);
            txtFirstName.Text = nameParts.Length > 0 ? nameParts[0] : "";
            txtMiddleName.Text = nameParts.Length > 1 ? nameParts[1] : "";

            var addrParts = (guest.Address ?? "").Split(',').Select(p => p.Trim()).ToArray();
            txtBarangay.Text = addrParts.Length > 0 ? addrParts[0] : "";
            txtMunicipality.Text = addrParts.Length > 1 ? addrParts[1] : "";
            txtProvince.Text = addrParts.Length > 2 ? addrParts[2] : "";

            btnAddGuest.Enabled = false;
        }

        private void dgvGuests_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvGuests.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.None)
            {
                ResetToAutomatedDefaults();
            }
        }

        private void pnlLeftSidebar_Click(object sender, EventArgs e)
        {
            ResetToAutomatedDefaults();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            ApplySearchFilter();
            ResetToAutomatedDefaults();
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Last Name and First Name are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var guest = BuildGuestModelFromInputs();
            var (success, message) = _guestController.AddGuest(guest);
            MessageBox.Show(message, success ? "Success" : "Error", MessageBoxButtons.OK,
                success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (success) RefreshGridAndInputs();
        }

        private void btnEditGuest_Click(object sender, EventArgs e)
        {
            if (_selectedGuestId <= 0)
            {
                MessageBox.Show("Please select a guest from the table first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var guest = BuildGuestModelFromInputs();
            var (success, message) = _guestController.UpdateGuest(guest);
            MessageBox.Show(message, success ? "Success" : "Error", MessageBoxButtons.OK,
                success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (success) RefreshGridAndInputs();
        }

        private void btnViewGuest_Click(object sender, EventArgs e)
        {
           
        
            if (_selectedGuestId <= 0)
            {
                MessageBox.Show("Please select a guest from the table to view.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Retrieve fresh record directly from the database via GuestController
            var freshGuest = _guestController.GetAllGuests()?
                .FirstOrDefault(g => g.GuestId == _selectedGuestId) ?? BuildGuestModelFromInputs();

            using (var infoModal = new GuestInfo(freshGuest))
            {
                infoModal.StartPosition = FormStartPosition.CenterParent;
                infoModal.FormBorderStyle = FormBorderStyle.FixedDialog;
                infoModal.MaximizeBox = false;
                infoModal.MinimizeBox = false;
                infoModal.ShowDialog(this);
            }
        }
       
       

        private void btnDeleteGuest_Click(object sender, EventArgs e)
        {
            if (_selectedGuestId <= 0)
            {
                MessageBox.Show("Please select a guest from the table to delete.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Are you sure you want to delete guest #{_selectedGuestId}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                var (success, message) = _guestController.DeleteGuest(_selectedGuestId);
                MessageBox.Show(message, success ? "Success" : "Error", MessageBoxButtons.OK,
                    success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (success) RefreshGridAndInputs();
            }
        }
    }
}