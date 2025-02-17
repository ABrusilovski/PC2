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
    // <summary>
    // Main form for the Membership Fee Calculator application.
    // Allows users to enter personal information, select a membership type,
    // choose additional options, calculate fees, and register the membership.
    // </summary>
    public partial class Form1 : Form
    {
        private string filePath = "memberships.csv"; // Hardcoded file path for saving registration data

        // <summary>
        // Initializes the form components.
        // </summary>
        public Form1()
        {
            InitializeComponent();
        }

        // <summary>
        // Handles the form load event to set up placeholder text.
        // </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            first_name.Text = "Enter First Name";
            first_name.ForeColor = Color.Gray;

            last_name.Text = "Enter Last Name";
            last_name.ForeColor = Color.Gray;
        }

        // <summary>
        // Handles the event when the first name textbox gains focus.
        // Clears placeholder text if present.
        // </summary>
        private void first_name_Enter(object sender, EventArgs e)
        {
            if (first_name.Text == "Enter First Name")
            {
                first_name.Text = "";
                first_name.ForeColor = Color.Black;
            }
        }

        // <summary>
        // Handles the event when the first name textbox loses focus.
        // Restores placeholder text if left empty.
        // </summary>
        private void first_name_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(first_name.Text))
            {
                first_name.Text = "Enter First Name";
                first_name.ForeColor = Color.Gray;
            }
        }

        // <summary>
        // Handles the event when the last name textbox gains focus.
        // Clears placeholder text if present.
        // </summary>
        private void last_name_Enter(object sender, EventArgs e)
        {
            if (last_name.Text == "Enter Last Name")
            {
                last_name.Text = "";
                last_name.ForeColor = Color.Black;
            }
        }

        // <summary>
        // Handles the event when the last name textbox loses focus.
        // Restores placeholder text if left empty.
        // </summary>
        private void last_name_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(last_name.Text))
            {
                last_name.Text = "Enter Last Name";
                last_name.ForeColor = Color.Gray;
            }
        }

        // <summary>
        // Handles the button click event to calculate the membership fees.
        // </summary>
        private void calcButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(monthsTextBox.Text, out int months) || months < 1)
            {
                monthsTextBox.Text = "";
                MessageBox.Show("Invalid entry of membership length. \nPlease enter a value greater than 1.");
                return;
            }

            Membership membership = GetMembershipType();
            double baseFee = membership.GetBaseMembershipFee();
            double additionalFee = GetAdditionalOptionsFee();

            double monthlyFee = baseFee + additionalFee;
            double totalFee = monthlyFee * months;

            monthlyFeeDisplay.Text = monthlyFee.ToString("c");
            totalFeeDisplay.Text = totalFee.ToString("c");
        }

        // <summary>
        // Retrieves the selected membership type.
        // </summary>
        private Membership GetMembershipType()
        {
            if (seniorRadioButton.Checked) return new SeniorMembership();
            if (childRadioButton.Checked) return new ChildMembership();
            if (studentRadioButton.Checked) return new StudentMembership();
            return new AdultMembership();
        }

        // <summary>
        // Returns a string representing the additional options chosen.
        // </summary>
        private string GetSelectedOptions()
        {
            string options = "";
            if (yogaCheckBox.Checked) options += "Yoga";
            if (karateCheckBox.Checked) options += " Karate";
            if (trainerCheckBox.Checked) options += " Trainer";
            return options;
        }

        // <summary>
        // Calculates the total additional fee for selected options.
        // </summary>
        private double GetAdditionalOptionsFee()
        {
            double additionalFee = 0;
            if (yogaCheckBox.Checked) additionalFee += (new Yoga().GetFee());
            if (karateCheckBox.Checked) additionalFee += (new Karate().GetFee());
            if (trainerCheckBox.Checked) additionalFee += (new Trainer().GetFee());
            return additionalFee;
        }

        // <summary>
        // Clears all input fields and resets selections.
        // </summary>
        private void clearButton_Click(object sender, EventArgs e)
        {
            yogaCheckBox.Checked = false;
            karateCheckBox.Checked = false;
            trainerCheckBox.Checked = false;
            monthsTextBox.Text = "";
            monthlyFeeDisplay.Text = "";
            totalFeeDisplay.Text = "";
            adultRadioButton.Checked = true;
            first_name.Text = "Enter First Name";
            first_name.ForeColor = Color.Gray;
            last_name.Text = "Enter Last Name";
            last_name.ForeColor = Color.Gray;
        }

        // <summary>
        // Registers the membership and saves the details to a CSV file.
        // </summary>
        private void register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(monthlyFeeDisplay.Text) || string.IsNullOrWhiteSpace(totalFeeDisplay.Text))
            {
                MessageBox.Show("Please calculate fees first.");
                return;
            }

            if (first_name.Text == "Enter First Name" || last_name.Text == "Enter Last Name" ||
                string.IsNullOrWhiteSpace(first_name.Text) || string.IsNullOrWhiteSpace(last_name.Text))
            {
                MessageBox.Show("Please enter a valid first and last name.");
                return;
            }

            string fullname = first_name.Text.Trim() + " " + last_name.Text.Trim();
            string membershipType = GetMembershipType().ToString();
            string options = GetSelectedOptions();
            decimal totalFee = decimal.Parse(totalFeeDisplay.Text, NumberStyles.Currency);
            decimal monthlyFee = decimal.Parse(monthlyFeeDisplay.Text, NumberStyles.Currency);
            string csvLine = $"{fullname}, {membershipType}, {options}, {monthsTextBox.Text}, ${monthlyFee}, ${totalFee}";

            try
            {
                using (StreamWriter txt = new StreamWriter(filePath, true))
                {
                    if (new FileInfo(filePath).Length == 0)
                        txt.WriteLine("Client, Membership Type, Options, Months, Monthly Fee, Total Fee");
                    txt.WriteLine(csvLine);
                }
                MessageBox.Show("Registration saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving registration: " + ex.Message);
            }
        }

        // <summary>
        // Opens the ViewForm to display registered client data.
        // </summary>
        private void view_Click(object sender, EventArgs e)
        {
            ViewForm viewForm = new ViewForm();
            viewForm.LoadClientData(filePath);
            viewForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
