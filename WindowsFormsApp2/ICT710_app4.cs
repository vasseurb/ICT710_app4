/**********************************
 * Program: ICT710_app4
 * Author:  Brian Vasseur
 * Date:    June 9, 2019
 * Purpose: This program is designed to accept a name, hourly rate and hours per week
 *          and process that into an output statement with validations along the way.
 *          
 *          This example uses the Validating method on the input textbox eliminating
 *          the need for further validation in other calculations.
 *          
 *          Method TextNotEmpty checks for blank or spaces using ".IsNullOrWhiteSpace"
 *          Method ValidDoubleInput validates that numeric inputs are within a valid range passed as parameters
 *          Method CalcEmpPay formats the input data into an output string and returns it to the output textbox
 *          Method ClearFormData is called from a few places to reset the form and return to the top
 *          
 *          Name is only validated to make sure it is not blank or spaces
 *          Number fields are validated for not blank, 
 *              then convertible to a double (try/catch), 
 *              then input within a valid range
 *          
 *          Two buttons, one to Process the input, one to clear the form as an alternative to Process. 
 *          
 *          
 *  **********************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ICT710_app4 : Form
    {
        //class variables declared here
        string employee_name = "";
        double hours_per_week = 0;
        double hourly_rate = 0;

        public ICT710_app4()
        {
            InitializeComponent();
        }

        private void ICT710_app4_Load(object sender, EventArgs e)
        {

        }

        // This method checks to make sure that a text value is not empty
        private bool TextNotEmpty(string input_value)
        {
            // Check for Null, no entry or just spaces. All are invalid
            if (string.IsNullOrWhiteSpace(input_value))
            {
                MessageBox.Show("This is a required field, please try again");
                return false;
            }
            else
                return true;
        }

        private bool ValidDoubleInput(double input_number, double low_limit, double high_limit)
        {

            if (input_number < low_limit | input_number > high_limit)
            {
                MessageBox.Show("Input must be between " +
                    low_limit.ToString("f2") +
                    " and " +
                    high_limit.ToString("f2"));
                return false;
            }
            return true;
        }

        // Method to process the input values into a formatted output string
        private string CalcEmpPay() // no parameters required, use class variables
        {
            // create an output string based on the validated field entries
            // format $ amounts into currency format

            string pay_statement = "";
            double biweekly_pay = hourly_rate * hours_per_week * 2;

            pay_statement = employee_name + " worked " + hours_per_week + " hours per week at " +
                hourly_rate.ToString("C") + " making their biweekly pay " + biweekly_pay.ToString("C") + "\r\n";
            return pay_statement;
        }

        // Method to clear the form and reset for new input
        private void ClearFormData()
        {
            // Clear data entry fields and class variables
            txt_employee_name.Clear();
            txt_hours_per_week.Clear();
            txt_hourly_rate.Clear();

            employee_name = "";
            hours_per_week = 0;
            hourly_rate = 0;

            txt_employee_name.Focus();
        }


        // Make sure that the user entered something into the name field
        private void txt_employee_name_Validating(object sender, CancelEventArgs e)
        {
            // A future version will pass the object so the code below
            // doesn't get duplicated in every Validating event.
            if (!TextNotEmpty(txt_employee_name.Text))
            {
                txt_employee_name.Clear();
                txt_employee_name.Focus(); //clear the input and go back to field
            }
            else
                employee_name = txt_employee_name.Text;
        }

        // Validating Event for hours/week textbox
        // Check that the user entered something into Hours Per Week
        // Then check that it's a number in a valid range
        private void txt_hours_per_week_Validating(object sender, CancelEventArgs e)
        {
            bool valid_hours_per_week = true; // assume user entered valid input to start

            // Check that something was entered, don't check for numbers yet
            if (!TextNotEmpty(txt_hours_per_week.Text))
            {
                //MessageBox.Show("In Week_validating text not empty");
                valid_hours_per_week = false; // flag that validation has failed
            }
            else
            {
                // try converting the input text to a double
                // if that works then also check that it is within a valid range
                // we've already checked that it is not blank
                try
                {
                    hours_per_week = Convert.ToDouble(txt_hours_per_week.Text); // try converting Textbox Hours to double

                    // valid hours per week range is 0 to 168
                    if (!ValidDoubleInput(hours_per_week, 0, 168))  // check if the number is in range
                    {
                        valid_hours_per_week = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter a number"); // try statement failed
                    valid_hours_per_week = false; // failed on try so fail validation
                }
            }

            if (!valid_hours_per_week)
            {
                txt_hours_per_week.Clear();
                txt_hours_per_week.Focus(); //clear the input and go back to field
            }
        }

        private void txt_hourly_rate_Validating(object sender, CancelEventArgs e)
        {
            bool valid_hourly_rate = true; // assume user entered valid input to start

            // Check that something was entered, don't check for numbers yet
            if (!TextNotEmpty(txt_hourly_rate.Text))
            {
                // MessageBox.Show("In rate_validating text not empty");
                valid_hourly_rate = false;
            }
            else
            {
                try
                {
                    hourly_rate = Convert.ToDouble(txt_hourly_rate.Text); // try converting Textbox Rate to double

                    // valid salary range is $11.50 to $50.00
                    if (!ValidDoubleInput(hourly_rate, 11.50, 50))  // check if the number is in range
                    {
                        valid_hourly_rate = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter a number"); // try statement failed
                    valid_hourly_rate = false; // failed on try so fail validation
                }
            }

            if (!valid_hourly_rate)
            {
                txt_hourly_rate.Clear();
                txt_hourly_rate.Focus(); //clear the input and go back to field
            }
            else
            {
//                MessageBox.Show("Display rate in $ format");
                double num_hourly_rate = Convert.ToDouble(txt_hourly_rate.Text);
                txt_hourly_rate.Text = num_hourly_rate.ToString("C");
            }
        }


        private void btn_process_pay_Click(object sender, EventArgs e)
        {
            txt_payroll_output.Text += CalcEmpPay();
            ClearFormData();
        }


        // Button to clear the form and start over
        private void btn_clear_form_Click(object sender, EventArgs e)
        {
            ClearFormData();
        }
    }
}
