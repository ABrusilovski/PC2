using System;

namespace My_First_Program
{
    public class Membership
    {
        public double MonthlyRate { get; set; }

        public Membership(double rate)
        {
            MonthlyRate = rate;
        }

        public virtual double CalculateMonthlyFee()
        {
            return MonthlyRate;
        }
    }
}

