namespace assenmenty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            

            string DayoftheWeek, Month, Day, Year, FullDate;

            

            DayoftheWeek = dayOfWeekTextBox.Text;

            Month = monthTextBox.Text;

            Day = dayOfMonthTextBox.Text;

            Year = yearTextBox.Text;

            

            FullDate = DayoftheWeek + "," + Month + "," + Day + "," + Year;

            

            dateOutputLabel.Text = FullDate;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            

            dayOfWeekTextBox.Text = " ";

            monthTextBox.Clear();

            dayOfMonthTextBox.Text = string.Empty;

            yearTextBox.Text = string.Empty;

            dateOutputLabel.Text = string.Empty;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
