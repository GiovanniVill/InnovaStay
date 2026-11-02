using System;
using System.Drawing;
using System.Windows.Forms;
using Model;

namespace UI
{
    public partial class RoomInfo : Form
    {
        private readonly RoomModel? _room;

        public RoomInfo()
        {
            InitializeComponent();
        }

        public RoomInfo(RoomModel room) : this()
        {
            _room = room;
        }

        private void RoomInfo_Load_1(object sender, EventArgs e)
        {
            if (_room != null)
            {
                lblRoomNo.Text = _room.RoomNumber;
                lblType.Text = _room.RoomType;
                lblRate.Text = $"PHP {_room.PricePerNight:N2}";
                lblStatus.Text = _room.Status;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}