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
    public partial class Form1 : Form
    {
        private readonly double ADULT_RATE = 25.0;
        private readonly double CHILD_RATE = 10.0;
        private readonly double STUDENT_RATE = 15.0;
        private readonly double SENIOR_RATE = 12.5;
        private readonly double YOGA_FEE = 20.0;
        private readonly double KARATE_FEE = 30.0;
        private readonly double TRAINER_FEE = 25.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //months validation
            //ideally minimum of 1 month and yearly renewal
            if (!int.TryParse(monthsTextBox.Text, out int months) || months < 1 || months >12)
            {
                monthsTextBox.Text = "";
                MessageBox.Show("Invalid entry of membership length. \nPlease enter a value between 1 and 12.");
                return; // stop execution if input is invalid

            }
            //test
            double monthlyFee = GetBaseMembershipFee();
            monthlyFee += GetAdditionalOptionsFee();


            double totalFee = monthlyFee * months;

            monthlyFeeDisplay.Text = monthlyFee.ToString("c");
            totalFeeDisplay.Text = totalFee.ToString("c");
        }
        //helper method to get membership fee
        private double GetBaseMembershipFee()
        {
            if (adultRadioButton.Checked) return ADULT_RATE;
            if (childRadioButton.Checked) return CHILD_RATE;
            if (studentRadioButton.Checked) return STUDENT_RATE;
            return SENIOR_RATE; // Default to Senior Rate
        }

        //helper method to calculate additional options fee
        private double GetAdditionalOptionsFee() {
            double additionalFee = 0;
            if (yogaCheckBox.Checked) additionalFee += YOGA_FEE;
            if (karateCheckBox.Checked) additionalFee += KARATE_FEE;
            if (trainerCheckBox.Checked) additionalFee += TRAINER_FEE;
            return additionalFee;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            yogaCheckBox.Checked = false;
            karateCheckBox.Checked = false;
            trainerCheckBox.Checked = false;

            monthsTextBox.Text = "";

            monthlyFeeDisplay.Text = "";
            totalFeeDisplay.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}