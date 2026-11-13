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

        private TextBox? _txtAgeControl;
        private DateTimePicker? _dtpDobControl;

        private readonly Color OliveGold = Color.FromArgb(184, 172, 102);
        private readonly Color OliveHover = Color.FromArgb(160, 150, 85);
        private readonly Color DangerRed = Color.FromArgb(220, 53, 69);
        private readonly Color DangerHover = Color.FromArgb(200, 35, 51);

        public GuestManagementForm()
        {
            InitializeComponent();
            _guestController = new GuestController();
            ResolveAgeAndDobControls();
            WireHoverEffects();

            btnEditGuest.Click -= btnEditGuest_Click;
            btnEditGuest.Click += btnEditGuest_Click;
        }

        private void GuestManagementForm_Load(object sender, EventArgs e)
        {
            RefreshGridAndInputs();
        }

        private void ResolveAgeAndDobControls()
        {
            var allControls = GetAllControls(this).ToList();

            _txtAgeControl = allControls
                .OfType<TextBox>()
                .FirstOrDefault(t => t.Name.IndexOf("age", StringComparison.OrdinalIgnoreCase) >= 0);

            _dtpDobControl = allControls
                .OfType<DateTimePicker>()
                .FirstOrDefault(d =>
                    d.Name.IndexOf("dob", StringComparison.OrdinalIgnoreCase) >= 0 ||
                    d.Name.IndexOf("birth", StringComparison.OrdinalIgnoreCase) >= 0)
                ?? allControls.OfType<DateTimePicker>().FirstOrDefault();

            if (_dtpDobControl != null)
            {
                _dtpDobControl.ValueChanged += (s, e) =>
                {
                    if (_txtAgeControl != null)
                    {
                        int calculatedAge = CalculateAge(_dtpDobControl.Value.Date);
                        _txtAgeControl.Text = calculatedAge > 0 ? calculatedAge.ToString() : string.Empty;
                    }
                };
            }
        }

        private IEnumerable<Control> GetAllControls(Control root)
        {
            foreach (Control c in root.Controls)
            {
                yield return c;
                foreach (Control child in GetAllControls(c))
                    yield return child;
            }
        }

        private int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) age--;
            return Math.Max(0, age);
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
                    (g.MiddleName != null && g.MiddleName.ToLower().Contains(query)) ||
                    (g.LastName != null && g.LastName.ToLower().Contains(query)) ||
                    (g.FullName != null && g.FullName.ToLower().Contains(query)) ||
                    (g.PhoneNumber != null && g.PhoneNumber.ToLower().Contains(query)) ||
                    (g.Address != null && g.Address.ToLower().Contains(query)) ||
                    (g.Email != null && g.Email.ToLower().Contains(query))
                ).ToList();

                dgvGuests.DataSource = null;
                dgvGuests.DataSource = filtered;
            }

            if (dgvGuests.Columns.Contains("DateOfBirth"))
            {
                dgvGuests.Columns["DateOfBirth"].HeaderText = "Date of Birth";
                dgvGuests.Columns["DateOfBirth"].DefaultCellStyle.Format = "MM/dd/yyyy";
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

            if (_txtAgeControl != null) _txtAgeControl.Clear();
            if (_dtpDobControl != null) _dtpDobControl.Value = DateTime.Today;

            btnAddGuest.Enabled = true;
            dgvGuests.ClearSelection();
        }

        private int ResolveSelectedGuestId()
        {
            if (_selectedGuestId > 0)
                return _selectedGuestId;

            if (dgvGuests.CurrentRow?.DataBoundItem is GuestModel rowGuest && rowGuest.GuestId > 0)
                return rowGuest.GuestId;

            if (int.TryParse(txtGuestId.Text.Trim(), out int idFromBox) && _allGuests.Any(g => g.GuestId == idFromBox))
                return idFromBox;

            return 0;
        }

        private GuestModel BuildGuestModelFromInputs(int guestId)
        {
            string first = txtFirstName.Text.Trim();
            string middle = txtMiddleName.Text.Trim();
            string last = txtLastName.Text.Trim();

            if (first.Equals("First Name", StringComparison.OrdinalIgnoreCase)) first = "";
            if (middle.Equals("Middle Name", StringComparison.OrdinalIgnoreCase)) middle = "";
            if (last.Equals("Last Name", StringComparison.OrdinalIgnoreCase)) last = "";

            var addressParts = new[]
            {
                txtBarangay.Text.Trim(),
                txtMunicipality.Text.Trim(),
                txtProvince.Text.Trim()
            }.Where(s => !string.IsNullOrWhiteSpace(s)
                && !s.Equals("Barangay", StringComparison.OrdinalIgnoreCase)
                && !s.Equals("Municipality", StringComparison.OrdinalIgnoreCase)
                && !s.Equals("Province", StringComparison.OrdinalIgnoreCase));

            int age = 0;
            if (_txtAgeControl != null && int.TryParse(_txtAgeControl.Text.Trim(), out int parsedAge) && parsedAge > 0)
            {
                age = parsedAge;
            }
            else if (_dtpDobControl != null)
            {
                age = CalculateAge(_dtpDobControl.Value.Date);
            }

            DateTime? dob = _dtpDobControl != null ? _dtpDobControl.Value.Date : (DateTime?)null;

            return new GuestModel
            {
                GuestId = guestId,
                FirstName = first,
                MiddleName = middle,
                LastName = last,
                PhoneNumber = txtContact.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = string.Join(", ", addressParts),
                Age = age,
                DateOfBirth = dob
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
            txtFirstName.Text = guest.FirstName ?? "";
            txtMiddleName.Text = guest.MiddleName ?? "";
            txtContact.Text = guest.PhoneNumber ?? "";
            txtEmail.Text = guest.Email ?? "";

            var addrParts = (guest.Address ?? "").Split(',').Select(p => p.Trim()).ToArray();
            txtBarangay.Text = addrParts.Length > 0 ? addrParts[0] : "";
            txtMunicipality.Text = addrParts.Length > 1 ? addrParts[1] : "";
            txtProvince.Text = addrParts.Length > 2 ? addrParts[2] : "";

            if (_txtAgeControl != null)
                _txtAgeControl.Text = guest.Age > 0 ? guest.Age.ToString() : string.Empty;

            if (_dtpDobControl != null && guest.DateOfBirth.HasValue && guest.DateOfBirth.Value >= _dtpDobControl.MinDate && guest.DateOfBirth.Value <= _dtpDobControl.MaxDate)
                _dtpDobControl.Value = guest.DateOfBirth.Value;

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
            // Keep selected guest intact while editing inputs
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
            var guest = BuildGuestModelFromInputs(0);
            if (string.IsNullOrWhiteSpace(guest.LastName) || string.IsNullOrWhiteSpace(guest.FirstName))
            {
                MessageBox.Show("Last Name and First Name are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var (success, message) = _guestController.AddGuest(guest);
            MessageBox.Show(message, success ? "Success" : "Error", MessageBoxButtons.OK,
                success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (success) RefreshGridAndInputs();
        }

        private void btnEditGuest_Click(object sender, EventArgs e)
        {
            int targetId = ResolveSelectedGuestId();
            if (targetId <= 0)
            {
                MessageBox.Show("Please select a guest from the table first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var guest = BuildGuestModelFromInputs(targetId);
            var (success, message) = _guestController.UpdateGuest(guest);
            MessageBox.Show(message, success ? "Success" : "Error", MessageBoxButtons.OK,
                success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (success) RefreshGridAndInputs();
        }

        private void btnViewGuest_Click(object sender, EventArgs e)
        {
            int targetId = ResolveSelectedGuestId();
            if (targetId <= 0)
            {
                MessageBox.Show("Please select a guest from the table to view.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var freshGuest = _guestController.GetAllGuests()?
                .FirstOrDefault(g => g.GuestId == targetId);

            if (freshGuest == null)
            {
                MessageBox.Show("Guest record could not be found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
            int targetId = ResolveSelectedGuestId();
            if (targetId <= 0)
            {
                MessageBox.Show("Please select a guest from the table to delete.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Are you sure you want to delete guest #{targetId}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                var (success, message) = _guestController.DeleteGuest(targetId);
                MessageBox.Show(message, success ? "Success" : "Error", MessageBoxButtons.OK,
                    success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (success) RefreshGridAndInputs();
            }
        }
    }
}