using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//TODO need to fix namespace problem
namespace My_First_Program
{

    //---MEMBERSHIPS
    public abstract class Membership
    {
        public double BaseRate { get; protected set; }

        public virtual double GetBaseMembershipFee()
        {
            return BaseRate;
        }
    }

    // abstract class for memberships
    public class AdultMembership : Membership
    {
        public AdultMembership()
        {
            BaseRate = 25.0;
        }
    }

    public class ChildMembership : Membership
    {
        public ChildMembership()
        {
            BaseRate = 10.0;
        }
    }

    public class StudentMembership : Membership
    {
        public StudentMembership()
        {
            BaseRate = 15.0;
        }
    }

    public class SeniorMembership : Membership
    {
        public SeniorMembership()
        {
            BaseRate = 12.5;
        }
    }
    
    
    //----OPTIONS
    //abstact class for AdditionalOption
    public abstract class AdditionalOption
    {
        public abstract double GetFee();
    }

    // Concrete classes for each option
    public class Yoga : AdditionalOption
    {
        public override double GetFee()
        {
            return 20.0; // Yoga fee
        }
    }

    public class Karate : AdditionalOption
    {
        public override double GetFee()
        {
            return 30.0; // Karate fee
        }
    }

    public class Trainer : AdditionalOption
    {
        public override double GetFee()
        {
            return 25.0; // Trainer fee
        }
    }


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

            Membership membership = GetMembershipType();
            double baseFee = membership.GetBaseMembershipFee();
            double additionalFee = GetAdditionalOptionsFee();

            double monthlyFee = baseFee + additionalFee;
            double totalFee = monthlyFee * months;

            monthlyFeeDisplay.Text = monthlyFee.ToString("c");
            totalFeeDisplay.Text = totalFee.ToString("c");
        }

        // Get the type of membership selected
        private Membership GetMembershipType()
        {
            if (adultRadioButton.Checked) return new AdultMembership();
            if (childRadioButton.Checked) return new ChildMembership();
            if (studentRadioButton.Checked) return new StudentMembership();
            return new SeniorMembership(); // Default to Senior Membership
        }

        // Get the total additional fee for options selected
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