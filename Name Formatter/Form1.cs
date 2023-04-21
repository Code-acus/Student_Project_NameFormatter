using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Name_Formatter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFormatName_Click(object sender, EventArgs e)
        {
            // Add the try catch block
            try
            {
                // Declare variables
                string firstName;
                string middleName;
                string lastName;
                string title;

                // Get the first name
                firstName = txtFirstName.Text;
                middleName = txtMiddleName.Text;
                lastName = txtLastName.Text;
                title = txtTitle.Text;

                // Write a conditional
                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(middleName) ||
                    string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(title)) 
                {
                    throw new Exception("Please enter a full name and title.");
                }

                // Format the name and display it
                lblTitleName.Text = title + " " + firstName + " " + middleName + " " + lastName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            txtTitle.Clear();
            lblTitleName.Text = "";

            // Set the focus to the first name text box
            txtFirstName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
