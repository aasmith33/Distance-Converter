using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbigailSmith_CPT_185_Chapter_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtDistance.Focus();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {   //declaring variables
            string fromDistance, toDistance;
            try
            {
                double distance = double.Parse(txtDistance.Text);
                if (distance > 0)
                {   
                    // declaring variables
                    fromDistance = lstFrom.SelectedIndex.ToString();
                    toDistance = lstTo.SelectedIndex.ToString();
                    string feet = " ft";
                    string yard = " yd";
                    string inches = " in";
                    // convert units
                    if (fromDistance == "2" && toDistance == "1") // from yards to feet
                        txtConverted.Text = (distance * 3).ToString() + feet;
                    else if (fromDistance == "1" && toDistance == "2") // from feet to yards
                        txtConverted.Text = (distance / 3).ToString() + yard;
                    else if (fromDistance == "2" && toDistance == "0") // from yards to inches
                        txtConverted.Text = (distance * 36).ToString() + inches;
                    else if (fromDistance == "0" && toDistance == "2") // from inches to yards
                        txtConverted.Text = (distance / 36).ToString() + yard;
                    else if (fromDistance == "1" && toDistance == "0") // from feet to inches
                        txtConverted.Text = (distance * 12).ToString() + inches;
                    else if (fromDistance == "0" && toDistance == "1") // from inches to feet
                        txtConverted.Text = (distance / 12).ToString() + feet;
                    else if (fromDistance == toDistance && toDistance == "0") // from inches to inches
                        txtConverted.Text = distance.ToString() + " " + inches;
                    else if (fromDistance == toDistance && toDistance == "1") // from feet to feet
                        txtConverted.Text = distance.ToString() + " " + feet;
                    else if (fromDistance == toDistance && toDistance == "2") // from yards to yards
                        txtConverted.Text = distance.ToString() + " " + yard;
                }
                
                else MessageBox.Show("Negative Number"); // error message 
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message); //error message 
                txtDistance.Focus(); // puts insertion point back to the beginning
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {   // clears form when clicked
            txtDistance.Clear();
            txtConverted.Clear();
            lstFrom.ClearSelected();
            lstTo.ClearSelected();
            txtDistance.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {   // closes form when clicked
            Close();
        }
    }
}
