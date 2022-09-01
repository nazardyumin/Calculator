﻿using System;
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
            TextUp.Text = "";
            TextDown.Text = "0";
        }

        private void ButtonCE_Click(object sender, RoutedEventArgs e)
        {
            TextUp.Text = "";
            TextDown.Text = "0";
            TextDown.FontSize =45;
            TextDown.TextWrapping = TextWrapping.NoWrap;
        }

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            TextDown.Text = "0";
            TextDown.FontSize = 45;
            TextDown.TextWrapping = TextWrapping.NoWrap;
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (TextDown.Text.Length == 11)
            {
                TextDown.FontSize -= 9;
            }
            if (TextDown.Text.Length == 15)
            {
                TextDown.FontSize -= 7.5;
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
                if (TextUp.Text.Contains('=')|| TextUp.Text.Contains('+') || TextUp.Text.Contains('/') || TextUp.Text.Contains('*'))
                {
                    TextDown.Text = "7";
                }
                else
                {
                    TextDown.Text += "7";
                }              
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
                TextDown.FontSize -= 7.5;
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
                if (TextUp.Text.Contains('=') || TextUp.Text.Contains('+') || TextUp.Text.Contains('/') || TextUp.Text.Contains('*'))
                {
                    TextDown.Text = "8";
                }
                else
                {
                    TextDown.Text += "8";
                }
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
                TextDown.FontSize -= 7.5;
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
                if (TextUp.Text.Contains('=') || TextUp.Text.Contains('+') || TextUp.Text.Contains('/') || TextUp.Text.Contains('*'))
                {
                    TextDown.Text = "9";
                }
                else
                {
                    TextDown.Text += "9";
                }
            }
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (TextDown.Text.Length == 11)
            {
                TextDown.FontSize -= 9;
            }
            if (TextDown.Text.Length == 15)
            {
                TextDown.FontSize -= 7.5;
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
                TextDown.Text = "4";
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
                if (TextUp.Text.Contains('=') || TextUp.Text.Contains('+') || TextUp.Text.Contains('/') || TextUp.Text.Contains('*'))
                {
                    TextDown.Text = "4";
                }
                else
                {
                    TextDown.Text += "4";
                }
            }
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (TextDown.Text.Length == 11)
            {
                TextDown.FontSize -= 9;
            }
            if (TextDown.Text.Length == 15)
            {
                TextDown.FontSize -= 7.5;
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
                TextDown.Text = "5";
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
                if (TextUp.Text.Contains('=') || TextUp.Text.Contains('+') || TextUp.Text.Contains('/') || TextUp.Text.Contains('*'))
                {
                    TextDown.Text = "5";
                }
                else
                {
                    TextDown.Text += "5";
                }
            }
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (TextDown.Text.Length == 11)
            {
                TextDown.FontSize -= 9;
            }
            if (TextDown.Text.Length == 15)
            {
                TextDown.FontSize -= 7.5;
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
                TextDown.Text = "6";
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
                if (TextUp.Text.Contains('=') || TextUp.Text.Contains('+') || TextUp.Text.Contains('/') || TextUp.Text.Contains('*'))
                {
                    TextDown.Text = "6";
                }
                else
                {
                    TextDown.Text += "6";
                }
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (TextDown.Text.Length == 11)
            {
                TextDown.FontSize -= 9;
            }
            if (TextDown.Text.Length == 15)
            {
                TextDown.FontSize -= 7.5;
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
                TextDown.Text = "1";
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
                if (TextUp.Text.Contains('=') || TextUp.Text.Contains('+') || TextUp.Text.Contains('/') || TextUp.Text.Contains('*'))
                {
                    TextDown.Text = "1";
                }
                else
                {
                    TextDown.Text += "1";
                }
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (TextDown.Text.Length == 11)
            {
                TextDown.FontSize -= 9;
            }
            if (TextDown.Text.Length == 15)
            {
                TextDown.FontSize -= 7.5;
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
                TextDown.Text = "2";
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
                if (TextUp.Text.Contains('=') || TextUp.Text.Contains('+') || TextUp.Text.Contains('/') || TextUp.Text.Contains('*'))
                {
                    TextDown.Text = "2";
                }
                else
                {
                    TextDown.Text += "2";
                }
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (TextDown.Text.Length == 11)
            {
                TextDown.FontSize -= 9;
            }
            if (TextDown.Text.Length == 15)
            {
                TextDown.FontSize -= 7.5;
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
                TextDown.Text = "3";
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
                if (TextUp.Text.Contains('=') || TextUp.Text.Contains('+') || TextUp.Text.Contains('/') || TextUp.Text.Contains('*'))
                {
                    TextDown.Text = "3";
                }
                else
                {
                    TextDown.Text += "3";
                }
            }
        }

        private void ButtonDel_Click(object sender, RoutedEventArgs e)
        {
            TextDown.Text = TextDown.Text.Substring(0, TextDown.Text.Length-1);
            if (TextDown.Text.Length == 0)
            {
                TextDown.Text = "0";
            }
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            if (TextUp.Text.Contains('='))
            {
                TextUp.Text = TextDown.Text;
            }
            if (TextUp.Text.Contains('+'))
            {
                var operation = TextUp.Text + TextDown.Text;
                TextDown.Text=MathHelper(operation, '+');
                if (TextDown.Text == "0")
                {
                    TextUp.Text = "";
                }
            } 
            else
            {
                TextUp.Text = TextDown.Text + "+";
            }
        }
        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            if (TextUp.Text.Length>0)
            {
                if (TextUp.Text.Contains('='))
                {
                    TextUp.Text = TextDown.Text;
                }
                var operation = TextUp.Text + TextDown.Text;
                TextDown.Text = MathHelper(operation, TextUp.Text[^1]);
                if (TextDown.Text=="0")
                {
                    TextUp.Text = "";
                }
                else
                {
                    TextUp.Text = operation + "=";
                }
            }            
        }
        private string MathHelper(string CalcText, char key)
        {
            double a, b, res=0.0D;
            int index;
            switch (key)
            {
                case '+':
                    index = CalcText.IndexOf('+');
                    a = Convert.ToDouble(CalcText.Substring(0,CalcText.Length-index+1));
                    b = Convert.ToDouble(CalcText.Substring(index + 1));
                    res = a + b;
                    break;
                case '-':
                    index = CalcText.IndexOf('-');
                    a = Convert.ToDouble(CalcText.Substring(0, CalcText.Length- index+1));
                    b = Convert.ToDouble(CalcText.Substring(index + 1));
                    res = a - b;
                    break;
                case '/':
                    index = CalcText.IndexOf('/');
                    a = Convert.ToDouble(CalcText.Substring(0, CalcText.Length- index+1));
                    b = Convert.ToDouble(CalcText.Substring(index + 1));
                    res = a / b;
                    break;
                case '*':
                    index = CalcText.IndexOf('*');
                    a = Convert.ToDouble(CalcText.Substring(0, CalcText.Length - index+1));
                    b = Convert.ToDouble(CalcText.Substring(index + 1));
                    res = a * b;
                    break;
            }
            return res.ToString();
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            if (TextDown.Text.Length == 11)
            {
                TextDown.FontSize -= 9;
            }
            if (TextDown.Text.Length == 15)
            {
                TextDown.FontSize -= 7.5;
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
                TextDown.Text = "0";
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
                if (TextUp.Text.Contains('=') || TextUp.Text.Contains('+') || TextUp.Text.Contains('/') || TextUp.Text.Contains('*'))
                {
                    TextDown.Text = "0";
                }
                else
                {
                    TextDown.Text += "0";
                }
            }
        }
    }
}
