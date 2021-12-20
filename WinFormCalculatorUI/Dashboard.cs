using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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