using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class RoomMaintenanceForm : Form
    {
        private readonly RoomController _roomController;
        private readonly string _currentUserRole = "Admin";
        private int _selectedRoomId = 0;
        private string _selectedRoomNumber = string.Empty;

        public RoomMaintenanceForm()
        {
            InitializeComponent();
            _roomController = new RoomController();
        }

        private void DesignRoomMaintenanceForm_Load_1(object sender, EventArgs e)
        {
            // Populate common rate options into the dropdown
            cmbRate.Items.Clear();
            cmbRate.Items.AddRange(new object[] { "1500.00", "2200.00", "3500.00", "5000.00" });

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
                    cmbRate.Text = room.PricePerNight.ToString("0.00");
                }
            }
        }

        // Auto-selects and sets the exact price in cmbRate when Room Type changes
        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cmbRoomType.SelectedItem?.ToString() ?? cmbRoomType.Text.Trim();
            if (string.IsNullOrWhiteSpace(selectedType)) return;

            decimal defaultRate = selectedType switch
            {
                "Single" => 1500.00m,
                "Double" => 2200.00m,
                "Deluxe" => 3500.00m,
                "Suite" => 5000.00m,
                _ => 1500.00m
            };

            cmbRate.Text = defaultRate.ToString("0.00");
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

        // Helper to safely parse rate strings even if formatted with 'P', '₱', or commas
        private bool TryParseRate(string rawInput, out decimal rate)
        {
            rate = 0;
            if (string.IsNullOrWhiteSpace(rawInput)) return false;

            string cleaned = rawInput.Replace("P", "", StringComparison.OrdinalIgnoreCase)
                                     .Replace("₱", "")
                                     .Replace(",", "")
                                     .Trim();

            return decimal.TryParse(cleaned, NumberStyles.Any, CultureInfo.InvariantCulture, out rate) && rate > 0;
        }

        private void btnAddRoom_Click_1(object sender, EventArgs e)
        {
            if (cmbRoomType.SelectedItem == null && string.IsNullOrWhiteSpace(cmbRoomType.Text))
            {
                MessageBox.Show("Room type is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRoomType.Focus();
                return;
            }

            string rawRate = cmbRate.SelectedItem?.ToString() ?? cmbRate.Text.Trim();
            if (!TryParseRate(rawRate, out decimal rate))
            {
                MessageBox.Show("Price per night must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRate.Focus();
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
            RoomModel? targetRoom = null;

            if (dgvRooms.CurrentRow != null && dgvRooms.CurrentRow.DataBoundItem is RoomModel roomFromGrid)
            {
                targetRoom = roomFromGrid;
            }
            else if (_selectedRoomId != 0)
            {
                List<RoomModel> allRooms = _roomController.GetAllRooms();
                targetRoom = allRooms?.Find(r => r.RoomId == _selectedRoomId || string.Equals(r.RoomNumber, _selectedRoomNumber, StringComparison.OrdinalIgnoreCase));
            }

            if (targetRoom == null)
            {
                MessageBox.Show("Please select a room from the list to edit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string rawRate = cmbRate.SelectedItem?.ToString() ?? cmbRate.Text.Trim();
            if (!TryParseRate(rawRate, out decimal rate))
            {
                MessageBox.Show("Price per night must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRate.Focus();
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
            RoomModel? selectedRoom = null;

            if (dgvRooms.CurrentRow != null && dgvRooms.CurrentRow.DataBoundItem is RoomModel roomFromGrid)
            {
                selectedRoom = roomFromGrid;
            }
            else if (_selectedRoomId != 0)
            {
                List<RoomModel> allRooms = _roomController.GetAllRooms();
                selectedRoom = allRooms?.Find(r => r.RoomId == _selectedRoomId);
            }

            if (selectedRoom == null)
            {
                MessageBox.Show("Please select a room from the list to view.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            RoomInfo viewForm = new RoomInfo(
                selectedRoom.RoomNumber ?? string.Empty,
                selectedRoom.RoomType ?? string.Empty,
                selectedRoom.PricePerNight.ToString("N2"),
                selectedRoom.Status ?? "Available"
            );

            viewForm.ShowDialog();
        }

        private void btnDeactivateRoom_Click_1(object sender, EventArgs e)
        {
            RoomModel? targetRoom = null;

            if (dgvRooms.CurrentRow != null && dgvRooms.CurrentRow.DataBoundItem is RoomModel roomFromGrid)
            {
                targetRoom = roomFromGrid;
            }
            else if (_selectedRoomId != 0)
            {
                List<RoomModel> allRooms = _roomController.GetAllRooms();
                targetRoom = allRooms?.Find(r => r.RoomId == _selectedRoomId || string.Equals(r.RoomNumber, _selectedRoomNumber, StringComparison.OrdinalIgnoreCase));
            }

            if (targetRoom == null)
            {
                MessageBox.Show("Please select the room you want to deactivate from the list.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            cmbRate.SelectedIndex = -1;
            cmbRate.Text = string.Empty;
            cmbRoomType.SelectedIndex = -1;
            cmbRoomType.Text = string.Empty;
            dgvRooms.ClearSelection();
        }

        private void cmbRate_SelectedIndexChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD:InnovaStaySolution/UI/RoomMaintenanceForm.cs
            LoadRoomGrid();
=======

>>>>>>> main:InnovaStaySolution/UI/DesignRoomMaintenanceForm.cs
        }
    }
}