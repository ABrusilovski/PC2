using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private readonly string name = "Yoga";
        public override double GetFee()
        {
            try
            {
                using (StreamReader inputFile = new StreamReader(File.OpenRead("options fees.csv")))
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
                MessageBox.Show("Failed to get option fee: " + ex.Message);
                return 0;
            }
        }
        public override string ToString()
        {
            return name;
        }
    }

    public class Karate : Options
    {
        private readonly string name = "Karate";
        public override double GetFee()
        {
            try
            {
                using (StreamReader inputFile = new StreamReader(File.OpenRead("options fees.csv")))
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
                MessageBox.Show("Failed to get option fee: " + ex.Message);
                return 0;
            }
        }
        public override string ToString()
        {
            return name;
        }

    }

    public class Trainer : Options
    {
        private readonly string name = "Trainer";
        public override double GetFee()
        {
            try
            {
                using (StreamReader inputFile = new StreamReader(File.OpenRead("options fees.csv")))
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
                MessageBox.Show("Failed to get option fee: " + ex.Message);
                return 0;
            }
        }
        public override string ToString()
        {
            return name;
        }
    }
}
