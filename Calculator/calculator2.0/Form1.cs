using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator2._0
{
    public partial class Form1 : Form
    {
        string operation; // + , / , - , *;
        string userInput = "";
        string lastclick = "";
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




        private void plus_Click(object sender, EventArgs e)
        {
            operation = "+";
            //display.Text = "";
            display.Text = "+";
            if (userInput != "")
            {
                result += Convert.ToDouble(userInput);
            }



            if (lastclick == "=")
            {
                label1.Text = result + "+";
            }
            else
            {

                if (lastclick != "+")
                {

                    // label1.Text += "+";
                    if ((lastclick == "-") || (lastclick == "*") || (lastclick == "/"))
                    //if (lastclick == "-")
                    {
                        label1.Text = result + "+";
                    }
                    else
                    {
                        label1.Text += "+";

                    }
                }

                userInput = "";

            }

            lastclick = "+";

        }

        private void minus_Click(object sender, EventArgs e)
        {
            operation = "-";
            //display.Text = "";
            display.Text = "-";
            if (userInput != "")
            {
                result -= Convert.ToDouble(userInput);
            }



            if (lastclick == "=")
            {
                label1.Text = result + "-";
            }
            else
            {


                if (lastclick != "-")
                {


                    //label1.Text += "-";
                    if ((lastclick == "+") || (lastclick == "*") || (lastclick == "/"))
                    //if (lastclick == "+")
                    {
                        label1.Text = result + "-";
                    }
                    else
                    {
                        label1.Text += "-";

                    }


                }


                userInput = "";
            }

            lastclick = "-";
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            operation = "/";
            //display.Text = "";
            display.Text = "/";
            if (userInput != "")
            {
                result += Convert.ToDouble(userInput);
            }



            if (lastclick == "=")
            {
                label1.Text = result + "/";
            }
            else
            {


                if (lastclick != "/")
                {


                    //label1.Text += "-";
                    if ((lastclick == "+") || (lastclick == "-") || (lastclick == "*"))
                    //if (lastclick == "+")
                    {
                        label1.Text = result + "/";
                    }
                    else
                    {
                        label1.Text += "/";

                    }


                }


                userInput = "";
            }

            lastclick = "/";
        }

        private void equation_Click(object sender, EventArgs e)
        {
            if ((lastclick != "+") && (lastclick != "-") && (lastclick != "*") && (lastclick != "/"))
            {
                if (operation == "+")
                {
                    display.Text = "";
                    result += Convert.ToDouble(userInput);
                    display.Text = result.ToString();

                }
                if (operation == "-")
                {
                    display.Text = "";
                    result -= Convert.ToDouble(userInput);
                    display.Text = result.ToString();

                }
                if (operation == "*")
                {
                    display.Text = "";
                    result *= Convert.ToDouble(userInput);
                    display.Text = result.ToString();

                }
                if (operation == "/")
                {
                    display.Text = "";
                    result /= Convert.ToDouble(userInput);
                    display.Text = result.ToString();

                }




                operation = "";
                userInput = "";

                if (lastclick != "=")
                {
                    label1.Text += "=";
                }
                lastclick = "=";


            }


        }

        private void clearButton_Click(object sender, EventArgs e)
        {

            userInput = "";
            result = 0.0;
            label1.Text = "0";
            display.Text = "0";
        }

        private void display_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "0";
            display.Text += userInput; // rezultat


            label1.Text += "0";
            lastclick = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "1";
            display.Text += userInput; // rezultat


            label1.Text += "1";
            lastclick = "1";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "4";
            display.Text += userInput; // rezultat


            label1.Text += "4";
            lastclick = "4";
        }


        private void button5_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "5";
            display.Text += userInput; // rezultat


            label1.Text += "5";
            lastclick = "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "2";
            display.Text += userInput; // rezultat


            label1.Text += "2";
            lastclick = "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "3";
            display.Text += userInput; // rezultat


            label1.Text += "3";
            lastclick = "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "6";
            display.Text += userInput; // rezultat


            label1.Text += "6";
            lastclick = "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "7";
            display.Text += userInput; // rezultat


            label1.Text += "7";
            lastclick = "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "8";
            display.Text += userInput; // rezultat


            label1.Text += "8";
            lastclick = "8";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "9";
            display.Text += userInput; // rezultat


            label1.Text += "9";
            lastclick = "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += ",";
            display.Text += userInput; // rezultat


            label1.Text += ",";
            lastclick = ",";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            {
                operation = "*";
                //display.Text = "";
                display.Text = "*";
                if (userInput != "")
                {
                    result += Convert.ToDouble(userInput);
                }



                if (lastclick == "=")
                {
                    label1.Text = result + "*";
                }
                else
                {


                    if (lastclick != "*")
                    {


                        //label1.Text += "-";
                        if ((lastclick == "+") || (lastclick == "-") || (lastclick == "/"))
                        //if (lastclick == "+")
                        {
                            label1.Text = result + "*";
                        }
                        else
                        {
                            label1.Text += "*";

                        }


                    }


                    userInput = "";
                }

                lastclick = "*";
            }
        }
    }
}