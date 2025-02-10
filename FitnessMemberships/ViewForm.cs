using System;
using System.IO;
using System.Windows.Forms;

namespace My_First_Program
{
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }
        public void LoadClientData(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    rtbContent.Clear(); // Clear previous content
                    foreach (string line in lines)
                    {
                        rtbContent.AppendText(line + Environment.NewLine);
                    }
                }
                else
                {
                    MessageBox.Show("File not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading the file: " + ex.Message);
            }
        }
    }
}
