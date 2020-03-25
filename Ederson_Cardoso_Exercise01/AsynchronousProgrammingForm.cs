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
        /// This is the event handler for the CheckEvenOddButton_Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckEvenOddButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve user's input as an int
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
        /// This is the event handler for the GenerateValuesButton_Click event
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
            // generate doubles with interval = random.NextDouble() * (maximum - minimum) + minimum;
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
        /// This is the event handler for the SearchButton_Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get a list from generated values
                List<string> list = GetListString();

                // Check if informed value is present using a generic search method
                bool isPresent = SearchData(list, InputSearchValueTextBox.Text);

                // Present result on MessageBox
                if (isPresent == true)
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
            bool result = false;
            foreach (var item in list)
            {
                if (item.CompareTo(searchValue) == 0)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }// end SearchData

        /// <summary>
        /// This is the event handler for the DisplayButton_Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve user's input as an int
                int lowIndex = int.Parse(InputLowIndexTextBox.Text);
                int highIndex = int.Parse(InputHighIndexTextBox.Text);
                
                // Validate index values
                if(lowIndex < 0 || highIndex >= GeneratedValuesListBox.Items.Count || lowIndex > highIndex)
                { 
                    throw new ArgumentOutOfRangeException(); 
                }

                // Get a list from generated values
                List<string> list = GetListString();

                Display(list, lowIndex, highIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "MESSAGE", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }// end DisplayButton_Click

        /// <summary>
        /// This method returns a 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        private void Display<T>(List<T> list, int low, int high) where T : IComparable<T>
        {
            List<T> between = new List<T>();

            // Populate a sublist between with values from low and high index
            for (int i = low; i <= high; i++)
            {
                between.Add(list[i]);
            }

            OutputValuesBetweenLowHighTextBox.Text = string.Empty;

            // Print values from sublist between
            foreach (var item in between)
            {
                OutputValuesBetweenLowHighTextBox.Text += item + " ";
            }
        }// end Display

        /// <summary>
        /// This method returns a List<string> from GeneratedValuesListBox
        /// </summary>
        /// <returns></returns>
        private List<string> GetListString()
        {
            // Create a list to store values present in the listBox
            List<string> list = new List<string>();

            // Populate list with listBox values
            for (int i = 0; i < GeneratedValuesListBox.Items.Count; i++)
            {
                list.Add(GeneratedValuesListBox.Items[i].ToString());
            }
            return list;
        }// end GetListString
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
        /// This is the event handler for the GetFactorialOfTextBox_KeyPress event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetFactorialOfTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumericDigit(e);
        }
        
        /// <summary>
        /// This is the event handler for the InputNumberTextBox_KeyPress event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumericDigit(e);
        }

        /// <summary>
        /// This is the event handler for the InputLowIndexTextBox_KeyPress event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputLowIndexTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumericDigit(e);
        }

        /// <summary>
        /// This is the event handler for the InputHighIndexTextBox_KeyPress event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputHighIndexTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumericDigit(e);
        }
        #endregion
    } // end class
} // end namespace
