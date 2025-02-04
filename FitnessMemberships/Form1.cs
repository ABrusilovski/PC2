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
            if (int.TryParse(monthsTextBox.Text, out int months) || months <=0)
            {
                MessageBox.Show("Please enter a valid number of months.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                monthsTextBox.Clear();
                return;
            }
            double monthlyFee;

            if (adultRadioButton.Checked) { monthlyFee = ADULT_RATE; }
            else if (childRadioButton.Checked) { monthlyFee = CHILD_RATE; }
            else if (studentRadioButton.Checked) { monthlyFee = STUDENT_RATE; }
            else { monthlyFee = SENIOR_RATE; }

            if (yogaCheckBox.Checked) { monthlyFee += YOGA_FEE; }
            if (karateCheckBox.Checked) { monthlyFee += KARATE_FEE; }
            if (trainerCheckBox.Checked) { monthlyFee += TRAINER_FEE; }

            double totalFee = monthlyFee * months;

            monthlyFeeDisplay.Text = monthlyFee.ToString("c");
            totalFeeDisplay.Text = totalFee.ToString("c");
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
