namespace WinFormsApp1
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
            TextBox monthTextBox;
            dateOutputLabel = new Label();
            showDateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            dateOutputLabe = new Label();
            label1 = new Label();
            dayOfWeekTextBox = new TextBox();
            dayOfMonthTextBox = new TextBox();
            yearTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            monthTextBox = new TextBox();
            SuspendLayout();
            // 
            // monthTextBox
            // 
            monthTextBox.Location = new Point(375, 87);
            monthTextBox.Name = "monthTextBox";
            monthTextBox.Size = new Size(150, 31);
            monthTextBox.TabIndex = 21;
            // 
            // dateOutputLabel
            // 
            dateOutputLabel.Dock = DockStyle.Left;
            dateOutputLabel.Location = new Point(0, 0);
            dateOutputLabel.Name = "dateOutputLabel";
            dateOutputLabel.Size = new Size(10, 450);
            dateOutputLabel.TabIndex = 14;
            dateOutputLabel.Click += label2_Click_1;
            // 
            // showDateButton
            // 
            showDateButton.Location = new Point(168, 328);
            showDateButton.Name = "showDateButton";
            showDateButton.Size = new Size(124, 53);
            showDateButton.TabIndex = 15;
            showDateButton.Text = "show date";
            showDateButton.UseVisualStyleBackColor = true;
            showDateButton.Click += button1_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(344, 331);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(127, 50);
            clearButton.TabIndex = 16;
            clearButton.Text = "clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(519, 331);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(126, 50);
            exitButton.TabIndex = 17;
            exitButton.Text = "End";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += button3_Click;
            // 
            // dateOutputLabe
            // 
            dateOutputLabe.BorderStyle = BorderStyle.FixedSingle;
            dateOutputLabe.Location = new Point(130, 262);
            dateOutputLabe.Name = "dateOutputLabe";
            dateOutputLabe.Size = new Size(480, 44);
            dateOutputLabe.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 49);
            label1.Name = "label1";
            label1.Size = new Size(217, 25);
            label1.TabIndex = 19;
            label1.Text = "Enter the day of the week:";
            label1.Click += label1_Click_1;
            // 
            // dayOfWeekTextBox
            // 
            dayOfWeekTextBox.Location = new Point(375, 50);
            dayOfWeekTextBox.Name = "dayOfWeekTextBox";
            dayOfWeekTextBox.Size = new Size(150, 31);
            dayOfWeekTextBox.TabIndex = 20;
            dayOfWeekTextBox.TextChanged += dayOfWeekTextBox_TextChanged;
            // 
            // dayOfMonthTextBox
            // 
            dayOfMonthTextBox.Location = new Point(375, 131);
            dayOfMonthTextBox.Name = "dayOfMonthTextBox";
            dayOfMonthTextBox.Size = new Size(150, 31);
            dayOfMonthTextBox.TabIndex = 22;
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(242, 172);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(150, 31);
            yearTextBox.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 87);
            label2.Name = "label2";
            label2.Size = new Size(245, 25);
            label2.TabIndex = 24;
            label2.Text = "Enter the name of the month:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 128);
            label3.Name = "label3";
            label3.Size = new Size(298, 25);
            label3.TabIndex = 25;
            label3.Text = "Enter the numeric day of the month:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 172);
            label4.Name = "label4";
            label4.Size = new Size(124, 25);
            label4.TabIndex = 26;
            label4.Text = "Enter the year:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(yearTextBox);
            Controls.Add(dayOfMonthTextBox);
            Controls.Add(monthTextBox);
            Controls.Add(dayOfWeekTextBox);
            Controls.Add(label1);
            Controls.Add(dateOutputLabe);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(showDateButton);
            Controls.Add(dateOutputLabel);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label dateOutputLabel;
        private Button showDateButton;
        private Button clearButton;
        private Button exitButton;
        private Label dateOutputLabe;
        private Label label1;
        private TextBox dayOfWeekTextBox;
        private TextBox monthTextBox;
        private TextBox dayOfMonthTextBox;
        private TextBox yearTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
