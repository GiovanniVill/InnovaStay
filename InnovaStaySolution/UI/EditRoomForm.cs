using System;
using System.Windows.Forms;
using BusinessLogic.Controller;

namespace UI
{
    public partial class EditRoomForm : Form
    {
        private readonly RoomController _roomController;
        private readonly int _roomId;

        public EditRoomForm(int roomId, string roomNumber, string roomType, decimal pricePerNight, string status)
        {
            InitializeComponent();
            _roomController = new RoomController();
            _roomId = roomId;

            // Pre-fill editable controls
            lblRoomIdVal.Text = roomId.ToString();
            txtRoomNumber.Text = roomNumber;
            cmbRoomType.SelectedItem = roomType;
            txtPrice.Text = pricePerNight.ToString("F2");
            cmbStatus.SelectedItem = status;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomNumber.Text))
            {
                MessageBox.Show("Please enter a room number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbRoomType.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a room type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price) || price <= 0)
            {
                MessageBox.Show("Price per night must be greater than zero.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a room status.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create the model matching your existing architecture
            var room = new Model.RoomModel
            {
                RoomId = _roomId,
                RoomNumber = txtRoomNumber.Text.Trim(),
                RoomType = cmbRoomType.SelectedItem?.ToString() ?? "Standard",
                PricePerNight = price,
                Status = cmbStatus.SelectedItem?.ToString() ?? "Available"
            };

            // Pass the model and current user role from UserSession
               var result = _roomController.UpdateRoom(room, "Admin"); 

            if (result.Success)
            {
                MessageBox.Show(result.Message, "Room Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}