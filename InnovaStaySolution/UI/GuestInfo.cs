using System;
using System.Windows.Forms;
using Model;

namespace UI
{
    public partial class GuestInfo : Form
    {
        private readonly GuestModel? _guest;

        public GuestInfo()
        {
            InitializeComponent();
        }

        public GuestInfo(GuestModel guest) : this()
        {
            _guest = guest;
            PopulateGuestDetails();
        }

        private void PopulateGuestDetails()
        {
            if (_guest == null) return;

            string fullName = !string.IsNullOrWhiteSpace(_guest.FullName)
                ? _guest.FullName
                : $"{_guest.FirstName} {_guest.LastName}".Trim();

            lblFullName.Text = string.IsNullOrWhiteSpace(fullName) ? "N/A" : fullName;
            lblAddress.Text = string.IsNullOrWhiteSpace(_guest.Address) ? "N/A" : _guest.Address;
            lblEmail.Text = string.IsNullOrWhiteSpace(_guest.Email) ? "N/A" : _guest.Email;
            lblContact.Text = string.IsNullOrWhiteSpace(_guest.PhoneNumber) ? "N/A" : _guest.PhoneNumber;
            lblAge.Text = _guest.Age > 0 ? _guest.Age.ToString() : "N/A";
            lblDOB.Text = _guest.DateOfBirth.HasValue
                ? _guest.DateOfBirth.Value.ToString("MMMM dd, yyyy")
                : "N/A";
        }
    }
}