using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Program
{
    // Membership base class
    public abstract class Membership
    {
        //derived classes (changes value per class)
        public abstract double BaseRate { get; }

        // base method returns BaseRate
        public double GetBaseMembershipFee()
        {
            return BaseRate;
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }

    // Specific membership types
    public class AdultMembership : Membership
    {
        public override double BaseRate => 25.0;

        public override string ToString()
        {
            return "Adult";
        }
    }

    public class ChildMembership : Membership
    {
        public override double BaseRate => 10.0;
        public override string ToString()
        {
            return "Child";
        }
    }

    public class StudentMembership : Membership
    {
        public override double BaseRate => 15.0;
        public override string ToString()
        {
            return "Student";
        }
    }

    public class SeniorMembership : Membership
    {
        public override double BaseRate => 12.5;

        public override string ToString()
        {
            return "Senior";
        }
    }
}
