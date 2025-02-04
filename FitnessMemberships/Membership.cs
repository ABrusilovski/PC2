using System;

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

}

