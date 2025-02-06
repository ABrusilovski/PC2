using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}