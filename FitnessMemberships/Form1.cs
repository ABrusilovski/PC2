using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_First_Program
{

    //FORM
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        { //Placeholders
            first_name.Text = "Enter First Name";
            first_name.ForeColor = Color.Gray;

            last_name.Text = "Enter Last Name";
            last_name.ForeColor = Color.Gray;

        }
        // Handling the TextBox "Enter" event (focus)
        private void first_name_Enter(object sender, EventArgs e)
        {
            // If the textbox contains the placeholder text, clear it when clicked
            if (first_name.Text == "Enter First Name")
            {
                first_name.Text = "";
                first_name.ForeColor = Color.Black;
            }
        }

        // Handling the TextBox "Leave" event (losing focus)
        private void first_name_Leave(object sender, EventArgs e)
        {
            // If the textbox is empty, restore the placeholder text
            if (string.IsNullOrWhiteSpace(first_name.Text))
            {
                first_name.Text = "Enter First Name";
                first_name.ForeColor = Color.Gray;
            }
        }

        // Repeat the same for last_name
        private void last_name_Enter(object sender, EventArgs e)
        {
            if (last_name.Text == "Enter Last Name")
            {
                last_name.Text = "";
                last_name.ForeColor = Color.Black;
            }
        }

        private void last_name_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(last_name.Text))
            {
                last_name.Text = "Enter Last Name";
                last_name.ForeColor = Color.Gray;
            }
        }

        // Button click event for calculating fees
        private void calcButton_Click(object sender, EventArgs e)
        {
            //months validation
            if (!int.TryParse(monthsTextBox.Text, out int months) || months < 1 || months > 12)
            {
                monthsTextBox.Text = "";
                MessageBox.Show("Invalid entry of membership length. \nPlease enter a value between 1 and 12.");
                return; // stop execution if input is invalid
            }

            Membership membership = GetMembershipType(); //gets the membershiptype in a helper method 
            double baseFee = membership.GetBaseMembershipFee();
            double additionalFee = GetAdditionalOptionsFee();

            double monthlyFee = baseFee + additionalFee;
            double totalFee = monthlyFee * months;

            monthlyFeeDisplay.Text = monthlyFee.ToString("c");
            totalFeeDisplay.Text = totalFee.ToString("c");
        }

        // helper method to get the type of membership selected
        private Membership GetMembershipType()
        {
            if (seniorRadioButton.Checked) return new SeniorMembership();
            if (childRadioButton.Checked) return new ChildMembership();
            if (studentRadioButton.Checked) return new StudentMembership();
            return new AdultMembership(); // Default to Adult Membership

        }
        //returns string value of the options choosen
        private string GetSelectedOptions()
        {
            string options = "";
            if (yogaCheckBox.Checked) options += "Yoga";
            if (karateCheckBox.Checked) options += " Karate";
            if (trainerCheckBox.Checked) options += " Trainer";

            return options;
        }



        //helper method to get the total additional fee for options selected
        private double GetAdditionalOptionsFee()
        {
            double additionalFee = 0;

            if (yogaCheckBox.Checked) additionalFee += (new Yoga().GetFee());
            if (karateCheckBox.Checked) additionalFee += (new Karate().GetFee());
            if (trainerCheckBox.Checked) additionalFee += (new Trainer().GetFee());

            return additionalFee;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears all chosen options and checked box, returns to default
            yogaCheckBox.Checked = false;
            karateCheckBox.Checked = false;
            trainerCheckBox.Checked = false;
            monthsTextBox.Text = "";
            monthlyFeeDisplay.Text = "";
            totalFeeDisplay.Text = "";
            adultRadioButton.Checked = true;

            //for client info
            first_name.Text = "Enter First Name";
            first_name.ForeColor = Color.Gray;

            last_name.Text = "Enter Last Name";
            last_name.ForeColor = Color.Gray;
        }

        private void register_Click(object sender, EventArgs e)
        {

            // Check if there are values in the fee display textboxes
            if (monthlyFeeDisplay.Text == "" || totalFeeDisplay.Text == "")
            {
                MessageBox.Show("Please calculate fees first.");
                return;
            }
            // Validate Name Inputs
            if (first_name.Text == "Enter First Name" || string.IsNullOrWhiteSpace(first_name.Text) ||
                last_name.Text == "Enter Last Name" || string.IsNullOrWhiteSpace(last_name.Text))
            {
                MessageBox.Show("Please enter a valid first and last name.");
                return;
            }
            // Gather client information
            string fullname = first_name.Text.Trim() + " " + last_name.Text.Trim();
            string membershipType = GetMembershipType().ToString(); // returns ToString() value of each memberships
            string options = GetSelectedOptions(); //string name of the options
            //totalFee
            decimal totalFee = decimal.Parse(totalFeeDisplay.Text, NumberStyles.Currency);
            string formattedTotalFee = totalFee.ToString("C");

            //monthlyFee
            decimal monthlyFee = decimal.Parse(monthlyFeeDisplay.Text, NumberStyles.Currency);
            string fortmatedMonthly = monthlyFee.ToString("C");


            string months = monthsTextBox.Text; 

            string filePath = "memberships.csv";
            string csvLine = $"{fullname}, {membershipType}, {options}, {months}, ${monthlyFee}, ${totalFee}";

            try
            { 
                using (StreamWriter txt = new StreamWriter(filePath, true))
                {
                    // If file is newly created, add headers
                    if (new FileInfo(filePath).Length == 0)
                    {
                        txt.WriteLine("Client ,Membership Type, Options , Months, Monthly Fee, Total Fee");
                    }
                    // Write the new registration entry
                    txt.WriteLine($"{csvLine}");
                }

                MessageBox.Show("Registration saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving registration: " + ex.Message);
            }
        }

        private void view_Click(object sender, EventArgs e)
        {
            // Create an instance of ViewForm
            ViewForm viewForm = new ViewForm();

            // Path to the CSV file
            string filePath = "memberships.csv";

            // Load the client data into the ViewForm's RichTextBox
            viewForm.LoadClientData(filePath);

            // Show the ViewForm as a dialog
            viewForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}