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
        double num1;
        string operation;
        double result;

        public Form1()
        {
            InitializeComponent();
        }

        ///private void Percent_button_Click(object sender, EventArgs e)
        ///{
            //num1 = Convert.ToDouble(user_input);
            //OutputTxtBox.Text += "%";
            
        //}


        //Number buttons
        private void zero_button_Click(object sender, EventArgs e)
        {
            if (OutputTxtBox.Text == "0")
            {

            }
            else
            {
                OutputTxtBox.Text += "0";
            }
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
            user_input = "";
            labelOperation.Text = "";
            num1 = 0;
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
            double negative_num;

            negative_num = double.Parse(OutputTxtBox.Text);
            negative_num *= -1;
            if (OutputTxtBox.Text.Substring(0) == "0")
            {
                OutputTxtBox.Text = negative_num.ToString().Remove(1);
            }
            else
            {
                OutputTxtBox.Text = negative_num.ToString();
            }
            
            user_input = OutputTxtBox.Text;         
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (OutputTxtBox.TextLength <1)
            {
                OutputTxtBox.Text = "0";
            }
            else
            {
                OutputTxtBox.Text = OutputTxtBox.Text.Remove(OutputTxtBox.TextLength - 1);
            }
            user_input = OutputTxtBox.Text;
        }

        
        //Operation of numbers (+,-,/,*)
        private void add_operation_Click(object sender, EventArgs e)
        {
            try
            {
                if (num1 == 0)
                {
                    num1 = Convert.ToDouble(user_input);
                    OutputTxtBox.Text = "0";
                    operation = "+";
                    labelOperation.Text = num1.ToString() + operation;
                    user_input = "";
                }
                else
                {
                    equal_button.PerformClick();
                    operation = "+";
                    labelOperation.Text = result.ToString() + operation;
                    user_input = "";
                    OutputTxtBox.Text = "0";
                    num1 = result;
                    equal_button.PerformClick(); 
                }
            }
            catch (Exception)
            {
                add_operation.Enabled = false;
            }
            //enable the percent button
            Percent_button.Enabled = true;
            //enable equal button
            equal_button.Enabled = true;
        }

        
        private void subtract_operation_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (num1 == 0)
                {
                    num1 = Convert.ToDouble(user_input);
                    OutputTxtBox.Text = "0";
                    operation = "-";
                    labelOperation.Text = num1.ToString() + operation;
                    user_input = "";
                }
                else
                {
                    equal_button.PerformClick();
                    operation = "-";
                    labelOperation.Text = result.ToString() + operation;
                    user_input = "";
                    OutputTxtBox.Text = "0";
                    num1 = result;
                    equal_button.PerformClick();
                }
                
            }
            catch (Exception)
            {
                subtract_operation.Enabled = false;
            }
            //enable percent button
            Percent_button.Enabled = true;
            //enable equal button
            equal_button.Enabled = true;
            
        }

        
        private void multiply_operation_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (num1 == 0)
                {
                    num1 = Convert.ToDouble(user_input);
                    OutputTxtBox.Text = "0";
                    operation = "*";
                    labelOperation.Text = num1.ToString() + operation;
                    user_input = "";
                }
                else
                {
                    equal_button.PerformClick();
                    operation = "*";
                    labelOperation.Text = result.ToString() + operation;
                    user_input = "";
                    OutputTxtBox.Text = "0";
                    num1 = result;
                    equal_button.PerformClick();
                }
            }
            catch (Exception)
            {
                multiply_operation.Enabled = false;
            }
            //enable percent button
            Percent_button.Enabled = true;
            //enable equal button
            equal_button.Enabled = true;
        }

        
        private void divide_operation_Click(object sender, EventArgs e)
        {
            try
            {
                if (num1 == 0)
                {
                    equal_button.PerformClick();
                    operation = "-";
                    labelOperation.Text = result.ToString() + operation;
                    user_input = "";
                    OutputTxtBox.Text = "0";
                    num1 = result;
                    equal_button.PerformClick();
                }
                else
                {
                    equal_button.PerformClick();
                    operation = "/";
                    labelOperation.Text = result.ToString() + operation;
                    user_input = "";
                    OutputTxtBox.Text = "0";
                    num1 = result;
                    equal_button.PerformClick();
                }
            }
            catch (Exception)
            {
                divide_operation.Enabled = false;
            }
            //enable percent button
            Percent_button.Enabled = true;
            //enable equal button
            equal_button.Enabled = true;

        }

        private void equal_button_Click_1(object sender, EventArgs e)
        {
            double num2;
            num2 = Convert.ToDouble(user_input);
            //enable the operation button
            subtract_operation.Enabled = true;
            add_operation.Enabled = true;
            multiply_operation.Enabled = true;
            divide_operation.Enabled = true;

            if (operation == "+")
            {
                result = num1 + num2;
                OutputTxtBox.Text = Convert.ToString(result);
                user_input = result.ToString();
                labelOperation.Text += num2 + "=";
            }

            if (operation == "-")
            {
                result = num1 - num2;
                OutputTxtBox.Text = Convert.ToString(result);
                user_input = result.ToString();
                labelOperation.Text += num2 + "=";
            }

            if (operation == "*")
            {
                result = num1 * num2;
                OutputTxtBox.Text = Convert.ToString(result);
                user_input = result.ToString();
                labelOperation.Text += num2 + "=";
            }

            if (operation == "/")
            {
                if (num2 == 0)
                {
                    OutputTxtBox.Text = "Error";
                }

                else
                {
                    result = num1 / num2;
                    OutputTxtBox.Text = Convert.ToString(result);
                    user_input = result.ToString();
                    labelOperation.Text += num2 + "=";
                }
            }
            //enable percent button
            Percent_button.Enabled = true;
            //disable equal button
            equal_button.Enabled = false;
        }

        private void Percent_button_Click_1(object sender, EventArgs e)
        {
            double new_num;
            try
            {           
                new_num = Convert.ToDouble(user_input);
                new_num = new_num / 100;
                OutputTxtBox.Text = Convert.ToString(new_num);
                user_input = new_num.ToString();
                Percent_button.Enabled = false;
            }
            catch (Exception)
            {

            }
        }
    }
}
