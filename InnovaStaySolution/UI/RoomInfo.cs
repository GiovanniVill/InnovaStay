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
                lblBedCount.Text = _room.BedCount.ToString();
                lblRate.Text = $"PHP {_room.PricePerNight:N2}";
                lblStatus.Text = _room.Status;

                switch (_room.RoomType?.Trim().ToLower())
                {
                    case "single":
                        lblRoomSize.Text = "22 sqm";
                        lblRoomCapacity.Text = "1–2 Guests";
                        break;
                    case "double":
                        lblRoomSize.Text = "28 sqm";
                        lblRoomCapacity.Text = "2 Guests";
                        break;
                    case "deluxe":
                        lblRoomSize.Text = "35 sqm";
                        lblRoomCapacity.Text = "2–3 Guests";
                        break;
                    case "suite":
                        lblRoomSize.Text = "50 sqm";
                        lblRoomCapacity.Text = "2–4 Guests";
                        break;
                    default:
                        lblRoomSize.Text = "25 sqm";
                        lblRoomCapacity.Text = $"{_room.BedCount * 2} Guests";
                        break;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}