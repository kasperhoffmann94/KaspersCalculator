using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.XPath;

namespace Calculator
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

        private void Addition_ButtonClicked(object sender, RoutedEventArgs e)
        {

             CalculateWithOperator("+");
        }

        private void Subtraction_ButtonClicked(object sender, RoutedEventArgs e)
        {
            CalculateWithOperator("-");
        }

        private void Multiply_ButtonClicked(object sender, RoutedEventArgs e)
        {
            CalculateWithOperator("*");
        }

        private void Divide_ButtonClicked(object sender, RoutedEventArgs e)
        {
            CalculateWithOperator("/");
        }

        private void Modulus_ButtonClicked(object sender, RoutedEventArgs e)
        {
            CalculateWithOperator("%");
        }

        private void SquareRoot_ButtonClicked(object sender, RoutedEventArgs e)
        {
          
            CalculateWithOperator("Sqrt");

            Number2_Textbox.IsEnabled = true;
        }


        private void CalculateWithOperator(string operatorString)
        {
            double firstInput = 0;
            double secondInput = 0;

            CheckForNullOrWhiteSpace(Number1_Textbox.Text, firstInput);
            CheckForNullOrWhiteSpace(Number2_Textbox.Text, secondInput);

            double result = 0;
            string error;            switch (operatorString)
            {
                case "+":
                    result = firstInput + secondInput;
                    break;
                case "-":
                    result = firstInput - secondInput;
                    break;
                case "*":
                    result = firstInput * secondInput;
                    break;
                case "/":
                    result = firstInput / secondInput;
                    break;
                case "%":
                    result = firstInput % secondInput;
                    break;
                case "Sqrt":
                    if (!string.IsNullOrWhiteSpace(Number2_Textbox.Text))
                    {
                        result = Math.Sqrt(firstInput);
                    }
                    else if(!string.IsNullOrWhiteSpace(Number1_Textbox.Text))
                        result = Math.Sqrt(secondInput);
                    
                    break;
                default:
                    result = 0;
                    break;
            }

            Result_Textbox.Text = result.ToString();
        }


        private void CheckForNullOrWhiteSpace(string textBox, double input)
        {
            if (string.IsNullOrWhiteSpace(textBox))
            {
               textBox = 0.ToString();
            }
            else
            {
                input = double.Parse(textBox);
            }

        }
    }
}


