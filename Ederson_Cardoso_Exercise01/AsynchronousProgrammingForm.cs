using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ederson_Cardoso_Exercise01
{
    public partial class AsynchronousProgrammingForm : Form
    {
        public AsynchronousProgrammingForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is de event handler for the CalculeteButton_Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve user's input as an long
                long number = long.Parse(GetFactorialOfTextBox.Text);
                
                FactorialResultLabel.Text = "Calculating...";

                // Task to perform Factorial calculation in separate thread
                Task<long> factorialTask = Task.Run(() => Factorial(number));

                // Wait for Task in separate thread to complete
                await factorialTask;

                if (factorialTask.Result < 0)
                {
                    FactorialResultLabel.Text = "Error: Could not be calculated.";
                }
                else
                {
                    // Display result after Task in separate thread completes
                    FactorialResultLabel.Text = factorialTask.Result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //end CalculateButton_Click
        
        /// <summary>
        /// This methos returns a factorial of a number using recursion
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public long Factorial(long num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }
            return num * Factorial(num - 1);
        }
        
        /// <summary>
        /// This method validate field content for only numeric values
        /// </summary>
        /// <param name="e"></param>
        private static void ValidateNumericDigit(KeyPressEventArgs e)
        {
            // Allow "number" and "backscape"
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        /// <summary>
        /// This is the event handler for the GetFactorialOfTextBox KeyPress event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetFactorialOfTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumericDigit(e);
        }
        
        /// <summary>
        /// This is the event handler for the InputNumberTextBox KeyPress event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumericDigit(e);
        }
    } // end class
} // end namespace
