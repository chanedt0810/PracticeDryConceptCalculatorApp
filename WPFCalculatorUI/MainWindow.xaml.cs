using System.Windows;
using System.Text.RegularExpressions;
using System.Windows.Input;
using CalculatorLibrary;
using System;
using System.Windows.Controls;

namespace WPFCalculatorUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void getAddResultButton_Click(object sender, RoutedEventArgs e)
        {
            var result = CalculatorFunctionality.AddTwoNumbers(Convert.ToInt32(firstNumber.Text), Convert.ToInt32(secondNumber.Text));
            addResult.Text = result.ToString();
        }

        private new void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = CalculatorFunctionality.isValidInteger(((TextBox)sender).Text + e.Text);
        }
    }
}