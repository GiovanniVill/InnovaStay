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

        public DesignRoomMaintenanceForm()
        {
            InitializeComponent();
            _roomController = new RoomController();
        }


        private void btnAddRoom_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomNumber.Text))
            {
                MessageBox.Show("Room number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbRoomType.SelectedItem == null && string.IsNullOrWhiteSpace(cmbRoomType.Text))
            {
                MessageBox.Show("Room type is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtRoomRate.Text.Trim(), out decimal rate) || rate <= 0)
            {
                MessageBox.Show("Price per night must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var room = new RoomModel
            {
                RoomNumber = txtRoomNumber.Text.Trim(),
                RoomType = cmbRoomType.SelectedItem?.ToString() ?? cmbRoomType.Text.Trim(),
                PricePerNight = rate,
                Floor = 1
            };

            var (success, message) = _roomController.AddRoom(room, _currentUserRole);
            MessageBox.Show(message, success ? "Success" : "Error", MessageBoxButtons.OK,
                success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (success)
            {
                ClearInputs();
            }
        }


        private void btnEditRoom_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomNumber.Text))
            {
                MessageBox.Show("Enter the room number you want to edit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtRoomRate.Text.Trim(), out decimal rate) || rate <= 0)
            {
                MessageBox.Show("Price per night must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            List<RoomModel> allRooms = _roomController.GetAllRooms();
            var targetRoom = allRooms.Find(r => string.Equals(r.RoomNumber, txtRoomNumber.Text.Trim(), StringComparison.OrdinalIgnoreCase));

            if (targetRoom == null)
            {
                MessageBox.Show($"Room '{txtRoomNumber.Text.Trim()}' not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            }
        }


        private void btnViewRoom_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomNumber.Text))
            {
                MessageBox.Show("Enter a Room Number to view its details.", "Input Needed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<RoomModel> allRooms = _roomController.GetAllRooms();
            var room = allRooms.Find(r => string.Equals(r.RoomNumber, txtRoomNumber.Text.Trim(), StringComparison.OrdinalIgnoreCase));

            if (room != null)
            {
                txtRoomNumber.Text = room.RoomNumber;
                cmbRoomType.Text = room.RoomType;
                txtRoomRate.Text = room.PricePerNight.ToString("F2");
                MessageBox.Show($"Room Found!\nNumber: {room.RoomNumber}\nType: {room.RoomType}\nRate: {room.PricePerNight:C}", "Room Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Room '{txtRoomNumber.Text.Trim()}' not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnDeactivateRoom_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomNumber.Text))
            {
                MessageBox.Show("Enter the Room Number you want to deactivate.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<RoomModel> allRooms = _roomController.GetAllRooms();
            var targetRoom = allRooms.Find(r => string.Equals(r.RoomNumber, txtRoomNumber.Text.Trim(), StringComparison.OrdinalIgnoreCase));

            if (targetRoom == null)
            {
                MessageBox.Show($"Room '{txtRoomNumber.Text.Trim()}' not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                }
            }
        }

        private void ClearInputs()
        {
            txtRoomNumber.Clear();
            txtRoomRate.Clear();
            cmbRoomType.SelectedIndex = -1;
            cmbRoomType.Text = string.Empty;
            cmbRoomStatus.SelectedIndex = -1;
            cmbRoomStatus.Text = string.Empty;
        }

        
        
    }
}