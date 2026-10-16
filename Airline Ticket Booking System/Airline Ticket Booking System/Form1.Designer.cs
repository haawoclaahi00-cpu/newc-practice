namespace Airline_Ticket_Booking_System
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblPassengerName = new System.Windows.Forms.Label();
            this.lblPassengerAge = new System.Windows.Forms.Label();
            this.lblTickets = new System.Windows.Forms.Label();
            this.lblBaggage = new System.Windows.Forms.Label();
            this.txtPassengerAge = new System.Windows.Forms.TextBox();
            this.txtNumberOfTickets = new System.Windows.Forms.TextBox();
            this.txtBaggageWeight = new System.Windows.Forms.TextBox();
            this.lblTravelClasslabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoFirstClass = new System.Windows.Forms.RadioButton();
            this.rdoNormalClass = new System.Windows.Forms.RadioButton();
            this.rdoBusinessClass = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.chkTravelInsurance = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstBookingDetails = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1059, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "                                     Airline Ticket Booking System";
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Location = new System.Drawing.Point(301, 60);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(250, 32);
            this.txtPassengerName.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(70, 541);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(115, 41);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblPassengerName
            // 
            this.lblPassengerName.AutoSize = true;
            this.lblPassengerName.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerName.Location = new System.Drawing.Point(64, 65);
            this.lblPassengerName.Name = "lblPassengerName";
            this.lblPassengerName.Size = new System.Drawing.Size(181, 26);
            this.lblPassengerName.TabIndex = 4;
            this.lblPassengerName.Text = "Passenger Name";
            // 
            // lblPassengerAge
            // 
            this.lblPassengerAge.AutoSize = true;
            this.lblPassengerAge.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerAge.Location = new System.Drawing.Point(72, 112);
            this.lblPassengerAge.Name = "lblPassengerAge";
            this.lblPassengerAge.Size = new System.Drawing.Size(160, 26);
            this.lblPassengerAge.TabIndex = 5;
            this.lblPassengerAge.Text = "Passenger Age";
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickets.Location = new System.Drawing.Point(72, 153);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(189, 26);
            this.lblTickets.TabIndex = 6;
            this.lblTickets.Text = "Number of Tickets";
            // 
            // lblBaggage
            // 
            this.lblBaggage.AutoSize = true;
            this.lblBaggage.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaggage.Location = new System.Drawing.Point(49, 199);
            this.lblBaggage.Name = "lblBaggage";
            this.lblBaggage.Size = new System.Drawing.Size(216, 26);
            this.lblBaggage.TabIndex = 8;
            this.lblBaggage.Text = "Baggage Weight (kg)";
            // 
            // txtPassengerAge
            // 
            this.txtPassengerAge.Location = new System.Drawing.Point(301, 106);
            this.txtPassengerAge.Name = "txtPassengerAge";
            this.txtPassengerAge.Size = new System.Drawing.Size(250, 32);
            this.txtPassengerAge.TabIndex = 10;
            // 
            // txtNumberOfTickets
            // 
            this.txtNumberOfTickets.Location = new System.Drawing.Point(301, 147);
            this.txtNumberOfTickets.Name = "txtNumberOfTickets";
            this.txtNumberOfTickets.Size = new System.Drawing.Size(250, 32);
            this.txtNumberOfTickets.TabIndex = 11;
            // 
            // txtBaggageWeight
            // 
            this.txtBaggageWeight.Location = new System.Drawing.Point(301, 193);
            this.txtBaggageWeight.Name = "txtBaggageWeight";
            this.txtBaggageWeight.Size = new System.Drawing.Size(250, 32);
            this.txtBaggageWeight.TabIndex = 12;
            // 
            // lblTravelClasslabel1
            // 
            this.lblTravelClasslabel1.AutoSize = true;
            this.lblTravelClasslabel1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTravelClasslabel1.Location = new System.Drawing.Point(32, 333);
            this.lblTravelClasslabel1.Name = "lblTravelClasslabel1";
            this.lblTravelClasslabel1.Size = new System.Drawing.Size(139, 26);
            this.lblTravelClasslabel1.TabIndex = 14;
            this.lblTravelClasslabel1.Text = "Travel Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(770, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 26);
            this.label2.TabIndex = 15;
            // 
            // rdoFirstClass
            // 
            this.rdoFirstClass.AutoSize = true;
            this.rdoFirstClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFirstClass.Location = new System.Drawing.Point(70, 382);
            this.rdoFirstClass.Name = "rdoFirstClass";
            this.rdoFirstClass.Size = new System.Drawing.Size(129, 29);
            this.rdoFirstClass.TabIndex = 16;
            this.rdoFirstClass.TabStop = true;
            this.rdoFirstClass.Text = "First Class";
            this.rdoFirstClass.UseVisualStyleBackColor = true;
            // 
            // rdoNormalClass
            // 
            this.rdoNormalClass.AutoSize = true;
            this.rdoNormalClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNormalClass.Location = new System.Drawing.Point(235, 382);
            this.rdoNormalClass.Name = "rdoNormalClass";
            this.rdoNormalClass.Size = new System.Drawing.Size(154, 29);
            this.rdoNormalClass.TabIndex = 17;
            this.rdoNormalClass.TabStop = true;
            this.rdoNormalClass.Text = "Normal Class";
            this.rdoNormalClass.UseVisualStyleBackColor = true;
            // 
            // rdoBusinessClass
            // 
            this.rdoBusinessClass.AutoSize = true;
            this.rdoBusinessClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBusinessClass.Location = new System.Drawing.Point(443, 382);
            this.rdoBusinessClass.Name = "rdoBusinessClass";
            this.rdoBusinessClass.Size = new System.Drawing.Size(172, 29);
            this.rdoBusinessClass.TabIndex = 18;
            this.rdoBusinessClass.TabStop = true;
            this.rdoBusinessClass.Text = "Business Class";
            this.rdoBusinessClass.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Additional Options";
            // 
            // chkTravelInsurance
            // 
            this.chkTravelInsurance.AutoSize = true;
            this.chkTravelInsurance.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTravelInsurance.Location = new System.Drawing.Point(60, 483);
            this.chkTravelInsurance.Name = "chkTravelInsurance";
            this.chkTravelInsurance.Size = new System.Drawing.Size(311, 28);
            this.chkTravelInsurance.TabIndex = 21;
            this.chkTravelInsurance.Text = "Add Travel Insurance ($25 Per Ticket)";
            this.chkTravelInsurance.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(274, 541);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 41);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(449, 541);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 41);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtPassengerAge);
            this.groupBox1.Controls.Add(this.txtPassengerName);
            this.groupBox1.Controls.Add(this.txtNumberOfTickets);
            this.groupBox1.Controls.Add(this.txtBaggageWeight);
            this.groupBox1.Controls.Add(this.lblPassengerAge);
            this.groupBox1.Controls.Add(this.lblPassengerName);
            this.groupBox1.Controls.Add(this.lblTickets);
            this.groupBox1.Controls.Add(this.lblBaggage);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 273);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // lstBookingDetails
            // 
            this.lstBookingDetails.FormattingEnabled = true;
            this.lstBookingDetails.ItemHeight = 20;
            this.lstBookingDetails.Location = new System.Drawing.Point(706, 94);
            this.lstBookingDetails.Name = "lstBookingDetails";
            this.lstBookingDetails.Size = new System.Drawing.Size(330, 444);
            this.lstBookingDetails.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 615);
            this.Controls.Add(this.lstBookingDetails);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chkTravelInsurance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoBusinessClass);
            this.Controls.Add(this.rdoNormalClass);
            this.Controls.Add(this.rdoFirstClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTravelClasslabel1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.Button btnCalculate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblPassengerName;
        private System.Windows.Forms.Label lblPassengerAge;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.Label lblBaggage;
        private System.Windows.Forms.TextBox txtPassengerAge;
        private System.Windows.Forms.TextBox txtNumberOfTickets;
        private System.Windows.Forms.TextBox txtBaggageWeight;
        private System.Windows.Forms.Label lblTravelClasslabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoFirstClass;
        private System.Windows.Forms.RadioButton rdoNormalClass;
        private System.Windows.Forms.RadioButton rdoBusinessClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkTravelInsurance;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstBookingDetails;
    }
}

