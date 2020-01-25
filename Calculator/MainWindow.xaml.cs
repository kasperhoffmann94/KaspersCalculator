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
           
           Result.Text = (int.Parse(Number1.Text) + int.Parse(Number2.Text)).ToString();
        }

        private void Subtraction_ButtonClicked(object sender, RoutedEventArgs e)
        {
            Result.Text = (int.Parse(Number1.Text) - int.Parse(Number2.Text)).ToString();
        }

        private void Multiply_ButtonClicked(object sender, RoutedEventArgs e)
        {
            Result.Text = (int.Parse(Number1.Text) * int.Parse(Number2.Text)).ToString();
        }

        private void Divide_ButtonClicked(object sender, RoutedEventArgs e)
        {
            Result.Text = (int.Parse(Number1.Text) / int.Parse(Number2.Text)).ToString();
        }

        private void Modulus_ButtonClicked(object sender, RoutedEventArgs e)
        {

        }

        private void SquareRoot_ButtonClicked(object sender, RoutedEventArgs e)
        {

        }
    }
}
