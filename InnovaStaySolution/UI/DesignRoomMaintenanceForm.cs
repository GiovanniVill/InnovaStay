using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class DesignRoomMaintenanceForm : Form
    {
        private readonly RoomController _roomController;
        private readonly string _currentUserRole = "Admin";
        private int _selectedRoomId = 0;
        private string _selectedRoomNumber = string.Empty;

        public DesignRoomMaintenanceForm()
        {
            InitializeComponent();
            _roomController = new RoomController();
        }

        private void DesignRoomMaintenanceForm_Load_1(object sender, EventArgs e)
        {
            LoadRoomGrid();
        }

        private void LoadRoomGrid()
        {
            try
            {
                List<RoomModel> allRooms = _roomController.GetAllRooms();
                dgvRooms.DataSource = null;
                dgvRooms.DataSource = allRooms;

                if (dgvRooms.Columns["RoomNumber"] != null) dgvRooms.Columns["RoomNumber"].HeaderText = "Room #";
                if (dgvRooms.Columns["RoomType"] != null) dgvRooms.Columns["RoomType"].HeaderText = "Type";
                if (dgvRooms.Columns["PricePerNight"] != null)
                {
                    dgvRooms.Columns["PricePerNight"].HeaderText = "Rate (PHP)";
                    dgvRooms.Columns["PricePerNight"].DefaultCellStyle.Format = "N2";
                }
                if (dgvRooms.Columns["Floor"] != null) dgvRooms.Columns["Floor"].HeaderText = "Floor";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rooms: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRooms.Rows[e.RowIndex];
                if (row.DataBoundItem is RoomModel room)
                {
                    _selectedRoomId = room.RoomId;
                    _selectedRoomNumber = room.RoomNumber;

                    cmbRoomType.Text = room.RoomType;
                    txtRoomRate.Text = room.PricePerNight.ToString("F2");
                }
            }
        }

        // Auto-suggest default rates when selecting a room type (can still be edited)
        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoomType.SelectedItem == null) return;

            string selectedType = cmbRoomType.SelectedItem.ToString();
            decimal defaultRate = selectedType switch
            {
                "Single" => 1500.00m,
                "Double" => 2200.00m,
                "Deluxe" => 3500.00m,
                "Suite" => 5000.00m,
                _ => 1500.00m
            };

            txtRoomRate.Text = defaultRate.ToString("0.00");
        }

        // Helper to auto-generate the next sequential room number
        private string GenerateNextRoomNumber()
        {
            int nextNumber = 101;
            List<RoomModel> allRooms = _roomController.GetAllRooms();

            if (allRooms != null && allRooms.Count > 0)
            {
                int maxNum = 0;
                foreach (var rm in allRooms)
                {
                    if (int.TryParse(rm.RoomNumber, out int parsedNum) && parsedNum > maxNum)
                    {
                        maxNum = parsedNum;
                    }
                }

                if (maxNum >= 101)
                {
                    nextNumber = maxNum + 1;
                }
            }

            return nextNumber.ToString();
        }

        private void btnAddRoom_Click_1(object sender, EventArgs e)
        {
            if (cmbRoomType.SelectedItem == null && string.IsNullOrWhiteSpace(cmbRoomType.Text))
            {
                MessageBox.Show("Room type is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRoomType.Focus();
                return;
            }

            if (!decimal.TryParse(txtRoomRate.Text.Trim(), out decimal rate) || rate <= 0)
            {
                MessageBox.Show("Price per night must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRoomRate.Focus();
                return;
            }

            string autoRoomNumber = GenerateNextRoomNumber();

            var room = new RoomModel
            {
                RoomNumber = autoRoomNumber,
                RoomType = cmbRoomType.SelectedItem?.ToString() ?? cmbRoomType.Text.Trim(),
                PricePerNight = rate,
                Status = "Available",
                Floor = 1
            };

            var (success, message) = _roomController.AddRoom(room, _currentUserRole);
            MessageBox.Show(message, success ? "Success" : "Error", MessageBoxButtons.OK,
                success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (success)
            {
                ClearInputs();
                LoadRoomGrid();
            }
        }

        private void btnEditRoom_Click_1(object sender, EventArgs e)
        {
            if (_selectedRoomId == 0 && string.IsNullOrWhiteSpace(_selectedRoomNumber))
            {
                MessageBox.Show("Please select a room from the list to edit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtRoomRate.Text.Trim(), out decimal rate) || rate <= 0)
            {
                MessageBox.Show("Price per night must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRoomRate.Focus();
                return;
            }

            List<RoomModel> allRooms = _roomController.GetAllRooms();
            var targetRoom = allRooms.Find(r => r.RoomId == _selectedRoomId || string.Equals(r.RoomNumber, _selectedRoomNumber, StringComparison.OrdinalIgnoreCase));

            if (targetRoom == null)
            {
                MessageBox.Show("Selected room could not be found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            targetRoom.RoomType = cmbRoomType.SelectedItem?.ToString() ?? cmbRoomType.Text.Trim();
            targetRoom.PricePerNight = rate;

            var (success, message) = _roomController.UpdateRoom(targetRoom, _currentUserRole);
            MessageBox.Show(message, success ? "Success" : "Error", MessageBoxButtons.OK,
                success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (success)
            {
                ClearInputs();
                LoadRoomGrid();
            }
        }

        private void btnViewRoom_Click_1(object sender, EventArgs e)
        {
            LoadRoomGrid();
            MessageBox.Show("Room list refreshed from database.", "Refreshed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeactivateRoom_Click_1(object sender, EventArgs e)
        {
            if (_selectedRoomId == 0 && string.IsNullOrWhiteSpace(_selectedRoomNumber))
            {
                MessageBox.Show("Please select the room you want to deactivate from the list.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<RoomModel> allRooms = _roomController.GetAllRooms();
            var targetRoom = allRooms.Find(r => r.RoomId == _selectedRoomId || string.Equals(r.RoomNumber, _selectedRoomNumber, StringComparison.OrdinalIgnoreCase));

            if (targetRoom == null)
            {
                MessageBox.Show("Selected room could not be found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Are you sure you want to deactivate room '{targetRoom.RoomNumber}'?", "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                var (success, message) = _roomController.DeleteRoom(targetRoom.RoomId, _currentUserRole);
                MessageBox.Show(message, success ? "Success" : "Error", MessageBoxButtons.OK,
                    success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (success)
                {
                    ClearInputs();
                    LoadRoomGrid();
                }
            }
        }

        private void ClearInputs()
        {
            _selectedRoomId = 0;
            _selectedRoomNumber = string.Empty;
            txtRoomRate.Clear();
            cmbRoomType.SelectedIndex = -1;
            cmbRoomType.Text = string.Empty;
            dgvRooms.ClearSelection();
        }
    }
}