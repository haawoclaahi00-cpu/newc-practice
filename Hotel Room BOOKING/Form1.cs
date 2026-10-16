using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignmenty3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string guestName = txtGuestName.Text.Trim();

            int age, nights, guests;

            lstBookingDetails.Items.Clear();

            if (guestName == "")
            {
                lstBookingDetails.Items.Add("Enter guest name.");
                return;
            }

            if (!int.TryParse(txtGuestAge.Text, out age) ||
                !int.TryParse(txtNights.Text, out nights) ||
                !int.TryParse(txtGuests.Text, out guests))
            {
                lstBookingDetails.Items.Add("Enter valid numbers.");
                return;
            }

            if (age < 18 || age > 90)
            {
                lstBookingDetails.Items.Add("Age must be 18-90.");
                return;
            }

            if (nights < 1 || nights > 30)
            {
                lstBookingDetails.Items.Add("Nights must be 1-30.");
                return;
            }

            if (guests < 1 || guests > 6)
            {
                lstBookingDetails.Items.Add("Guests must be 1-6.");
                return;
            }

            string roomType = "";
            double rate = 0;
            int maxGuests = 0;

            if (rdoStandard.Checked)
            {
                roomType = "Standard";
                rate = 50;
                maxGuests = 2;
            }
            else if (rdoNormal.Checked)
            {
                roomType = "Normal";
                rate = 80;
                maxGuests = 4;
            }
            else if (rdoHight.Checked)
            {
                roomType = "Hight";
                rate = 130;
                maxGuests = 6;
            }
            else
            {
                lstBookingDetails.Items.Add("Select a room type.");
                return;
            }

            if (guests > maxGuests)
            {
                lstBookingDetails.Items.Add("Too many guests for this room.");
                return;
            }

            double total = rate * nights;

            if (nights >= 10)
                total = total * 0.88;
            else if (nights >= 5)
                total = total * 0.95;

            if (chkBreakfast.Checked)
                total = total + (10 * guests * nights);

            if (guests > 4)
                total = total * 1.05;

            if (age >= 60)
                total = total * 0.95;

            lstBookingDetails.Items.Add("BOOKING APPROVED");
            lstBookingDetails.Items.Add("Guest Name: " + guestName);
            lstBookingDetails.Items.Add("Age: " + age);
            lstBookingDetails.Items.Add("Room Type: " + roomType);
            lstBookingDetails.Items.Add("Rate Per Night: $" + rate);
            lstBookingDetails.Items.Add("Nights: " + nights);
            lstBookingDetails.Items.Add("Guests: " + guests);
            lstBookingDetails.Items.Add("Breakfast: " +
                (chkBreakfast.Checked ? "Yes" : "No"));
            lstBookingDetails.Items.Add("Total Cost: $" +
                total.ToString("0.00"));
        



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGuestName.Clear();
            txtGuestAge.Clear();
            txtNights.Clear();
            txtGuests.Clear();

            rdoStandard.Checked = false;
            rdoNormal.Checked = false;
            rdoHight.Checked = false;

            chkBreakfast.Checked = false;

            lstBookingDetails.Items.Clear();

            txtGuestName.Focus();
        }

        

        private void btnClose_Click_1(object sender, EventArgs e)
        {

            this.Close();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
