using System;
using System.Windows.Forms;

namespace UI
{
    public partial class RoomInfo : Form
    {
        public RoomInfo()
        {
            InitializeComponent();
        }

        public RoomInfo(string roomNumber, string roomType, string rate, string status) : this()
        {
            lblRoomNumber.Text = roomNumber;
            lblRoomType.Text = roomType;
            lblRoomRate.Text = rate;
            lblRoomStatus.Text = status;
        }
    }
}