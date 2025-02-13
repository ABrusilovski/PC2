using System;
using System.IO;
using System.Windows.Forms;

namespace My_First_Program
{
    public partial class ViewForm : Form
    {
        private string filePath = "memberships.csv"; // Hardcoded file path
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

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                string content = rtbContent.Text;
                string[] lines = content.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                //saves newlines/edits to the file
                File.WriteAllLines(filePath, lines);

                MessageBox.Show("Changes saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving the file: " + ex.Message);
            }
        }
    }
}
