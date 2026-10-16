
    using System;
using System.Windows.Forms;

namespace Airline_Ticket_Booking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string passengerName = txtPassengerName.Text.Trim();

            int passengerAge;
            int numberOfTickets;
            double baggageWeight;

            bool bookingApproved = true;

            lstBookingDetails.Items.Clear();

            if (passengerName == "")
            {
                MessageBox.Show("Please enter passenger name.");
                return;
            }

            if (!int.TryParse(txtPassengerAge.Text, out passengerAge))
            {
                MessageBox.Show("Enter a valid passenger age.");
                return;
            }

            if (!int.TryParse(txtNumberOfTickets.Text, out numberOfTickets))
            {
                MessageBox.Show("Enter a valid number of tickets.");
                return;
            }

            if (!double.TryParse(txtBaggageWeight.Text, out baggageWeight))
            {
                MessageBox.Show("Enter a valid baggage weight.");
                return;
            }

            if (passengerAge < 1 || passengerAge > 100)
            {
                MessageBox.Show("Age must be between 1 and 100.");
                return;
            }

            if (numberOfTickets < 1 || numberOfTickets > 5)
            {
                MessageBox.Show("Tickets must be between 1 and 5.");
                return;
            }

            if (baggageWeight < 0 ||
                baggageWeight > 50 * numberOfTickets)
            {
                MessageBox.Show(
                    "Baggage cannot exceed 50 kg per passenger.");
                return;
            }

            string selectedClass;
            double ticketPrice;

            if (rdoFirstClass.Checked)
            {
                selectedClass = "First Class";
                ticketPrice = 500;
            }
            else if (rdoNormalClass.Checked)
            {
                selectedClass = "Normal Class";
                ticketPrice = 200;
            }
            else if (rdoBusinessClass.Checked)
            {
                selectedClass = "Business Class";
                ticketPrice = 350;
            }
            else
            {
                MessageBox.Show("Please select a travel class.");
                return;
            }

            if (passengerAge < 12 && rdoFirstClass.Checked)
            {
                bookingApproved = false;

                lstBookingDetails.Items.Add("BOOKING REJECTED");
                lstBookingDetails.Items.Add(
                    "Passengers below 12 cannot book First Class.");
                lstBookingDetails.Items.Add(
                    "Booking Approved: " + bookingApproved);

                return;
            }

            double basicTicketCost = ticketPrice * numberOfTickets;
            double discount = 0;

            if (numberOfTickets >= 3 && numberOfTickets <= 4)
            {
                discount += basicTicketCost * 0.05;
            }
            else if (numberOfTickets == 5)
            {
                discount += basicTicketCost * 0.10;
            }

            if (passengerAge < 12)
            {
                discount += basicTicketCost * 0.20;
            }
            else if (passengerAge >= 60)
            {
                discount += basicTicketCost * 0.10;
            }

            double insuranceFee = 0;

            if (chkTravelInsurance.Checked)
            {
                insuranceFee = 25 * numberOfTickets;
            }

            double freeBaggage = 20 * numberOfTickets;
            double baggageFee = 0;

            if (baggageWeight > freeBaggage)
            {
                baggageFee = (baggageWeight - freeBaggage) * 10;
            }

            double finalTotal = basicTicketCost - discount
                                + insuranceFee + baggageFee;

            lstBookingDetails.Items.Add("BOOKING APPROVED");
            lstBookingDetails.Items.Add(
                "Passenger Name: " + passengerName);
            lstBookingDetails.Items.Add(
                "Passenger Age: " + passengerAge);
            lstBookingDetails.Items.Add(
                "Travel Class: " + selectedClass);
            lstBookingDetails.Items.Add(
                "Number of Tickets: " + numberOfTickets);
            lstBookingDetails.Items.Add(
                "Baggage Weight: " + baggageWeight + " kg");
            lstBookingDetails.Items.Add(
                "Ticket Price: $" + ticketPrice.ToString("0.00"));
            lstBookingDetails.Items.Add(
                "Basic Ticket Cost: $" + basicTicketCost.ToString("0.00"));
            lstBookingDetails.Items.Add(
                "Discount: $" + discount.ToString("0.00"));
            lstBookingDetails.Items.Add(
                "Insurance Fee: $" + insuranceFee.ToString("0.00"));
            lstBookingDetails.Items.Add(
                "Baggage Fee: $" + baggageFee.ToString("0.00"));
            lstBookingDetails.Items.Add(
                "Final Total: $" + finalTotal.ToString("0.00"));
            lstBookingDetails.Items.Add(
                "Booking Approved: " + bookingApproved);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassengerName.Clear();
            txtPassengerAge.Clear();
            txtNumberOfTickets.Clear();
            txtBaggageWeight.Clear();

            rdoFirstClass.Checked = false;
            rdoNormalClass.Checked = false;
            rdoBusinessClass.Checked = false;

            chkTravelInsurance.Checked = false;

            lstBookingDetails.Items.Clear();

            txtPassengerName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


