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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            pnlLeftSidebar = new System.Windows.Forms.Panel();
            btnDeleteGuest = new System.Windows.Forms.Button();
            btnViewGuest = new System.Windows.Forms.Button();
            btnEditGuest = new System.Windows.Forms.Button();
            btnAddGuest = new System.Windows.Forms.Button();
            txtProvince = new System.Windows.Forms.TextBox();
            txtMunicipality = new System.Windows.Forms.TextBox();
            txtBarangay = new System.Windows.Forms.TextBox();
            lblAddress = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            txtContact = new System.Windows.Forms.TextBox();
            lblContact = new System.Windows.Forms.Label();
            txtMiddleName = new System.Windows.Forms.TextBox();
            txtFirstName = new System.Windows.Forms.TextBox();
            txtLastName = new System.Windows.Forms.TextBox();
            lblFullName = new System.Windows.Forms.Label();
            txtGuestId = new System.Windows.Forms.TextBox();
            lblGuestId = new System.Windows.Forms.Label();
            pnlRightContent = new System.Windows.Forms.Panel();
            dgvGuests = new System.Windows.Forms.DataGridView();
            pnlHeaderBar = new System.Windows.Forms.Panel();
            btnClearSearch = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            lblSearch = new System.Windows.Forms.Label();
            lblDirectoryTitle = new System.Windows.Forms.Label();
            pnlLeftSidebar.SuspendLayout();
            pnlRightContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuests).BeginInit();
            pnlHeaderBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeftSidebar
            // 
            pnlLeftSidebar.AutoScroll = true;
            pnlLeftSidebar.BackColor = System.Drawing.Color.FromArgb(238, 236, 203);
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
            pnlLeftSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            pnlLeftSidebar.Location = new System.Drawing.Point(0, 0);
            pnlLeftSidebar.Name = "pnlLeftSidebar";
            pnlLeftSidebar.Padding = new System.Windows.Forms.Padding(18, 16, 18, 16);
            pnlLeftSidebar.Size = new System.Drawing.Size(340, 650);
            pnlLeftSidebar.TabIndex = 0;
            pnlLeftSidebar.Click += pnlLeftSidebar_Click;
            // 
            // btnDeleteGuest
            // 
            btnDeleteGuest.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            btnDeleteGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDeleteGuest.FlatAppearance.BorderSize = 0;
            btnDeleteGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteGuest.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnDeleteGuest.ForeColor = System.Drawing.Color.White;
            btnDeleteGuest.Location = new System.Drawing.Point(174, 388);
            btnDeleteGuest.Name = "btnDeleteGuest";
            btnDeleteGuest.Size = new System.Drawing.Size(144, 38);
            btnDeleteGuest.TabIndex = 17;
            btnDeleteGuest.Text = "Delete Guest";
            btnDeleteGuest.UseVisualStyleBackColor = false;
            btnDeleteGuest.Click += btnDeleteGuest_Click;
            // 
            // btnViewGuest
            // 
            btnViewGuest.BackColor = System.Drawing.Color.FromArgb(184, 172, 102);
            btnViewGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            btnViewGuest.FlatAppearance.BorderSize = 0;
            btnViewGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnViewGuest.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnViewGuest.ForeColor = System.Drawing.Color.White;
            btnViewGuest.Location = new System.Drawing.Point(18, 388);
            btnViewGuest.Name = "btnViewGuest";
            btnViewGuest.Size = new System.Drawing.Size(144, 38);
            btnViewGuest.TabIndex = 16;
            btnViewGuest.Text = "View Guest";
            btnViewGuest.UseVisualStyleBackColor = false;
            btnViewGuest.Click += btnViewGuest_Click;
            // 
            // btnEditGuest
            // 
            btnEditGuest.BackColor = System.Drawing.Color.FromArgb(184, 172, 102);
            btnEditGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditGuest.FlatAppearance.BorderSize = 0;
            btnEditGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditGuest.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnEditGuest.ForeColor = System.Drawing.Color.White;
            btnEditGuest.Location = new System.Drawing.Point(174, 338);
            btnEditGuest.Name = "btnEditGuest";
            btnEditGuest.Size = new System.Drawing.Size(144, 38);
            btnEditGuest.TabIndex = 15;
            btnEditGuest.Text = "Edit Guest";
            btnEditGuest.UseVisualStyleBackColor = false;
            btnEditGuest.Click += btnEditGuest_Click;
            // 
            // btnAddGuest
            // 
            btnAddGuest.BackColor = System.Drawing.Color.FromArgb(184, 172, 102);
            btnAddGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddGuest.FlatAppearance.BorderSize = 0;
            btnAddGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddGuest.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnAddGuest.ForeColor = System.Drawing.Color.White;
            btnAddGuest.Location = new System.Drawing.Point(18, 338);
            btnAddGuest.Name = "btnAddGuest";
            btnAddGuest.Size = new System.Drawing.Size(144, 38);
            btnAddGuest.TabIndex = 14;
            btnAddGuest.Text = "Add Guest";
            btnAddGuest.UseVisualStyleBackColor = false;
            btnAddGuest.Click += btnAddGuest_Click;
            // 
            // txtProvince
            // 
            txtProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtProvince.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtProvince.Location = new System.Drawing.Point(222, 286);
            txtProvince.Name = "txtProvince";
            txtProvince.PlaceholderText = "Province";
            txtProvince.Size = new System.Drawing.Size(96, 23);
            txtProvince.TabIndex = 13;
            // 
            // txtMunicipality
            // 
            txtMunicipality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtMunicipality.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtMunicipality.Location = new System.Drawing.Point(120, 286);
            txtMunicipality.Name = "txtMunicipality";
            txtMunicipality.PlaceholderText = "Municipality";
            txtMunicipality.Size = new System.Drawing.Size(96, 23);
            txtMunicipality.TabIndex = 12;
            // 
            // txtBarangay
            // 
            txtBarangay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtBarangay.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtBarangay.Location = new System.Drawing.Point(18, 286);
            txtBarangay.Name = "txtBarangay";
            txtBarangay.PlaceholderText = "Barangay";
            txtBarangay.Size = new System.Drawing.Size(96, 23);
            txtBarangay.TabIndex = 11;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new System.Drawing.Font("Segoe UI", 8.8F, System.Drawing.FontStyle.Bold);
            lblAddress.ForeColor = System.Drawing.Color.FromArgb(60, 60, 50);
            lblAddress.Location = new System.Drawing.Point(18, 265);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new System.Drawing.Size(232, 15);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "Address (Barangay, Municipality, Province):";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtEmail.Location = new System.Drawing.Point(18, 226);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "guest@email.com";
            txtEmail.Size = new System.Drawing.Size(300, 24);
            txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Segoe UI", 8.8F, System.Drawing.FontStyle.Bold);
            lblEmail.ForeColor = System.Drawing.Color.FromArgb(60, 60, 50);
            lblEmail.Location = new System.Drawing.Point(18, 205);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(84, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email Address:";
            // 
            // txtContact
            // 
            txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtContact.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtContact.Location = new System.Drawing.Point(18, 166);
            txtContact.Name = "txtContact";
            txtContact.PlaceholderText = "09XXXXXXXXX";
            txtContact.Size = new System.Drawing.Size(300, 24);
            txtContact.TabIndex = 7;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new System.Drawing.Font("Segoe UI", 8.8F, System.Drawing.FontStyle.Bold);
            lblContact.ForeColor = System.Drawing.Color.FromArgb(60, 60, 50);
            lblContact.Location = new System.Drawing.Point(18, 145);
            lblContact.Name = "lblContact";
            lblContact.Size = new System.Drawing.Size(98, 15);
            lblContact.TabIndex = 6;
            lblContact.Text = "Contact Number:";
            // 
            // txtMiddleName
            // 
            txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtMiddleName.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtMiddleName.Location = new System.Drawing.Point(222, 106);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.PlaceholderText = "Middle Name";
            txtMiddleName.Size = new System.Drawing.Size(96, 23);
            txtMiddleName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtFirstName.Location = new System.Drawing.Point(120, 106);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new System.Drawing.Size(96, 23);
            txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtLastName.Location = new System.Drawing.Point(18, 106);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new System.Drawing.Size(96, 23);
            txtLastName.TabIndex = 3;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new System.Drawing.Font("Segoe UI", 8.8F, System.Drawing.FontStyle.Bold);
            lblFullName.ForeColor = System.Drawing.Color.FromArgb(60, 60, 50);
            lblFullName.Location = new System.Drawing.Point(18, 85);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new System.Drawing.Size(173, 15);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full Name (Last, First, Middle):";
            // 
            // txtGuestId
            // 
            txtGuestId.BackColor = System.Drawing.Color.FromArgb(245, 245, 240);
            txtGuestId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtGuestId.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtGuestId.Location = new System.Drawing.Point(18, 46);
            txtGuestId.Name = "txtGuestId";
            txtGuestId.ReadOnly = true;
            txtGuestId.Size = new System.Drawing.Size(300, 24);
            txtGuestId.TabIndex = 1;
            txtGuestId.Text = "(Auto-Generated)";
            // 
            // lblGuestId
            // 
            lblGuestId.AutoSize = true;
            lblGuestId.Font = new System.Drawing.Font("Segoe UI", 8.8F, System.Drawing.FontStyle.Bold);
            lblGuestId.ForeColor = System.Drawing.Color.FromArgb(60, 60, 50);
            lblGuestId.Location = new System.Drawing.Point(18, 25);
            lblGuestId.Name = "lblGuestId";
            lblGuestId.Size = new System.Drawing.Size(123, 15);
            lblGuestId.TabIndex = 0;
            lblGuestId.Text = "Guest ID (Automated):";
            // 
            // pnlRightContent
            // 
            pnlRightContent.BackColor = System.Drawing.Color.FromArgb(195, 198, 202);
            pnlRightContent.Controls.Add(dgvGuests);
            pnlRightContent.Controls.Add(pnlHeaderBar);
            pnlRightContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlRightContent.Location = new System.Drawing.Point(340, 0);
            pnlRightContent.Name = "pnlRightContent";
            pnlRightContent.Size = new System.Drawing.Size(780, 650);
            pnlRightContent.TabIndex = 1;
            // 
            // dgvGuests
            // 
            dgvGuests.AllowUserToAddRows = false;
            dgvGuests.AllowUserToDeleteRows = false;
            dgvGuests.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(250, 250, 246);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(226, 222, 190);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(20, 26, 40);
            dgvGuests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvGuests.BackgroundColor = System.Drawing.Color.White;
            dgvGuests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvGuests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGuests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(20, 26, 40);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(20, 26, 40);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvGuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvGuests.ColumnHeadersHeight = 38;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(226, 222, 190);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(20, 26, 40);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvGuests.DefaultCellStyle = dataGridViewCellStyle3;
            dgvGuests.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvGuests.EnableHeadersVisualStyles = false;
            dgvGuests.GridColor = System.Drawing.Color.FromArgb(230, 233, 236);
            dgvGuests.Location = new System.Drawing.Point(0, 46);
            dgvGuests.MultiSelect = false;
            dgvGuests.Name = "dgvGuests";
            dgvGuests.ReadOnly = true;
            dgvGuests.RowHeadersVisible = false;
            dgvGuests.RowTemplate.Height = 36;
            dgvGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvGuests.Size = new System.Drawing.Size(780, 604);
            dgvGuests.TabIndex = 1;
            dgvGuests.CellClick += dgvGuests_CellClick;
            dgvGuests.MouseDown += dgvGuests_MouseDown;
            // 
            // pnlHeaderBar
            // 
            pnlHeaderBar.BackColor = System.Drawing.Color.FromArgb(195, 198, 202);
            pnlHeaderBar.Controls.Add(btnClearSearch);
            pnlHeaderBar.Controls.Add(txtSearch);
            pnlHeaderBar.Controls.Add(lblSearch);
            pnlHeaderBar.Controls.Add(lblDirectoryTitle);
            pnlHeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeaderBar.Location = new System.Drawing.Point(0, 0);
            pnlHeaderBar.Name = "pnlHeaderBar";
            pnlHeaderBar.Size = new System.Drawing.Size(780, 46);
            pnlHeaderBar.TabIndex = 0;
            // 
            // btnClearSearch
            // 
            btnClearSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnClearSearch.BackColor = System.Drawing.Color.FromArgb(184, 172, 102);
            btnClearSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClearSearch.FlatAppearance.BorderSize = 0;
            btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClearSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnClearSearch.ForeColor = System.Drawing.Color.White;
            btnClearSearch.Location = new System.Drawing.Point(699, 10);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new System.Drawing.Size(65, 26);
            btnClearSearch.TabIndex = 3;
            btnClearSearch.Text = "Clear";
            btnClearSearch.UseVisualStyleBackColor = false;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtSearch.Location = new System.Drawing.Point(463, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Name, contact, address...";
            txtSearch.Size = new System.Drawing.Size(230, 24);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblSearch.AutoSize = true;
            lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblSearch.ForeColor = System.Drawing.Color.FromArgb(20, 26, 40);
            lblSearch.Location = new System.Drawing.Point(407, 14);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new System.Drawing.Size(49, 15);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search:";
            // 
            // lblDirectoryTitle
            // 
            lblDirectoryTitle.AutoSize = true;
            lblDirectoryTitle.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            lblDirectoryTitle.ForeColor = System.Drawing.Color.FromArgb(20, 26, 40);
            lblDirectoryTitle.Location = new System.Drawing.Point(16, 12);
            lblDirectoryTitle.Name = "lblDirectoryTitle";
            lblDirectoryTitle.Size = new System.Drawing.Size(158, 20);
            lblDirectoryTitle.TabIndex = 0;
            lblDirectoryTitle.Text = "Guest Directory List";
            // 
            // GuestManagementForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(238, 236, 203);
            ClientSize = new System.Drawing.Size(1120, 650);
            Controls.Add(pnlRightContent);
            Controls.Add(pnlLeftSidebar);
            Font = new System.Drawing.Font("Segoe UI", 9.5F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    }
}