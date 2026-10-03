using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void calculateButton_Click(object sender, EventArgs e)
        {
            
            {
                double hoursWorked;
                double hourlyPayRate;
                double grossPay;

                hoursWorked = double.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = double.Parse(hourlyPayRateTextBox.Text);

                if (hoursWorked <= 40)
                {
                    grossPay = hoursWorked * hourlyPayRate;
                }
                else
                {
                    double regularPay = 40 * hourlyPayRate;
                    double overtimeHours = hoursWorked - 40;
                    double overtimePay = overtimeHours * hourlyPayRate * 1.5;

                    grossPay = regularPay + overtimePay;
                }

                grossPayLabel.Text = grossPay.ToString("C2");
            }
        }

        
            private void clearButton_Click(object sender, EventArgs e)
        {
            hoursWorkedTextBox.Clear();
            hourlyPayRateTextBox.Clear();
            grossPayTextBox.Clear();

            hoursWorkedTextBox.Focus();
        }

        
            private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
    
    

