namespace UI
{
    partial class BillingForm
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
            lblTitle = new System.Windows.Forms.Label();
            lblSelect = new System.Windows.Forms.Label();
            cmbActiveStays = new System.Windows.Forms.ComboBox();
            grpSummary = new System.Windows.Forms.GroupBox();
            lblGuestInfo = new System.Windows.Forms.Label();
            lblRoomRate = new System.Windows.Forms.Label();
            lblTotalCharges = new System.Windows.Forms.Label();
            lblTotalPaid = new System.Windows.Forms.Label();
            lblBalanceDue = new System.Windows.Forms.Label();
            dgvCharges = new System.Windows.Forms.DataGridView();
            colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            grpAddCharge = new System.Windows.Forms.GroupBox();
            lblCDesc = new System.Windows.Forms.Label();
            txtChargeDesc = new System.Windows.Forms.TextBox();
            lblCAmt = new System.Windows.Forms.Label();
            txtChargeAmount = new System.Windows.Forms.TextBox();
            btnAddCharge = new System.Windows.Forms.Button();
            grpPayment = new System.Windows.Forms.GroupBox();
            lblPMethod = new System.Windows.Forms.Label();
            cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            lblPAmt = new System.Windows.Forms.Label();
            txtPaymentAmount = new System.Windows.Forms.TextBox();
            btnPay = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            grpSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCharges).BeginInit();
            grpAddCharge.SuspendLayout();
            grpPayment.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(20, 26, 40);
            lblTitle.Location = new System.Drawing.Point(25, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(332, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Guest Folio & Billing Settlement";
            // 
            // lblSelect
            // 
            lblSelect.AutoSize = true;
            lblSelect.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            lblSelect.ForeColor = System.Drawing.Color.FromArgb(20, 26, 40);
            lblSelect.Location = new System.Drawing.Point(25, 68);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new System.Drawing.Size(126, 17);
            lblSelect.TabIndex = 1;
            lblSelect.Text = "Select Active Stay:";
            // 
            // cmbActiveStays
            // 
            cmbActiveStays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbActiveStays.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            cmbActiveStays.FormattingEnabled = true;
            cmbActiveStays.Location = new System.Drawing.Point(160, 65);
            cmbActiveStays.Name = "cmbActiveStays";
            cmbActiveStays.Size = new System.Drawing.Size(420, 25);
            cmbActiveStays.TabIndex = 2;
            cmbActiveStays.SelectedIndexChanged += cmbActiveStays_SelectedIndexChanged;
            // 
            // grpSummary
            // 
            grpSummary.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpSummary.Controls.Add(lblGuestInfo);
            grpSummary.Controls.Add(lblRoomRate);
            grpSummary.Controls.Add(lblTotalCharges);
            grpSummary.Controls.Add(lblTotalPaid);
            grpSummary.Controls.Add(lblBalanceDue);
            grpSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            grpSummary.Location = new System.Drawing.Point(25, 105);
            grpSummary.Name = "grpSummary";
            grpSummary.Size = new System.Drawing.Size(1035, 110);
            grpSummary.TabIndex = 3;
            grpSummary.TabStop = false;
            grpSummary.Text = "Stay & Balance Summary";
            // 
            // lblGuestInfo
            // 
            lblGuestInfo.AutoSize = true;
            lblGuestInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblGuestInfo.Location = new System.Drawing.Point(20, 30);
            lblGuestInfo.Name = "lblGuestInfo";
            lblGuestInfo.Size = new System.Drawing.Size(48, 15);
            lblGuestInfo.TabIndex = 0;
            lblGuestInfo.Text = "Guest: -";
            // 
            // lblRoomRate
            // 
            lblRoomRate.AutoSize = true;
            lblRoomRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblRoomRate.Location = new System.Drawing.Point(20, 65);
            lblRoomRate.Name = "lblRoomRate";
            lblRoomRate.Size = new System.Drawing.Size(133, 15);
            lblRoomRate.TabIndex = 1;
            lblRoomRate.Text = "Room Charges: PHP 0.00";
            // 
            // lblTotalCharges
            // 
            lblTotalCharges.AutoSize = true;
            lblTotalCharges.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblTotalCharges.Location = new System.Drawing.Point(280, 65);
            lblTotalCharges.Name = "lblTotalCharges";
            lblTotalCharges.Size = new System.Drawing.Size(127, 15);
            lblTotalCharges.TabIndex = 2;
            lblTotalCharges.Text = "Extra Charges: PHP 0.00";
            // 
            // lblTotalPaid
            // 
            lblTotalPaid.AutoSize = true;
            lblTotalPaid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblTotalPaid.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            lblTotalPaid.Location = new System.Drawing.Point(540, 65);
            lblTotalPaid.Name = "lblTotalPaid";
            lblTotalPaid.Size = new System.Drawing.Size(84, 15);
            lblTotalPaid.TabIndex = 3;
            lblTotalPaid.Text = "Paid: PHP 0.00";
            // 
            // lblBalanceDue
            // 
            lblBalanceDue.AutoSize = true;
            lblBalanceDue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblBalanceDue.ForeColor = System.Drawing.Color.FromArgb(198, 40, 40);
            lblBalanceDue.Location = new System.Drawing.Point(740, 63);
            lblBalanceDue.Name = "lblBalanceDue";
            lblBalanceDue.Size = new System.Drawing.Size(147, 19);
            lblBalanceDue.TabIndex = 4;
            lblBalanceDue.Text = "Balance Due: PHP 0.00";
            // 
            // dgvCharges
            // 
            dgvCharges.AllowUserToAddRows = false;
            dgvCharges.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvCharges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCharges.BackgroundColor = System.Drawing.Color.White;
            dgvCharges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(20, 26, 40);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvCharges.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCharges.ColumnHeadersHeight = 32;
            dgvCharges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colDesc, colAmount, colDate });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvCharges.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCharges.EnableHeadersVisualStyles = false;
            dgvCharges.Location = new System.Drawing.Point(25, 230);
            dgvCharges.MultiSelect = false;
            dgvCharges.Name = "dgvCharges";
            dgvCharges.ReadOnly = true;
            dgvCharges.RowHeadersVisible = false;
            dgvCharges.RowTemplate.Height = 28;
            dgvCharges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCharges.Size = new System.Drawing.Size(570, 340);
            dgvCharges.TabIndex = 4;
            // 
            // colDesc
            // 
            colDesc.FillWeight = 140F;
            colDesc.HeaderText = "Charge Description";
            colDesc.Name = "colDesc";
            colDesc.ReadOnly = true;
            // 
            // colAmount
            // 
            colAmount.FillWeight = 80F;
            colAmount.HeaderText = "Amount (PHP)";
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.FillWeight = 90F;
            colDate.HeaderText = "Date Charged";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // grpAddCharge
            // 
            grpAddCharge.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            grpAddCharge.Controls.Add(lblCDesc);
            grpAddCharge.Controls.Add(txtChargeDesc);
            grpAddCharge.Controls.Add(lblCAmt);
            grpAddCharge.Controls.Add(txtChargeAmount);
            grpAddCharge.Controls.Add(btnAddCharge);
            grpAddCharge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            grpAddCharge.Location = new System.Drawing.Point(615, 230);
            grpAddCharge.Name = "grpAddCharge";
            grpAddCharge.Size = new System.Drawing.Size(445, 160);
            grpAddCharge.TabIndex = 5;
            grpAddCharge.TabStop = false;
            grpAddCharge.Text = "Post Room Usage / Extra Charge";
            // 
            // lblCDesc
            // 
            lblCDesc.AutoSize = true;
            lblCDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblCDesc.Location = new System.Drawing.Point(15, 32);
            lblCDesc.Name = "lblCDesc";
            lblCDesc.Size = new System.Drawing.Size(70, 15);
            lblCDesc.TabIndex = 0;
            lblCDesc.Text = "Description:";
            // 
            // txtChargeDesc
            // 
            txtChargeDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtChargeDesc.Location = new System.Drawing.Point(110, 29);
            txtChargeDesc.Name = "txtChargeDesc";
            txtChargeDesc.Size = new System.Drawing.Size(315, 23);
            txtChargeDesc.TabIndex = 1;
            // 
            // lblCAmt
            // 
            lblCAmt.AutoSize = true;
            lblCAmt.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblCAmt.Location = new System.Drawing.Point(15, 72);
            lblCAmt.Name = "lblCAmt";
            lblCAmt.Size = new System.Drawing.Size(84, 15);
            lblCAmt.TabIndex = 2;
            lblCAmt.Text = "Amount (PHP):";
            // 
            // txtChargeAmount
            // 
            txtChargeAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtChargeAmount.Location = new System.Drawing.Point(110, 69);
            txtChargeAmount.Name = "txtChargeAmount";
            txtChargeAmount.Size = new System.Drawing.Size(150, 23);
            txtChargeAmount.TabIndex = 3;
            // 
            // btnAddCharge
            // 
            btnAddCharge.BackColor = System.Drawing.Color.FromArgb(20, 26, 40);
            btnAddCharge.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddCharge.FlatAppearance.BorderSize = 0;
            btnAddCharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddCharge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnAddCharge.ForeColor = System.Drawing.Color.White;
            btnAddCharge.Location = new System.Drawing.Point(110, 107);
            btnAddCharge.Name = "btnAddCharge";
            btnAddCharge.Size = new System.Drawing.Size(130, 35);
            btnAddCharge.TabIndex = 4;
            btnAddCharge.Text = "Post Charge";
            btnAddCharge.UseVisualStyleBackColor = false;
            btnAddCharge.Click += btnAddCharge_Click;
            // 
            // grpPayment
            // 
            grpPayment.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            grpPayment.Controls.Add(lblPMethod);
            grpPayment.Controls.Add(cmbPaymentMethod);
            grpPayment.Controls.Add(lblPAmt);
            grpPayment.Controls.Add(txtPaymentAmount);
            grpPayment.Controls.Add(btnPay);
            grpPayment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            grpPayment.Location = new System.Drawing.Point(615, 405);
            grpPayment.Name = "grpPayment";
            grpPayment.Size = new System.Drawing.Size(445, 165);
            grpPayment.TabIndex = 6;
            grpPayment.TabStop = false;
            grpPayment.Text = "Process Payment";
            // 
            // lblPMethod
            // 
            lblPMethod.AutoSize = true;
            lblPMethod.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblPMethod.Location = new System.Drawing.Point(15, 32);
            lblPMethod.Name = "lblPMethod";
            lblPMethod.Size = new System.Drawing.Size(52, 15);
            lblPMethod.TabIndex = 0;
            lblPMethod.Text = "Method:";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9F);
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "Credit Card", "GCash" });
            cmbPaymentMethod.Location = new System.Drawing.Point(110, 29);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new System.Drawing.Size(200, 23);
            cmbPaymentMethod.TabIndex = 1;
            // 
            // lblPAmt
            // 
            lblPAmt.AutoSize = true;
            lblPAmt.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblPAmt.Location = new System.Drawing.Point(15, 72);
            lblPAmt.Name = "lblPAmt";
            lblPAmt.Size = new System.Drawing.Size(84, 15);
            lblPAmt.TabIndex = 2;
            lblPAmt.Text = "Amount (PHP):";
            // 
            // txtPaymentAmount
            // 
            txtPaymentAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtPaymentAmount.Location = new System.Drawing.Point(110, 69);
            txtPaymentAmount.Name = "txtPaymentAmount";
            txtPaymentAmount.Size = new System.Drawing.Size(150, 23);
            txtPaymentAmount.TabIndex = 3;
            // 
            // btnPay
            // 
            btnPay.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnPay.ForeColor = System.Drawing.Color.White;
            btnPay.Location = new System.Drawing.Point(110, 110);
            btnPay.Name = "btnPay";
            btnPay.Size = new System.Drawing.Size(150, 38);
            btnPay.TabIndex = 4;
            btnPay.Text = "Accept Payment";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClose.BackColor = System.Drawing.Color.White;
            btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnClose.ForeColor = System.Drawing.Color.FromArgb(20, 26, 40);
            btnClose.Location = new System.Drawing.Point(950, 585);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(110, 36);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // BillingForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1100, 650);
            Controls.Add(btnClose);
            Controls.Add(grpPayment);
            Controls.Add(grpAddCharge);
            Controls.Add(dgvCharges);
            Controls.Add(grpSummary);
            Controls.Add(cmbActiveStays);
            Controls.Add(lblSelect);
            Controls.Add(lblTitle);
            Name = "BillingForm";
            Text = "Billing & Payment";
            Load += BillingForm_Load;
            grpSummary.ResumeLayout(false);
            grpSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCharges).EndInit();
            grpAddCharge.ResumeLayout(false);
            grpAddCharge.PerformLayout();
            grpPayment.ResumeLayout(false);
            grpPayment.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox cmbActiveStays;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblGuestInfo;
        private System.Windows.Forms.Label lblRoomRate;
        private System.Windows.Forms.Label lblTotalCharges;
        private System.Windows.Forms.Label lblTotalPaid;
        private System.Windows.Forms.Label lblBalanceDue;
        private System.Windows.Forms.DataGridView dgvCharges;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.GroupBox grpAddCharge;
        private System.Windows.Forms.Label lblCDesc;
        private System.Windows.Forms.TextBox txtChargeDesc;
        private System.Windows.Forms.Label lblCAmt;
        private System.Windows.Forms.TextBox txtChargeAmount;
        private System.Windows.Forms.Button btnAddCharge;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.Label lblPMethod;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label lblPAmt;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnClose;
    }
}