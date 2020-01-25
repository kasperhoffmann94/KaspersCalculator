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

             CalculateWithOperator(0);
        }

        private void Subtraction_ButtonClicked(object sender, RoutedEventArgs e)
        {
            CalculateWithOperator(1);
        }

        private void Multiply_ButtonClicked(object sender, RoutedEventArgs e)
        {
            CalculateWithOperator(2);
        }

        private void Divide_ButtonClicked(object sender, RoutedEventArgs e)
        {
            CalculateWithOperator(3);
        }

        private void Modulus_ButtonClicked(object sender, RoutedEventArgs e)
        {
            CalculateWithOperator(4);
        }

        private void SquareRoot_ButtonClicked(object sender, RoutedEventArgs e)
        {

        }


        private void CalculateWithOperator(int operatorInt)
        {
            int firstInput = int.Parse(Number1_Textbox.Text);
            int secondInput = int.Parse(Number2_Textbox.Text);
            int result = 0;
            switch (operatorInt)
            {
                case 0:
                    result = firstInput + secondInput;
                    break;
                case 1:
                    result = firstInput - secondInput;
                    break;
                case 2:
                    result = firstInput * secondInput;
                    break;
                case 3:
                    result = firstInput / secondInput;
                    break;
                case 4:
                    result = firstInput % secondInput;
                    break;
                case 5:

                    break;
                case 6:

                    break;
            }

            Result_Textbox.Text = result.ToString();
        }
    }
}
