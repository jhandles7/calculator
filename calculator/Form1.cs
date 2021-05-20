using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {

        string user_input = "";

        string num1 = "";
        string num2 = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Percent_button_Click(object sender, EventArgs e)
        {

        }

        

        private void equal_button_Click(object sender, EventArgs e)
        {

        }


        //Number buttons
        private void zero_button_Click(object sender, EventArgs e)
        {
            OutputTxtBox.Text += "0";
            user_input += "0";
        }

        private void one_button_Click(object sender, EventArgs e)
        {
            if (OutputTxtBox.Text == "0")
            {
                OutputTxtBox.Text = "1";
                
            }
            else
            {
                OutputTxtBox.Text += "1";
            }

            user_input += "1";
        }

        private void two_button_Click(object sender, EventArgs e)
        {
            if (OutputTxtBox.Text == "0")
            {
                OutputTxtBox.Text = "2";
            }
            else
            {
                OutputTxtBox.Text += "2";
            }
            user_input += "2";
        }

        private void three_button_Click(object sender, EventArgs e)
        {
            if (OutputTxtBox.Text == "0")
            {
                OutputTxtBox.Text = "3";
            }
            else
            {
                OutputTxtBox.Text += "3";
            }
            user_input += "3";
        }

        private void four_button_Click(object sender, EventArgs e)
        {
            if (OutputTxtBox.Text == "0")
            {
                OutputTxtBox.Text = "4";
            }
            else
            {
                OutputTxtBox.Text += "4";
            }
            user_input += "4";
        }

        private void five_button_Click(object sender, EventArgs e)
        {
            if (OutputTxtBox.Text == "0")
            {
                OutputTxtBox.Text = "5";
            }
            else
            {
                OutputTxtBox.Text += "5";
            }
            user_input += "5";
        }

        private void six_button_Click(object sender, EventArgs e)
        {
            if (OutputTxtBox.Text == "0")
            {
                OutputTxtBox.Text = "6";
            }
            else
            {
                OutputTxtBox.Text += "6";
            }
            user_input += "6";
        }

        private void seven_button_Click(object sender, EventArgs e)
        {
            if (OutputTxtBox.Text == "0")
            {
                OutputTxtBox.Text = "7";
            }
            else
            {
                OutputTxtBox.Text += "7";
            }
            user_input += "7";
        }

        private void eight_button_Click(object sender, EventArgs e)
        {
            if (OutputTxtBox.Text == "0")
            {
                OutputTxtBox.Text = "8";
            }
            else
            {
                OutputTxtBox.Text += "8";
            }
            user_input += "8";
        }

        private void nine_button_Click(object sender, EventArgs e)
        {
            if (OutputTxtBox.Text == "0")
            {
                OutputTxtBox.Text = "9";
            }
            else
            {
                OutputTxtBox.Text += "9";
            }
            user_input += "9";
        }


        //Other button
        private void reset_button_Click(object sender, EventArgs e)
        {
            OutputTxtBox.Text = "0";
        }

        private void decimal_button_Click(object sender, EventArgs e)
        {
                      
            if (OutputTxtBox.Text.Contains("."))
            {
                
            }
            else
            {
                OutputTxtBox.Text += ".";
            }

        }

        private void negative_Button_Click(object sender, EventArgs e)
        {
        }

        private void delete_button_Click(object sender, EventArgs e)
        {

        }

        //Operation of numbers (+,-,/,*)
        private void add_operation_Click(object sender, EventArgs e)
        {
           
        }

        private void subtract_operation_Click(object sender, EventArgs e)
        {

        }

        private void multiply_operation_Click(object sender, EventArgs e)
        {

        }

        private void divide_operation_Click(object sender, EventArgs e)
        {

        }
    }
}
