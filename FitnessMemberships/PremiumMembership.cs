using System;
using My_First_Program.Membership;
namespace My_First_Program
{
    public class PremiumMembership : Membership
    {
        private readonly double yogaFee;
        private readonly double karateFee;
        private readonly double trainerFee;

        public PremiumMembership(double baseRate, double yoga, double karate, double trainer)
            : base(baseRate)
        {
            yogaFee = yoga;
            karateFee = karate;
            trainerFee = trainer;
        }

        public bool Yoga { get; set; }
        public bool Karate { get; set; }
        public bool Trainer { get; set; }

        public override double CalculateMonthlyFee()
        {
            double total = base.CalculateMonthlyFee();
            if (Yoga) total += yogaFee;
            if (Karate) total += karateFee;
            if (Trainer) total += trainerFee;
            return total;
        }
    }
}

