namespace assignmenty3
{
    partial class Form1
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
            this.lblPersonalInfo = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAdditionalOptions = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.rdoStandard = new System.Windows.Forms.RadioButton();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.rdoHight = new System.Windows.Forms.RadioButton();
            this.txtGuestAge = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.txtGuests = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.chkBreakfast = new System.Windows.Forms.CheckBox();
            this.lblGuestAge = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.lblNights = new System.Windows.Forms.Label();
            this.lblGuests = new System.Windows.Forms.Label();
            this.lblBookingDetails = new System.Windows.Forms.Label();
            this.lstBookingDetails = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblPersonalInfo
            // 
            this.lblPersonalInfo.AutoSize = true;
            this.lblPersonalInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalInfo.Location = new System.Drawing.Point(85, 119);
            this.lblPersonalInfo.Name = "lblPersonalInfo";
            this.lblPersonalInfo.Size = new System.Drawing.Size(231, 27);
            this.lblPersonalInfo.TabIndex = 0;
            this.lblPersonalInfo.Text = "personal information";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(107, 592);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(132, 40);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblAdditionalOptions
            // 
            this.lblAdditionalOptions.AutoSize = true;
            this.lblAdditionalOptions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdditionalOptions.Location = new System.Drawing.Point(96, 472);
            this.lblAdditionalOptions.Name = "lblAdditionalOptions";
            this.lblAdditionalOptions.Size = new System.Drawing.Size(189, 27);
            this.lblAdditionalOptions.TabIndex = 3;
            this.lblAdditionalOptions.Text = "Aditional options";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestName.Location = new System.Drawing.Point(103, 177);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(137, 24);
            this.lblGuestName.TabIndex = 4;
            this.lblGuestName.Text = "Guest name :";
            this.lblGuestName.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(107, 367);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(128, 27);
            this.lblRoomType.TabIndex = 8;
            this.lblRoomType.Text = "Room type";
            // 
            // rdoStandard
            // 
            this.rdoStandard.AutoSize = true;
            this.rdoStandard.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStandard.Location = new System.Drawing.Point(100, 403);
            this.rdoStandard.Name = "rdoStandard";
            this.rdoStandard.Size = new System.Drawing.Size(136, 31);
            this.rdoStandard.TabIndex = 10;
            this.rdoStandard.TabStop = true;
            this.rdoStandard.Text = "Standard";
            this.rdoStandard.UseVisualStyleBackColor = true;
            // 
            // rdoNormal
            // 
            this.rdoNormal.AutoSize = true;
            this.rdoNormal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNormal.Location = new System.Drawing.Point(269, 403);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.Size = new System.Drawing.Size(114, 31);
            this.rdoNormal.TabIndex = 11;
            this.rdoNormal.TabStop = true;
            this.rdoNormal.Text = "Normal";
            this.rdoNormal.UseVisualStyleBackColor = true;
            // 
            // rdoHight
            // 
            this.rdoHight.AutoSize = true;
            this.rdoHight.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoHight.Location = new System.Drawing.Point(465, 403);
            this.rdoHight.Name = "rdoHight";
            this.rdoHight.Size = new System.Drawing.Size(94, 31);
            this.rdoHight.TabIndex = 12;
            this.rdoHight.TabStop = true;
            this.rdoHight.Text = "Hight";
            this.rdoHight.UseVisualStyleBackColor = true;
            // 
            // txtGuestAge
            // 
            this.txtGuestAge.Location = new System.Drawing.Point(314, 210);
            this.txtGuestAge.Name = "txtGuestAge";
            this.txtGuestAge.Size = new System.Drawing.Size(223, 26);
            this.txtGuestAge.TabIndex = 13;
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(314, 259);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(223, 26);
            this.txtNights.TabIndex = 14;
            // 
            // txtGuests
            // 
            this.txtGuests.Location = new System.Drawing.Point(314, 303);
            this.txtGuests.Name = "txtGuests";
            this.txtGuests.Size = new System.Drawing.Size(223, 26);
            this.txtGuests.TabIndex = 15;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(289, 592);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 40);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(445, 592);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 40);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(0, -4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1094, 82);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "                                  Hotel Room Booking System";
            // 
            // chkBreakfast
            // 
            this.chkBreakfast.AutoSize = true;
            this.chkBreakfast.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBreakfast.Location = new System.Drawing.Point(117, 508);
            this.chkBreakfast.Name = "chkBreakfast";
            this.chkBreakfast.Size = new System.Drawing.Size(432, 31);
            this.chkBreakfast.TabIndex = 23;
            this.chkBreakfast.Text = "BreakFast (10 Per Guest Per Nights)";
            this.chkBreakfast.UseVisualStyleBackColor = true;
            // 
            // lblGuestAge
            // 
            this.lblGuestAge.AutoSize = true;
            this.lblGuestAge.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestAge.Location = new System.Drawing.Point(113, 212);
            this.lblGuestAge.Name = "lblGuestAge";
            this.lblGuestAge.Size = new System.Drawing.Size(121, 24);
            this.lblGuestAge.TabIndex = 24;
            this.lblGuestAge.Text = "Guest Age :";
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(314, 169);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(223, 26);
            this.txtGuestName.TabIndex = 25;
            // 
            // lblNights
            // 
            this.lblNights.AutoSize = true;
            this.lblNights.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNights.Location = new System.Drawing.Point(80, 249);
            this.lblNights.Name = "lblNights";
            this.lblNights.Size = new System.Drawing.Size(189, 24);
            this.lblNights.TabIndex = 26;
            this.lblNights.Text = "Number of Nights :";
            // 
            // lblGuests
            // 
            this.lblGuests.AutoSize = true;
            this.lblGuests.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuests.Location = new System.Drawing.Point(80, 293);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(196, 24);
            this.lblGuests.TabIndex = 27;
            this.lblGuests.Text = "Number of Guests :";
            // 
            // lblBookingDetails
            // 
            this.lblBookingDetails.AutoSize = true;
            this.lblBookingDetails.Location = new System.Drawing.Point(790, 126);
            this.lblBookingDetails.Name = "lblBookingDetails";
            this.lblBookingDetails.Size = new System.Drawing.Size(0, 20);
            this.lblBookingDetails.TabIndex = 31;
            // 
            // lstBookingDetails
            // 
            this.lstBookingDetails.FormattingEnabled = true;
            this.lstBookingDetails.ItemHeight = 20;
            this.lstBookingDetails.Location = new System.Drawing.Point(671, 139);
            this.lstBookingDetails.Name = "lstBookingDetails";
            this.lstBookingDetails.Size = new System.Drawing.Size(416, 444);
            this.lstBookingDetails.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1099, 747);
            this.Controls.Add(this.lstBookingDetails);
            this.Controls.Add(this.lblBookingDetails);
            this.Controls.Add(this.lblGuests);
            this.Controls.Add(this.lblNights);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.lblGuestAge);
            this.Controls.Add(this.chkBreakfast);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtGuests);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.txtGuestAge);
            this.Controls.Add(this.rdoHight);
            this.Controls.Add(this.rdoNormal);
            this.Controls.Add(this.rdoStandard);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblGuestName);
            this.Controls.Add(this.lblAdditionalOptions);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblPersonalInfo);
            this.Name = "Form1";
            this.Text = "5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersonalInfo;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAdditionalOptions;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.RadioButton rdoStandard;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.RadioButton rdoHight;
        private System.Windows.Forms.TextBox txtGuestAge;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.TextBox txtGuests;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox chkBreakfast;
        private System.Windows.Forms.Label lblGuestAge;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Label lblNights;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.Label lblBookingDetails;
        private System.Windows.Forms.ListBox lstBookingDetails;
    }
}

