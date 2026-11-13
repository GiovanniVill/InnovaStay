namespace UI
{
    partial class GuestManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnlLeftSidebar = new Panel();
            btnDeleteGuest = new Button();
            btnViewGuest = new Button();
            btnEditGuest = new Button();
            btnAddGuest = new Button();
            txtProvince = new TextBox();
            txtMunicipality = new TextBox();
            txtBarangay = new TextBox();
            lblAddress = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtContact = new TextBox();
            lblContact = new Label();
            txtMiddleName = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            lblFullName = new Label();
            txtGuestId = new TextBox();
            lblGuestId = new Label();
            pnlRightContent = new Panel();
            dgvGuests = new DataGridView();
            pnlHeaderBar = new Panel();
            btnClearSearch = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            lblDirectoryTitle = new Label();
            txtAge = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dtpDOB = new DateTimePicker();
            pnlLeftSidebar.SuspendLayout();
            pnlRightContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuests).BeginInit();
            pnlHeaderBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeftSidebar
            // 
            pnlLeftSidebar.AutoScroll = true;
            pnlLeftSidebar.BackColor = Color.FromArgb(238, 236, 203);
            pnlLeftSidebar.Controls.Add(dtpDOB);
            pnlLeftSidebar.Controls.Add(label2);
            pnlLeftSidebar.Controls.Add(label1);
            pnlLeftSidebar.Controls.Add(txtAge);
            pnlLeftSidebar.Controls.Add(btnDeleteGuest);
            pnlLeftSidebar.Controls.Add(btnViewGuest);
            pnlLeftSidebar.Controls.Add(btnEditGuest);
            pnlLeftSidebar.Controls.Add(btnAddGuest);
            pnlLeftSidebar.Controls.Add(txtProvince);
            pnlLeftSidebar.Controls.Add(txtMunicipality);
            pnlLeftSidebar.Controls.Add(txtBarangay);
            pnlLeftSidebar.Controls.Add(lblAddress);
            pnlLeftSidebar.Controls.Add(txtEmail);
            pnlLeftSidebar.Controls.Add(lblEmail);
            pnlLeftSidebar.Controls.Add(txtContact);
            pnlLeftSidebar.Controls.Add(lblContact);
            pnlLeftSidebar.Controls.Add(txtMiddleName);
            pnlLeftSidebar.Controls.Add(txtFirstName);
            pnlLeftSidebar.Controls.Add(txtLastName);
            pnlLeftSidebar.Controls.Add(lblFullName);
            pnlLeftSidebar.Controls.Add(txtGuestId);
            pnlLeftSidebar.Controls.Add(lblGuestId);
            pnlLeftSidebar.Dock = DockStyle.Left;
            pnlLeftSidebar.Location = new Point(0, 0);
            pnlLeftSidebar.Name = "pnlLeftSidebar";
            pnlLeftSidebar.Padding = new Padding(18, 16, 18, 16);
            pnlLeftSidebar.Size = new Size(340, 650);
            pnlLeftSidebar.TabIndex = 0;
            pnlLeftSidebar.Click += pnlLeftSidebar_Click;
            // 
            // btnDeleteGuest
            // 
            btnDeleteGuest.BackColor = Color.FromArgb(220, 53, 69);
            btnDeleteGuest.Cursor = Cursors.Hand;
            btnDeleteGuest.FlatAppearance.BorderSize = 0;
            btnDeleteGuest.FlatStyle = FlatStyle.Flat;
            btnDeleteGuest.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDeleteGuest.ForeColor = Color.White;
            btnDeleteGuest.Location = new Point(174, 481);
            btnDeleteGuest.Name = "btnDeleteGuest";
            btnDeleteGuest.Size = new Size(144, 38);
            btnDeleteGuest.TabIndex = 17;
            btnDeleteGuest.Text = "Delete Guest";
            btnDeleteGuest.UseVisualStyleBackColor = false;
            btnDeleteGuest.Click += btnDeleteGuest_Click;
            // 
            // btnViewGuest
            // 
            btnViewGuest.BackColor = Color.FromArgb(184, 172, 102);
            btnViewGuest.Cursor = Cursors.Hand;
            btnViewGuest.FlatAppearance.BorderSize = 0;
            btnViewGuest.FlatStyle = FlatStyle.Flat;
            btnViewGuest.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnViewGuest.ForeColor = Color.White;
            btnViewGuest.Location = new Point(18, 481);
            btnViewGuest.Name = "btnViewGuest";
            btnViewGuest.Size = new Size(144, 38);
            btnViewGuest.TabIndex = 16;
            btnViewGuest.Text = "View Guest";
            btnViewGuest.UseVisualStyleBackColor = false;
            btnViewGuest.Click += btnViewGuest_Click;
            // 
            // btnEditGuest
            // 
            btnEditGuest.BackColor = Color.FromArgb(184, 172, 102);
            btnEditGuest.Cursor = Cursors.Hand;
            btnEditGuest.FlatAppearance.BorderSize = 0;
            btnEditGuest.FlatStyle = FlatStyle.Flat;
            btnEditGuest.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEditGuest.ForeColor = Color.White;
            btnEditGuest.Location = new Point(174, 418);
            btnEditGuest.Name = "btnEditGuest";
            btnEditGuest.Size = new Size(144, 38);
            btnEditGuest.TabIndex = 15;
            btnEditGuest.Text = "Edit Guest";
            btnEditGuest.UseVisualStyleBackColor = false;
            btnEditGuest.Click += btnEditGuest_Click;
            // 
            // btnAddGuest
            // 
            btnAddGuest.BackColor = Color.FromArgb(184, 172, 102);
            btnAddGuest.Cursor = Cursors.Hand;
            btnAddGuest.FlatAppearance.BorderSize = 0;
            btnAddGuest.FlatStyle = FlatStyle.Flat;
            btnAddGuest.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAddGuest.ForeColor = Color.White;
            btnAddGuest.Location = new Point(18, 418);
            btnAddGuest.Name = "btnAddGuest";
            btnAddGuest.Size = new Size(144, 38);
            btnAddGuest.TabIndex = 14;
            btnAddGuest.Text = "Add Guest";
            btnAddGuest.UseVisualStyleBackColor = false;
            btnAddGuest.Click += btnAddGuest_Click;
            // 
            // txtProvince
            // 
            txtProvince.BorderStyle = BorderStyle.FixedSingle;
            txtProvince.Font = new Font("Segoe UI", 9F);
            txtProvince.Location = new Point(222, 286);
            txtProvince.Name = "txtProvince";
            txtProvince.PlaceholderText = "Province";
            txtProvince.Size = new Size(96, 23);
            txtProvince.TabIndex = 13;
            // 
            // txtMunicipality
            // 
            txtMunicipality.BorderStyle = BorderStyle.FixedSingle;
            txtMunicipality.Font = new Font("Segoe UI", 9F);
            txtMunicipality.Location = new Point(120, 286);
            txtMunicipality.Name = "txtMunicipality";
            txtMunicipality.PlaceholderText = "Municipality";
            txtMunicipality.Size = new Size(96, 23);
            txtMunicipality.TabIndex = 12;
            // 
            // txtBarangay
            // 
            txtBarangay.BorderStyle = BorderStyle.FixedSingle;
            txtBarangay.Font = new Font("Segoe UI", 9F);
            txtBarangay.Location = new Point(18, 286);
            txtBarangay.Name = "txtBarangay";
            txtBarangay.PlaceholderText = "Barangay";
            txtBarangay.Size = new Size(96, 23);
            txtBarangay.TabIndex = 11;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 8.8F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(60, 60, 50);
            lblAddress.Location = new Point(18, 265);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(242, 15);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "Address (Barangay, Municipality, Province):";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 9.5F);
            txtEmail.Location = new Point(18, 226);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "guest@email.com";
            txtEmail.Size = new Size(300, 24);
            txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 8.8F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(60, 60, 50);
            lblEmail.Location = new Point(18, 205);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(86, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email Address:";
            // 
            // txtContact
            // 
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.Font = new Font("Segoe UI", 9.5F);
            txtContact.Location = new Point(18, 166);
            txtContact.Name = "txtContact";
            txtContact.PlaceholderText = "09XXXXXXXXX";
            txtContact.Size = new Size(300, 24);
            txtContact.TabIndex = 7;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 8.8F, FontStyle.Bold);
            lblContact.ForeColor = Color.FromArgb(60, 60, 50);
            lblContact.Location = new Point(18, 145);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(102, 15);
            lblContact.TabIndex = 6;
            lblContact.Text = "Contact Number:";
            // 
            // txtMiddleName
            // 
            txtMiddleName.BorderStyle = BorderStyle.FixedSingle;
            txtMiddleName.Font = new Font("Segoe UI", 9F);
            txtMiddleName.Location = new Point(222, 106);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.PlaceholderText = "Middle Name";
            txtMiddleName.Size = new Size(96, 23);
            txtMiddleName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 9F);
            txtFirstName.Location = new Point(120, 106);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(96, 23);
            txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 9F);
            txtLastName.Location = new Point(18, 106);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(96, 23);
            txtLastName.TabIndex = 3;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 8.8F, FontStyle.Bold);
            lblFullName.ForeColor = Color.FromArgb(60, 60, 50);
            lblFullName.Location = new Point(18, 85);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(172, 15);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full Name (Last, First, Middle):";
            // 
            // txtGuestId
            // 
            txtGuestId.BackColor = Color.FromArgb(245, 245, 240);
            txtGuestId.BorderStyle = BorderStyle.FixedSingle;
            txtGuestId.Font = new Font("Segoe UI", 9.5F);
            txtGuestId.Location = new Point(18, 46);
            txtGuestId.Name = "txtGuestId";
            txtGuestId.ReadOnly = true;
            txtGuestId.Size = new Size(300, 24);
            txtGuestId.TabIndex = 1;
            txtGuestId.Text = "(Auto-Generated)";
            // 
            // lblGuestId
            // 
            lblGuestId.AutoSize = true;
            lblGuestId.Font = new Font("Segoe UI", 8.8F, FontStyle.Bold);
            lblGuestId.ForeColor = Color.FromArgb(60, 60, 50);
            lblGuestId.Location = new Point(18, 25);
            lblGuestId.Name = "lblGuestId";
            lblGuestId.Size = new Size(133, 15);
            lblGuestId.TabIndex = 0;
            lblGuestId.Text = "Guest ID (Automated):";
            // 
            // pnlRightContent
            // 
            pnlRightContent.BackColor = Color.FromArgb(195, 198, 202);
            pnlRightContent.Controls.Add(dgvGuests);
            pnlRightContent.Controls.Add(pnlHeaderBar);
            pnlRightContent.Dock = DockStyle.Fill;
            pnlRightContent.Location = new Point(340, 0);
            pnlRightContent.Name = "pnlRightContent";
            pnlRightContent.Size = new Size(780, 650);
            pnlRightContent.TabIndex = 1;
            // 
            // dgvGuests
            // 
            dgvGuests.AllowUserToAddRows = false;
            dgvGuests.AllowUserToDeleteRows = false;
            dgvGuests.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(250, 250, 246);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(226, 222, 190);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(20, 26, 40);
            dgvGuests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvGuests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGuests.BackgroundColor = Color.White;
            dgvGuests.BorderStyle = BorderStyle.None;
            dgvGuests.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGuests.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(20, 26, 40);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(20, 26, 40);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvGuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvGuests.ColumnHeadersHeight = 38;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(226, 222, 190);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(20, 26, 40);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvGuests.DefaultCellStyle = dataGridViewCellStyle6;
            dgvGuests.Dock = DockStyle.Fill;
            dgvGuests.EnableHeadersVisualStyles = false;
            dgvGuests.GridColor = Color.FromArgb(230, 233, 236);
            dgvGuests.Location = new Point(0, 46);
            dgvGuests.MultiSelect = false;
            dgvGuests.Name = "dgvGuests";
            dgvGuests.ReadOnly = true;
            dgvGuests.RowHeadersVisible = false;
            dgvGuests.RowTemplate.Height = 36;
            dgvGuests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGuests.Size = new Size(780, 604);
            dgvGuests.TabIndex = 1;
            dgvGuests.CellClick += dgvGuests_CellClick;
            dgvGuests.MouseDown += dgvGuests_MouseDown;
            // 
            // pnlHeaderBar
            // 
            pnlHeaderBar.BackColor = Color.FromArgb(195, 198, 202);
            pnlHeaderBar.Controls.Add(btnClearSearch);
            pnlHeaderBar.Controls.Add(txtSearch);
            pnlHeaderBar.Controls.Add(lblSearch);
            pnlHeaderBar.Controls.Add(lblDirectoryTitle);
            pnlHeaderBar.Dock = DockStyle.Top;
            pnlHeaderBar.Location = new Point(0, 0);
            pnlHeaderBar.Name = "pnlHeaderBar";
            pnlHeaderBar.Size = new Size(780, 46);
            pnlHeaderBar.TabIndex = 0;
            // 
            // btnClearSearch
            // 
            btnClearSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClearSearch.BackColor = Color.FromArgb(184, 172, 102);
            btnClearSearch.Cursor = Cursors.Hand;
            btnClearSearch.FlatAppearance.BorderSize = 0;
            btnClearSearch.FlatStyle = FlatStyle.Flat;
            btnClearSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClearSearch.ForeColor = Color.White;
            btnClearSearch.Location = new Point(699, 10);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(65, 26);
            btnClearSearch.TabIndex = 3;
            btnClearSearch.Text = "Clear";
            btnClearSearch.UseVisualStyleBackColor = false;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(463, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Name, contact, address...";
            txtSearch.Size = new Size(230, 24);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(20, 26, 40);
            lblSearch.Location = new Point(407, 14);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(48, 15);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search:";
            // 
            // lblDirectoryTitle
            // 
            lblDirectoryTitle.AutoSize = true;
            lblDirectoryTitle.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblDirectoryTitle.ForeColor = Color.FromArgb(20, 26, 40);
            lblDirectoryTitle.Location = new Point(16, 12);
            lblDirectoryTitle.Name = "lblDirectoryTitle";
            lblDirectoryTitle.Size = new Size(159, 21);
            lblDirectoryTitle.TabIndex = 0;
            lblDirectoryTitle.Text = "Guest Directory List";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(18, 343);
            txtAge.Name = "txtAge";
            txtAge.PlaceholderText = "Age";
            txtAge.Size = new Size(86, 24);
            txtAge.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.8F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(60, 60, 50);
            label1.Location = new Point(21, 325);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 19;
            label1.Text = "Age:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.8F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(60, 60, 50);
            label2.Location = new Point(120, 325);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 20;
            label2.Text = "Date of Birth:";
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(110, 343);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(208, 24);
            dtpDOB.TabIndex = 21;
            // 
            // GuestManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 236, 203);
            ClientSize = new Size(1120, 650);
            Controls.Add(pnlRightContent);
            Controls.Add(pnlLeftSidebar);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GuestManagementForm";
            Text = "Guest Management";
            Load += GuestManagementForm_Load;
            pnlLeftSidebar.ResumeLayout(false);
            pnlLeftSidebar.PerformLayout();
            pnlRightContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGuests).EndInit();
            pnlHeaderBar.ResumeLayout(false);
            pnlHeaderBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftSidebar;
        private System.Windows.Forms.Label lblGuestId;
        private System.Windows.Forms.TextBox txtGuestId;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtBarangay;
        private System.Windows.Forms.TextBox txtMunicipality;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.Button btnEditGuest;
        private System.Windows.Forms.Button btnViewGuest;
        private System.Windows.Forms.Button btnDeleteGuest;
        private System.Windows.Forms.Panel pnlRightContent;
        private System.Windows.Forms.Panel pnlHeaderBar;
        private System.Windows.Forms.Label lblDirectoryTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.DataGridView dgvGuests;
        private DateTimePicker dtpDOB;
        private Label label2;
        private Label label1;
        private TextBox txtAge;
    }
}