namespace Student_Information
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblname = new Label();
            lblstudentid = new Label();
            lbldepartment = new Label();
            lblsemester = new Label();
            lbloutput = new Label();
            txtname = new TextBox();
            txtstudentid = new TextBox();
            txtdepartment = new TextBox();
            txtsemester = new TextBox();
            btnshowinfo = new Button();
            btnclear = new Button();
            btnexit = new Button();
            SuspendLayout();
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.FlatStyle = FlatStyle.Popup;
            lblname.Font = new Font("Bell MT", 11F);
            lblname.Location = new Point(112, 24);
            lblname.Name = "lblname";
            lblname.Size = new Size(232, 25);
            lblname.TabIndex = 0;
            lblname.Text = "Enter the student name:";
            // 
            // lblstudentid
            // 
            lblstudentid.AutoSize = true;
            lblstudentid.FlatStyle = FlatStyle.Flat;
            lblstudentid.Font = new Font("Bell MT", 11F);
            lblstudentid.Location = new Point(110, 85);
            lblstudentid.Name = "lblstudentid";
            lblstudentid.Size = new Size(209, 25);
            lblstudentid.TabIndex = 1;
            lblstudentid.Text = "Enter the student ID:";
            // 
            // lbldepartment
            // 
            lbldepartment.AutoSize = true;
            lbldepartment.FlatStyle = FlatStyle.Popup;
            lbldepartment.Font = new Font("Bell MT", 11F);
            lbldepartment.Location = new Point(110, 140);
            lbldepartment.Name = "lbldepartment";
            lbldepartment.Size = new Size(214, 25);
            lbldepartment.TabIndex = 2;
            lbldepartment.Text = "Enter the department:";
            lbldepartment.Click += label3_Click;
            // 
            // lblsemester
            // 
            lblsemester.AutoSize = true;
            lblsemester.FlatStyle = FlatStyle.Popup;
            lblsemester.Font = new Font("Bell MT", 11F);
            lblsemester.ImageAlign = ContentAlignment.MiddleRight;
            lblsemester.Location = new Point(112, 202);
            lblsemester.Name = "lblsemester";
            lblsemester.Size = new Size(189, 25);
            lblsemester.TabIndex = 3;
            lblsemester.Text = "Enter the semester:";
            lblsemester.Click += label4_Click;
            // 
            // lbloutput
            // 
            lbloutput.BackColor = SystemColors.ControlLightLight;
            lbloutput.BorderStyle = BorderStyle.FixedSingle;
            lbloutput.Location = new Point(97, 272);
            lbloutput.Name = "lbloutput";
            lbloutput.Size = new Size(580, 58);
            lbloutput.TabIndex = 4;
            // 
            // txtname
            // 
            txtname.Location = new Point(394, 18);
            txtname.Name = "txtname";
            txtname.Size = new Size(249, 31);
            txtname.TabIndex = 5;
            // 
            // txtstudentid
            // 
            txtstudentid.Location = new Point(394, 70);
            txtstudentid.Name = "txtstudentid";
            txtstudentid.Size = new Size(249, 31);
            txtstudentid.TabIndex = 6;
            txtstudentid.TextChanged += txtstudentid_TextChanged;
            // 
            // txtdepartment
            // 
            txtdepartment.Location = new Point(394, 128);
            txtdepartment.Name = "txtdepartment";
            txtdepartment.Size = new Size(249, 31);
            txtdepartment.TabIndex = 7;
            txtdepartment.TextChanged += textBox3_TextChanged;
            // 
            // txtsemester
            // 
            txtsemester.Location = new Point(394, 190);
            txtsemester.Name = "txtsemester";
            txtsemester.Size = new Size(249, 31);
            txtsemester.TabIndex = 8;
            // 
            // btnshowinfo
            // 
            btnshowinfo.BackColor = SystemColors.ControlLight;
            btnshowinfo.Location = new Point(110, 344);
            btnshowinfo.Name = "btnshowinfo";
            btnshowinfo.Size = new Size(174, 43);
            btnshowinfo.TabIndex = 9;
            btnshowinfo.Text = "Show Information\n";
            btnshowinfo.UseVisualStyleBackColor = false;
            btnshowinfo.Click += button1_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = SystemColors.ControlLight;
            btnclear.Location = new Point(293, 344);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(191, 43);
            btnclear.TabIndex = 10;
            btnclear.Text = "Clear\n";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btnexit
            // 
            btnexit.BackColor = SystemColors.ControlLight;
            btnexit.Location = new Point(499, 344);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(178, 43);
            btnexit.TabIndex = 11;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(btnexit);
            Controls.Add(btnclear);
            Controls.Add(btnshowinfo);
            Controls.Add(txtsemester);
            Controls.Add(txtdepartment);
            Controls.Add(txtstudentid);
            Controls.Add(txtname);
            Controls.Add(lbloutput);
            Controls.Add(lblsemester);
            Controls.Add(lbldepartment);
            Controls.Add(lblstudentid);
            Controls.Add(lblname);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblname;
        private Label lblstudentid;
        private Label lbldepartment;
        private Label lblsemester;
        private Label lbloutput;
        private TextBox txtname;
        private TextBox txtstudentid;
        private TextBox txtdepartment;
        private TextBox txtsemester;
        private Button btnshowinfo;
        private Button btnclear;
        private Button btnexit;
    }
}
