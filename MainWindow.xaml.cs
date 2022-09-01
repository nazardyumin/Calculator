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
            TextDown.Text += "0";
        }

        private void ButtonCE_Click(object sender, RoutedEventArgs e)
        {
            TextDown.Text = "0";
            TextDown.FontSize =45;
        }

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            TextDown.Text += "0";
            TextDown.FontSize = 45;
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (TextDown.Text.Length == 11)
            {
                TextDown.FontSize -= 9;
            }
            if (TextDown.Text.Length == 15)
            {
                TextDown.FontSize -= 7;
            }
            if (TextDown.Text.Length == 19)
            {
                TextDown.FontSize -= 5;
            }
            if (TextDown.Text.Length == 23)
            {
                TextDown.FontSize -= 3.5;
            }
            if (TextDown.Text.Length >= 27)
            {
                TextDown.TextWrapping = TextWrapping.WrapWithOverflow;
            }
            if (TextDown.Text.Length == 54)
            {
                TextDown.FontSize -= 3;
            }
            if (TextDown.Text.Length == 95)
            {
                TextDown.FontSize -= 4;
            }
            if (TextDown.Text=="0")
            {
                TextDown.Text = "7";
            }
            else
            {
                if (TextDown.Text.Length == 3)
                {
                    TextDown.Text += " ";
                }
                if (TextDown.Text.Length >= 7 && TextDown.Text[^1] != ' ' && TextDown.Text[^2] != ' ' && TextDown.Text[^3] != ' ')
                {
                    TextDown.Text += " ";
                }
                TextDown.Text += "7";
            }     
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (TextDown.Text.Length == 11)
            {
                TextDown.FontSize -= 9;
            }
            if (TextDown.Text.Length == 15)
            {
                TextDown.FontSize -= 7;
            }
            if (TextDown.Text.Length == 19)
            {
                TextDown.FontSize -= 5;
            }
            if (TextDown.Text.Length == 23)
            {
                TextDown.FontSize -= 3.5;
            }
            if (TextDown.Text.Length >= 27)
            {
                TextDown.TextWrapping = TextWrapping.WrapWithOverflow;
            }
            if (TextDown.Text.Length == 54)
            {
                TextDown.FontSize -= 3;
            }
            if (TextDown.Text.Length == 95)
            {
                TextDown.FontSize -= 4;
            }
            if (TextDown.Text == "0")
            {
                TextDown.Text = "8";
            }
            else
            {
                if (TextDown.Text.Length == 3)
                {
                    TextDown.Text += " ";
                }
                if (TextDown.Text.Length >= 7 && TextDown.Text[^1] != ' ' && TextDown.Text[^2] != ' ' && TextDown.Text[^3] != ' ')
                {
                    TextDown.Text += " ";
                }
                TextDown.Text += "8";
            }
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {           
            if (TextDown.Text.Length == 11)
            {
                TextDown.FontSize -= 9;
            }
            if (TextDown.Text.Length == 15)
            {
                TextDown.FontSize -= 7;
            }
            if (TextDown.Text.Length == 19)
            {
                TextDown.FontSize -= 5;
            }
            if (TextDown.Text.Length == 23)
            {
                TextDown.FontSize -= 3.5;
            }
            if (TextDown.Text.Length >= 27)
            {
                TextDown.TextWrapping = TextWrapping.WrapWithOverflow;
            }
            if (TextDown.Text.Length == 54)
            {
                TextDown.FontSize -= 3;
            }
            if (TextDown.Text.Length == 95)
            {
                TextDown.FontSize -= 4;
            }
            if (TextDown.Text == "0")
            {
                TextDown.Text = "9";
            }
            else
            {
                if (TextDown.Text.Length == 3)
                {
                    TextDown.Text += " ";
                }
                if (TextDown.Text.Length >= 7 && TextDown.Text[^1]!=' '&& TextDown.Text[^2] != ' ' && TextDown.Text[^3] != ' ')
                {
                    TextDown.Text += " ";
                }
                TextDown.Text += "9";
            }
        }
    }
}
