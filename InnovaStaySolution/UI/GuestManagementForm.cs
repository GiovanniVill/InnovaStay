using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class GuestManagementForm : Form
    {
        private readonly GuestController _guestController;

        public GuestManagementForm()
        {
            InitializeComponent();
            _guestController = new GuestController();

            this.Load += GuestManagementForm_Load;
            btnAddGuest.Click += btnAddGuest_Click;
            btnEditGuest.Click += btnEditGuest_Click;
            btnSearchGuest.Click += btnSearchGuest_Click;
            btnViewGuest.Click += btnViewGuest_Click;
            dgvGuest.CellClick += dgvGuest_CellClick;
        }

        private void GuestManagementForm_Load(object sender, EventArgs e)
        {
            LoadAllGuests();
        }

        private void btnViewGuest_Click(object sender, EventArgs e)
        {
            LoadAllGuests();
            ClearInputs();
        }

        private void LoadAllGuests()
        {
            try
            {
                List<GuestModel> guests = _guestController.GetAllGuests();
                dgvGuest.DataSource = null;
                dgvGuest.DataSource = guests;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load guests: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private (string FirstName, string LastName) ParseFullName(string fullName)
        {
            fullName = (fullName ?? string.Empty).Trim();
            if (string.IsNullOrEmpty(fullName))
            {
                return (string.Empty, string.Empty);
            }

            int firstSpace = fullName.IndexOf(' ');
            if (firstSpace == -1)
            {
                return (fullName, string.Empty);
            }

            string firstName = fullName.Substring(0, firstSpace).Trim();
            string lastName = fullName.Substring(firstSpace + 1).Trim();
            return (firstName, lastName);
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            var (firstName, lastName) = ParseFullName(txtFullName.Text);

            var guest = new GuestModel
            {
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = txtContact.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim()
            };

            var (success, message) = _guestController.AddGuest(guest);
            if (success)
            {
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadAllGuests();
            }
            else
            {
                MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditGuest_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGuestID.Text.Trim(), out int guestId))
            {
                MessageBox.Show("Please select a valid guest from the list to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var (firstName, lastName) = ParseFullName(txtFullName.Text);

            var guest = new GuestModel
            {
                GuestId = guestId,
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = txtContact.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim()
            };

            var (success, message) = _guestController.UpdateGuest(guest);
            if (success)
            {
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadAllGuests();
            }
            else
            {
                MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearchGuest_Click(object sender, EventArgs e)
        {
            string searchName = txtFullName.Text.Trim().ToLower();
            string searchPhone = txtContact.Text.Trim();

            try
            {
                List<GuestModel> allGuests = _guestController.GetAllGuests();
                var results = allGuests.Where(g =>
                    (string.IsNullOrEmpty(searchName) || (g.FullName != null && g.FullName.ToLower().Contains(searchName))) &&
                    (string.IsNullOrEmpty(searchPhone) || (g.PhoneNumber != null && g.PhoneNumber.Contains(searchPhone)))
                ).ToList();

                dgvGuest.DataSource = null;
                dgvGuest.DataSource = results;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvGuest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvGuest.Rows[e.RowIndex].DataBoundItem is GuestModel selectedGuest)
            {
                txtGuestID.Text = selectedGuest.GuestId.ToString();
                txtFullName.Text = selectedGuest.FullName;
                txtContact.Text = selectedGuest.PhoneNumber;
                txtEmail.Text = selectedGuest.Email;
                txtAddress.Text = selectedGuest.Address;
            }
        }

        private void ClearInputs()
        {
            txtGuestID.Clear();
            txtFullName.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
        }
    }
}