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
        // Declare a delegate that takes an int argument and returns a bool result.
        delegate bool IsEvenDelegate(int number);
        delegate bool IsOddDelegate(int number);

        public AsynchronousProgrammingForm()
        {
            InitializeComponent();
            IntegersRadioButton.Checked = true;
        }

        #region Part I
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
                
                // Validate Maximum allowed long number
                if (number > 20) 
                { 
                    throw new OverflowException(); 
                }
                else
                {
                    // Task to perform Factorial calculation in separate thread
                    Task<long> factorialTask = Task.Run(() => CalculateFactorial(number));
                    
                    // Wait for Task in separate thread to complete
                    await factorialTask;

                    if (factorialTask.Result <= 0)
                    {
                        throw new OverflowException();
                    }
                    else
                    {
                        // Display result after Task in separate thread
                        FactorialResultLabel.Text = "Result is: " + factorialTask.Result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "MESSAGE",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //end CalculateButton_Click

        /// <summary>
        /// This methos returns a factorial of a long number using recursion
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private long CalculateFactorial(long num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }
            else
            {
                try
                {
                    return checked(num * CalculateFactorial(num - 1));
                }
                catch (OverflowException)
                {
                    return 0;
                }
            }
        } // end CalculateFactorial
        #endregion

        #region Part II
        /// <summary>
        /// This is the event handler for the CheckEvenOddButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckEvenOddButton_Click(object sender, EventArgs e)
        {
            try
            {
                int input = int.Parse(InputNumberTextBox.Text);

                IsEvenDelegate delIsEven = IsEven;
                bool isEven = delIsEven(input);

                IsOddDelegate delIsOdd = IsOdd;
                bool isOdd = delIsOdd(input);

                if (isEven == true)
                {
                    EvenOddResultLabel.Text = "Result is: Even";
                }
                if (isOdd == true)
                {
                    EvenOddResultLabel.Text = "Result is: Odd";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "MESSAGE",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // end CheckEvenOddButton_Click

        /// <summary>
        /// This method returns true for an Even number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private bool IsEven(int number) => number % 2 == 0;

        /// <summary>
        /// This method returns true for an Odd number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private bool IsOdd(int number) => number % 2 == 1;
        #endregion

        #region Part III
        /// <summary>
        /// This is the event handler for the GenerateValuesButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateValuesButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            GeneratedValuesListBox.Items.Clear();

            // generate integers between 10 and 99
            if (IntegersRadioButton.Checked)
            {
                int result;
                for (int counter = 1; counter <= 10; counter++)
                {
                    result = random.Next(10, 100);
                    GeneratedValuesListBox.Items.Add(result);
                }
            }
            // generate doubles with interval
            // random.NextDouble() * (maximum - minimum) + minimum;
            else if (DoublesRadioButton.Checked)
            {
                double result;
                for (int counter = 1; counter <= 10; counter++)
                {
                    result = random.NextDouble() * (99 - 10) + 10;
                    GeneratedValuesListBox.Items.Add(Math.Round(result, 2));
                }
            }
            // generate chars
            else if(CharRadioButton.Checked)
            {
                char result;
                for (int counter = 1; counter <= 10; counter++)
                {
                     result = (char)random.Next('A', 'Z');
                     GeneratedValuesListBox.Items.Add(result);
                }
            }
        }// GenerateValuesButton_Click

        /// <summary>
        /// This is the event handler for the SearchButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a list to store values present in the listBox
                List<string> list = new List<string>();
                
                // Populate list with listBox values
                for (int i = 0; i < GeneratedValuesListBox.Items.Count; i++)
                {
                    list.Add(GeneratedValuesListBox.Items[i].ToString());
                }

                // Check if informed value is present using a generic search method
                bool result = SearchData(list, InputSearchValueTextBox.Text);

                // Present result on MessageBox
                if (result == true)
                {
                    MessageBox.Show("Informed value is present in the list.");
                }
                else
                {
                    MessageBox.Show("Informed value is NOT present in the list.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "MESSAGE",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }// end SearchButton_Click

        /// <summary>
        /// This generic method returns True if an element is present in a list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        private bool SearchData<T>(List<T> list, T searchValue) where T : IComparable<T>
        {
            bool isPresent = false;
            foreach (var item in list)
            {
                if (item.CompareTo(searchValue) == 0)
                {
                    isPresent = true;
                    break;
                }
            }
            return isPresent;
        }// end SearchData

        /// <summary>
        /// This is the event handler for the DisplayButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayButton_Click(object sender, EventArgs e)
        {

        }// end DisplayButton_Click
        #endregion

        #region Generic Field Validations
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
        #endregion
    } // end class
} // end namespace
