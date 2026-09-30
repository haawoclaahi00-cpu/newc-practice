namespace Home_Assignment
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
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtPrevious = new System.Windows.Forms.TextBox();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtUsage = new System.Windows.Forms.TextBox();
            this.lblPrevious = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblUsage = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpBill = new System.Windows.Forms.GroupBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.grpBill.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(163, -2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(410, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Electricity Bill Calculator";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(45, 53);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(271, 23);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Enter Customer Name          :";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(353, 66);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(311, 26);
            this.txtCustomer.TabIndex = 6;
            // 
            // txtPrevious
            // 
            this.txtPrevious.Location = new System.Drawing.Point(353, 104);
            this.txtPrevious.Name = "txtPrevious";
            this.txtPrevious.Size = new System.Drawing.Size(311, 26);
            this.txtPrevious.TabIndex = 7;
            // 
            // txtCurrent
            // 
            this.txtCurrent.Location = new System.Drawing.Point(353, 136);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(311, 26);
            this.txtCurrent.TabIndex = 8;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(353, 177);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(311, 26);
            this.txtUnitPrice.TabIndex = 9;
            // 
            // txtUsage
            // 
            this.txtUsage.Location = new System.Drawing.Point(440, 22);
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.Size = new System.Drawing.Size(185, 26);
            this.txtUsage.TabIndex = 10;
            // 
            // lblPrevious
            // 
            this.lblPrevious.AutoSize = true;
            this.lblPrevious.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevious.Location = new System.Drawing.Point(45, 91);
            this.lblPrevious.Name = "lblPrevious";
            this.lblPrevious.Size = new System.Drawing.Size(270, 23);
            this.lblPrevious.TabIndex = 11;
            this.lblPrevious.Text = "Enter Previous Reading        :";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.Location = new System.Drawing.Point(45, 132);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(272, 23);
            this.lblCurrent.TabIndex = 12;
            this.lblCurrent.Text = "Enter Current Reading          :";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(45, 176);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(269, 23);
            this.lblUnitPrice.TabIndex = 13;
            this.lblUnitPrice.Text = "Enter Price Per Unit ($)        :";
            // 
            // lblUsage
            // 
            this.lblUsage.AutoSize = true;
            this.lblUsage.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsage.Location = new System.Drawing.Point(41, 22);
            this.lblUsage.Name = "lblUsage";
            this.lblUsage.Size = new System.Drawing.Size(364, 23);
            this.lblUsage.TabIndex = 14;
            this.lblUsage.Text = "Electricity Usage (Units)                       :";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Black;
            this.btnCalculate.Location = new System.Drawing.Point(270, 218);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(173, 49);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate Bill";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grpBill
            // 
            this.grpBill.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpBill.Controls.Add(this.txtTax);
            this.grpBill.Controls.Add(this.txtTotal);
            this.grpBill.Controls.Add(this.lblTotal);
            this.grpBill.Controls.Add(this.lblTax);
            this.grpBill.Controls.Add(this.lblUsage);
            this.grpBill.Controls.Add(this.txtUsage);
            this.grpBill.Location = new System.Drawing.Point(49, 282);
            this.grpBill.Name = "grpBill";
            this.grpBill.Size = new System.Drawing.Size(715, 141);
            this.grpBill.TabIndex = 17;
            this.grpBill.TabStop = false;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(41, 60);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(364, 23);
            this.lblTax.TabIndex = 15;
            this.lblTax.Text = "Tax Amount (7%)                                 :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(41, 102);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(366, 23);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total Bill (Including $5 Fixed Charge)     :";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(440, 60);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(185, 26);
            this.txtTax.TabIndex = 18;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(440, 102);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(185, 26);
            this.txtTotal.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBill);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblPrevious);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.txtPrevious);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBill.ResumeLayout(false);
            this.grpBill.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtPrevious;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtUsage;
        private System.Windows.Forms.Label lblPrevious;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblUsage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grpBill;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

