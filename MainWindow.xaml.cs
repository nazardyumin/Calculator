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

        private void ButtonCE_Click(object sender, RoutedEventArgs e)
        {
            TextDown.Text="";
        }

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            TextUp.Text += "7";
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (TextDown.Text.Length%4==0)
            {
                TextDown.Text += " ";
            }
            if (TextDown.Text.Length == 14)
            {
                TextDown.FontSize -= 10;
            }
            if (TextDown.Text.Length == 20)
            {
                TextDown.FontSize -= 10;
            }
            TextDown.Text += "7";
        }
    }
}
