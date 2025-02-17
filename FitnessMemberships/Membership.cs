using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private readonly string name = "Adult";
        public override double BaseRate
        {
            get
            {
                try
                {
                    using (StreamReader inputFile = new StreamReader(File.OpenRead("membership fees.csv")))
                    {
                        string content = inputFile.ReadLine();
                        string[] header = content.Split(',');
                        content = inputFile.ReadLine();
                        string[] values = content.Split(',');
                        int position = Array.IndexOf(header, name);
                        return double.Parse(values[position]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to get membership rate: " + ex.Message);
                    return 0;
                }
            }
        }

        public override string ToString()
        {
            return name;
        }
    }

    public class ChildMembership : Membership
    {
        private readonly string name = "Child";
        public override double BaseRate
        {
            get
            {
                try
                {
                    using (StreamReader inputFile = new StreamReader(File.OpenRead("membership fees.csv")))
                    {
                        string content = inputFile.ReadLine();
                        string[] header = content.Split(',');
                        content = inputFile.ReadLine();
                        string[] values = content.Split(',');
                        int position = Array.IndexOf(header, name);
                        return double.Parse(values[position]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to get membership rate: " + ex.Message);
                    return 0;
                }
            }
        }
        public override string ToString()
        {
            return name;
        }
    }

    public class StudentMembership : Membership
    {
        private readonly string name = "Student";
        public override double BaseRate
        {
            get
            {
                try
                {
                    using (StreamReader inputFile = new StreamReader(File.OpenRead("membership fees.csv")))
                    {
                        string content = inputFile.ReadLine();
                        string[] header = content.Split(',');
                        content = inputFile.ReadLine();
                        string[] values = content.Split(',');
                        int position = Array.IndexOf(header, name);
                        return double.Parse(values[position]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to get membership rate: " + ex.Message);
                    return 0;
                }
            }
        }
        public override string ToString()
        {
            return name;
        }
    }

    public class SeniorMembership : Membership
    {
        private readonly string name = "Senior";
        public override double BaseRate
        {
            get
            {
                try
                {
                    using (StreamReader inputFile = new StreamReader(File.OpenRead("membership fees.csv")))
                    {
                        string content = inputFile.ReadLine();
                        string[] header = content.Split(',');
                        content = inputFile.ReadLine();
                        string[] values = content.Split(',');
                        int position = Array.IndexOf(header, name);
                        return double.Parse(values[position]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to get membership rate: " + ex.Message);
                    return 0;
                }
            }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
