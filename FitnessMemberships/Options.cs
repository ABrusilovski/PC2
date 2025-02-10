using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Program
{
    //base class for Options
    public abstract class Options
    {
        public abstract double GetFee();
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }

    // Concrete classes for each option
    public class Yoga : Options
    {
        public override double GetFee()
        {
            return 20.0;
        }
        public override string ToString()
        {
            return "Yoga";
        }
    }

    public class Karate : Options
    {
        public override double GetFee()
        {
            return 30.0;
        }
        public override string ToString()
        {
            return "Karate";
        }

    }

    public class Trainer : Options
    {
        public override double GetFee()
        {
            return 25.0;
        }
        public override string ToString()
        {
            return "Personal Trainer";
        }
    }
}
