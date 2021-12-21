using System;
using System.Windows.Forms;
using CalculatorLibrary;

namespace WinFormCalculatorUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void addNumbersButton_Click(object sender, EventArgs e)
        {
            var result = CalculatorFunctionality.AddTwoNumbers(Convert.ToInt32(firstNumberNumericUpDown.Value), Convert.ToInt32(secondNumberNumericUpDown.Value));
            resultTextBox.Text = result.ToString();
        }
    }
}