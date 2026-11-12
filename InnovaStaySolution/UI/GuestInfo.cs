using System;
using System.Drawing;
using System.Linq;
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

            string address = string.IsNullOrWhiteSpace(_guest.Address) ? "N/A" : _guest.Address;
            string email = string.IsNullOrWhiteSpace(_guest.Email) ? "N/A" : _guest.Email;
            string contact = string.IsNullOrWhiteSpace(_guest.PhoneNumber) ? "N/A" : _guest.PhoneNumber;

            // Match the 4 value labels situated to the right of each bold title label
            var allLabels = this.Controls.OfType<Label>().ToList();

            SetValueNextToHeader(allLabels, "Full Name:", fullName);
            SetValueNextToHeader(allLabels, "Address:", address);
            SetValueNextToHeader(allLabels, "Email:", email);
            SetValueNextToHeader(allLabels, "Contact:", contact);
        }

        private void SetValueNextToHeader(System.Collections.Generic.List<Label> labels, string headerText, string valueText)
        {
            var header = labels.FirstOrDefault(l => l.Text.Trim().Equals(headerText, StringComparison.OrdinalIgnoreCase) && l.Font.Bold);
            if (header != null)
            {
                var valueLabel = labels.FirstOrDefault(l => l != header && Math.Abs(l.Top - header.Top) <= 10 && l.Left > header.Left);
                if (valueLabel != null)
                {
                    valueLabel.Text = valueText;
                }
            }
        }
    }
}