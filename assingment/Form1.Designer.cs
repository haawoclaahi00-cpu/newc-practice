namespace assenmenty
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dayOfWeekTextBox = new TextBox();
            dayOfMonthTextBox = new TextBox();
            monthTextBox = new TextBox();
            yearTextBox = new TextBox();
            dateOutputLabel = new Label();
            showDateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 0;
            label1.Text = "enterdayofweeks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(211, 25);
            label2.TabIndex = 1;
            label2.Text = "Enter the name of month";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(294, 25);
            label3.TabIndex = 2;
            label3.Text = "Enter the numeric day of the month";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 151);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 3;
            label4.Text = "Enter the year";
            // 
            // dayOfWeekTextBox
            // 
            dayOfWeekTextBox.Location = new Point(318, 34);
            dayOfWeekTextBox.Name = "dayOfWeekTextBox";
            dayOfWeekTextBox.Size = new Size(189, 31);
            dayOfWeekTextBox.TabIndex = 4;
            // 
            // dayOfMonthTextBox
            // 
            dayOfMonthTextBox.Location = new Point(318, 115);
            dayOfMonthTextBox.Name = "dayOfMonthTextBox";
            dayOfMonthTextBox.Size = new Size(189, 31);
            dayOfMonthTextBox.TabIndex = 5;
            // 
            // monthTextBox
            // 
            monthTextBox.Location = new Point(308, 73);
            monthTextBox.Name = "monthTextBox";
            monthTextBox.Size = new Size(199, 31);
            monthTextBox.TabIndex = 6;
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(318, 163);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(189, 31);
            yearTextBox.TabIndex = 7;
            // 
            // dateOutputLabel
            // 
            dateOutputLabel.BorderStyle = BorderStyle.FixedSingle;
            dateOutputLabel.Location = new Point(120, 242);
            dateOutputLabel.Name = "dateOutputLabel";
            dateOutputLabel.Size = new Size(582, 45);
            dateOutputLabel.TabIndex = 8;
            // 
            // showDateButton
            // 
            showDateButton.Location = new Point(166, 313);
            showDateButton.Name = "showDateButton";
            showDateButton.Size = new Size(112, 34);
            showDateButton.TabIndex = 9;
            showDateButton.Text = "show Date";
            showDateButton.UseVisualStyleBackColor = true;
            showDateButton.Click += showDateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(346, 313);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(112, 34);
            clearButton.TabIndex = 10;
            clearButton.Text = "clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(550, 313);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 34);
            exitButton.TabIndex = 11;
            exitButton.Text = "End";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(showDateButton);
            Controls.Add(dateOutputLabel);
            Controls.Add(yearTextBox);
            Controls.Add(monthTextBox);
            Controls.Add(dayOfMonthTextBox);
            Controls.Add(dayOfWeekTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox dayOfWeekTextBox;
        private TextBox dayOfMonthTextBox;
        private TextBox monthTextBox;
        private TextBox yearTextBox;
        private Label dateOutputLabel;
        private Button showDateButton;
        private Button clearButton;
        private Button exitButton;
    }
}
