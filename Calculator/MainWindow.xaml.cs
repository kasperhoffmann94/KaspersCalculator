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

             CalculateWithOperator(addition_Button.Content.ToString());
        }

        private void Subtraction_ButtonClicked(object sender, RoutedEventArgs e)
        {
            CalculateWithOperator(subtraction_Button.Content.ToString());
        }

        private void Multiply_ButtonClicked(object sender, RoutedEventArgs e)
        {
            CalculateWithOperator(multiply_Button.Content.ToString());
        }

        private void Divide_ButtonClicked(object sender, RoutedEventArgs e)
        {
            CalculateWithOperator(divide_Button.Content.ToString());
        }

        private void Modulus_ButtonClicked(object sender, RoutedEventArgs e)
        {
            CalculateWithOperator(modulus_Button.Content.ToString());
        }

        private void SquareRoot_ButtonClicked(object sender, RoutedEventArgs e)
        {

        }


        private void CalculateWithOperator(string operatorString)
        {
            int firstInput = int.Parse(Number1_Textbox.Text);
            int secondInput = int.Parse(Number2_Textbox.Text);
            int result = 0;
            string error;
            switch (operatorString)
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
                case "sqrt":
                    break;
                default:
                    error = "You have not entered any number";
                    Result_Textbox.Text = error;
                    break;
            }

            Result_Textbox.Text = result.ToString();
        }
    }
}
