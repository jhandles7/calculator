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
        double num1;
        string operation;
        double result;

        public Form1()
        {
            InitializeComponent();
        }

        //Number buttons
        private void zero_button_Click(object sender, EventArgs e)
        {
            if (OutputTxtBox.Text != "0")
            {
                OutputTxtBox.Text += "0";
            }
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
        }


        //Other button
        private void reset_button_Click(object sender, EventArgs e)
        {
            try
            {
                OutputTxtBox.Text = "0";
                lbl_operation.Text = "";
                num1 = 0;
            }
            catch (Exception)
            {
            }
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
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (OutputTxtBox.TextLength <=1)
            {
                OutputTxtBox.Text = "0";
            }
            else
            {
                OutputTxtBox.Text = OutputTxtBox.Text.Remove(OutputTxtBox.TextLength - 1);
            }
        }

        
        //Operation of numbers (+,-,/,*)
        private void add_operation_Click(object sender, EventArgs e)
        {
            try
            {
                if (num1 == 0)
                {
                    num1 = Convert.ToDouble(OutputTxtBox.Text);
                    OutputTxtBox.Text = "0";
                    operation = "+";
                    lbl_operation.Text = num1.ToString() + operation;
                }
                else
                {
                    equal_button.PerformClick();
                    operation = "+";
                    lbl_operation.Text = result.ToString() + operation;
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
                    num1 = Convert.ToDouble(OutputTxtBox.Text);
                    OutputTxtBox.Text = "0";
                    operation = "-";
                    lbl_operation.Text = num1.ToString() + operation;
                }
                else
                {
                    equal_button.PerformClick();
                    operation = "-";
                    lbl_operation.Text = result.ToString() + operation;
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
                    num1 = Convert.ToDouble(OutputTxtBox.Text);
                    OutputTxtBox.Text = "0";
                    operation = "*";
                    lbl_operation.Text = num1.ToString() + operation;
                }
                else
                {
                    equal_button.PerformClick();
                    operation = "*";
                    lbl_operation.Text = result.ToString() + operation;
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
                    num1 = Convert.ToDouble(OutputTxtBox.Text);
                    operation = "/";
                    lbl_operation.Text = num1.ToString() + operation;
                    OutputTxtBox.Text = "0";
                }
                else
                {
                    equal_button.PerformClick();
                    operation = "/";
                    lbl_operation.Text = result.ToString() + operation;
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
            num2 = Convert.ToDouble(OutputTxtBox.Text);
            //enable the operation button
            subtract_operation.Enabled = true;
            add_operation.Enabled = true;
            multiply_operation.Enabled = true;
            divide_operation.Enabled = true;

            if (operation == "+")
            {
                result = num1 + num2;
                OutputTxtBox.Text = Convert.ToString(result);
                lbl_operation.Text = num1 + operation + num2 + "=";
            }

            if (operation == "-")
            {
                result = num1 - num2;
                OutputTxtBox.Text = Convert.ToString(result);
                lbl_operation.Text = num1 + operation + num2 + "=";
            }

            if (operation == "*")
            {
                result = num1 * num2;
                OutputTxtBox.Text = Convert.ToString(result);
                lbl_operation.Text = num1 + operation + num2 + "=";
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
                    lbl_operation.Text = num1 + operation + num2 + "=";
                }
            }
            num1 = result;
            //enable percent button
            Percent_button.Enabled = true;
            //disable equal button
            equal_button.Enabled = false;
        }

        double new_num;
        private void Percent_button_Click_1(object sender, EventArgs e)
        {
            try
            {           
                new_num = Convert.ToDouble(OutputTxtBox.Text);
                if (new_num.Equals(0))
                {
                    OutputTxtBox.Text = "Error";
                }
                else
                {
                    if (num1 != 0)
                    {
                        new_num = new_num / 100;
                        OutputTxtBox.Text = new_num.ToString();
                        equal_button.PerformClick();
                    }
                    else
                    {
                        lbl_operation.Text = new_num.ToString() + "%";
                        new_num = new_num / 100;
                        OutputTxtBox.Text = Convert.ToString(new_num);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void btn_1overX_Click(object sender, EventArgs e)
        {
            try
            {
                new_num = Convert.ToDouble(OutputTxtBox.Text);
                if (new_num.Equals(0))
                {
                    OutputTxtBox.Text = "Error";
                    lbl_operation.Text = "1/0 =";
                }
                else
                {
                    if (num1!= 0)
                    {          
                        new_num = 1 / new_num;
                        OutputTxtBox.Text = new_num.ToString();
                        equal_button.PerformClick();
                    }
                    else
                    {
                        lbl_operation.Text = "1/" + new_num.ToString();
                        new_num = 1 / new_num;
                        OutputTxtBox.Text = Convert.ToString(new_num);
                    }
                }       
            }
            catch (Exception)
            {

            }
        }

        private void btn_squared_Click(object sender, EventArgs e)
        {
            if (num1 != 0)
            {
                new_num = Convert.ToDouble(OutputTxtBox.Text);
                new_num = new_num * new_num;
                OutputTxtBox.Text = new_num.ToString();
                equal_button.PerformClick();
            }
            else
            {
                new_num = Convert.ToDouble(OutputTxtBox.Text);
                lbl_operation.Text = "(" + new_num.ToString() + ")²";
                new_num = new_num * new_num;
                OutputTxtBox.Text = Convert.ToString(new_num);
            }
        }

        private void btn_sqr_root_Click(object sender, EventArgs e)
        {
            if (num1!=0)
            {
                new_num = Convert.ToDouble(OutputTxtBox.Text);
                new_num = Math.Round(Math.Sqrt(new_num), 6);
                OutputTxtBox.Text = new_num.ToString();
                equal_button.PerformClick();
                OutputTxtBox.Text = Convert.ToString(result);
            }
            else
            {
                new_num = Convert.ToDouble(OutputTxtBox.Text);
                lbl_operation.Text = "√" + new_num.ToString();
                new_num = Math.Round(Math.Sqrt(new_num), 6);
                OutputTxtBox.Text = Convert.ToString(new_num);
            }
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            if (num1 != 0)
            {
                lbl_operation.Text = num1.ToString();
            }
            OutputTxtBox.Text = "0";
        }
    }
}
