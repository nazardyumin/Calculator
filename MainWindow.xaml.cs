using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;

namespace Calculator
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private bool memory;
        private string? _mainText;
        private string? _peripheralText;
        public string MainTextToScreen
        {
            get => AddSpaces(MainText);
        }
        public string MainText
        {
            get => _mainText!;
            set
            {
                if (_mainText == value) return;
                _mainText = value;
                OnPropertyChanged(nameof(MainText));
                OnPropertyChanged(nameof(MainTextToScreen));
            }
        }
        public string PeripheralText
        {
            get => _peripheralText!;
            set
            {
                if (_peripheralText == value)
                {
                    return;
                }
                _peripheralText = value;
                OnPropertyChanged(nameof(PeripheralText));
            }
        }
        public MainWindow()
        {
            MainText = "0";
            PeripheralText = "";
            memory = false;
            InitializeComponent();
        }

        private void ButtonCE_Click(object sender, RoutedEventArgs e)
        {
            PeripheralText = "";
            MainText = "0";
            TextDown.FontSize = 45;
            TextDown.TextWrapping = TextWrapping.NoWrap;
        }

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            MainText = "0";
            TextDown.FontSize = 45;
            TextDown.TextWrapping = TextWrapping.NoWrap;
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (MainTextToScreen.Length == 11)
            {
                TextDown.FontSize -= 9;
            }
            if (MainTextToScreen.Length == 15)
            {
                TextDown.FontSize -= 7.5;
            }
            if (MainTextToScreen.Length == 19)
            {
                TextDown.FontSize -= 5;
            }
            if (MainTextToScreen.Length == 23)
            {
                TextDown.FontSize -= 3.5;
            }
            if (MainTextToScreen.Length >= 27)
            {
                TextDown.TextWrapping = TextWrapping.WrapWithOverflow;
            }
            if (MainTextToScreen.Length == 54)
            {
                TextDown.FontSize -= 3;
            }
            if (MainTextToScreen.Length == 95)
            {
                TextDown.FontSize -= 4;
            }
            if (MainText == "0")
            {
                MainText = "7";
            }
            else
            {
                if (PeripheralText.Length>0 && !memory)
                {
                    MainText = "";
                    MainText += "7";
                    memory = true;
                }
                else
                {
                    MainText += "7";
                }              
            }     
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (MainTextToScreen.Length == 11)
            {
                TextDown.FontSize -= 9;
            }
            if (MainTextToScreen.Length == 15)
            {
                TextDown.FontSize -= 7.5;
            }
            if (MainTextToScreen.Length == 19)
            {
                TextDown.FontSize -= 5;
            }
            if (MainTextToScreen.Length == 23)
            {
                TextDown.FontSize -= 3.5;
            }
            if (MainTextToScreen.Length >= 27)
            {
                TextDown.TextWrapping = TextWrapping.WrapWithOverflow;
            }
            if (MainTextToScreen.Length == 54)
            {
                TextDown.FontSize -= 3;
            }
            if (MainTextToScreen.Length == 95)
            {
                TextDown.FontSize -= 4;
            }
            if (MainText == "0")
            {
                MainText = "8";
            }
            else
            {
                if (PeripheralText.Length > 0 && !memory)
                {
                    MainText = "";
                    MainText += "8";
                    memory = true;
                }
                else
                {
                    MainText += "8";
                }
            }
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (MainTextToScreen.Length == 11)
            {
                TextDown.FontSize -= 9;
            }
            if (MainTextToScreen.Length == 15)
            {
                TextDown.FontSize -= 7.5;
            }
            if (MainTextToScreen.Length == 19)
            {
                TextDown.FontSize -= 5;
            }
            if (MainTextToScreen.Length == 23)
            {
                TextDown.FontSize -= 3.5;
            }
            if (MainTextToScreen.Length >= 27)
            {
                TextDown.TextWrapping = TextWrapping.WrapWithOverflow;
            }
            if (MainTextToScreen.Length == 54)
            {
                TextDown.FontSize -= 3;
            }
            if (MainTextToScreen.Length == 95)
            {
                TextDown.FontSize -= 4;
            }
            if (MainText == "0")
            {
                MainText = "9";
            }
            else
            {
                if (PeripheralText.Length > 0 && !memory)
                {
                    MainText = "";
                    MainText += "9";
                    memory = true;
                }
                else
                {
                    MainText += "9";
                }
            }
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (MainTextToScreen.Length == 11)
            {
                TextDown.FontSize -= 9;
            }
            if (MainTextToScreen.Length == 15)
            {
                TextDown.FontSize -= 7.5;
            }
            if (MainTextToScreen.Length == 19)
            {
                TextDown.FontSize -= 5;
            }
            if (MainTextToScreen.Length == 23)
            {
                TextDown.FontSize -= 3.5;
            }
            if (MainTextToScreen.Length >= 27)
            {
                TextDown.TextWrapping = TextWrapping.WrapWithOverflow;
            }
            if (MainTextToScreen.Length == 54)
            {
                TextDown.FontSize -= 3;
            }
            if (MainTextToScreen.Length == 95)
            {
                TextDown.FontSize -= 4;
            }
            if (MainText == "0")
            {
                MainText = "4";
            }
            else
            {
                if (PeripheralText.Length > 0 && !memory)
                {
                    MainText = "";
                    MainText += "4";
                    memory = true;
                }
                else
                {
                    MainText += "4";
                }
            }
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (MainTextToScreen.Length == 11)
            {
                TextDown.FontSize -= 9;
            }
            if (MainTextToScreen.Length == 15)
            {
                TextDown.FontSize -= 7.5;
            }
            if (MainTextToScreen.Length == 19)
            {
                TextDown.FontSize -= 5;
            }
            if (MainTextToScreen.Length == 23)
            {
                TextDown.FontSize -= 3.5;
            }
            if (MainTextToScreen.Length >= 27)
            {
                TextDown.TextWrapping = TextWrapping.WrapWithOverflow;
            }
            if (MainTextToScreen.Length == 54)
            {
                TextDown.FontSize -= 3;
            }
            if (MainTextToScreen.Length == 95)
            {
                TextDown.FontSize -= 4;
            }
            if (MainText == "0")
            {
                MainText = "5";
            }
            else
            {
                if (PeripheralText.Length > 0 && !memory)
                {
                    MainText = "";
                    MainText += "5";
                    memory = true;
                }
                else
                {
                    MainText += "5";
                }
            }
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (MainTextToScreen.Length == 11)
            {
                TextDown.FontSize -= 9;
            }
            if (MainTextToScreen.Length == 15)
            {
                TextDown.FontSize -= 7.5;
            }
            if (MainTextToScreen.Length == 19)
            {
                TextDown.FontSize -= 5;
            }
            if (MainTextToScreen.Length == 23)
            {
                TextDown.FontSize -= 3.5;
            }
            if (MainTextToScreen.Length >= 27)
            {
                TextDown.TextWrapping = TextWrapping.WrapWithOverflow;
            }
            if (MainTextToScreen.Length == 54)
            {
                TextDown.FontSize -= 3;
            }
            if (MainTextToScreen.Length == 95)
            {
                TextDown.FontSize -= 4;
            }
            if (MainText == "0")
            {
                MainText = "6";
            }
            else
            {
                if (PeripheralText.Length > 0 && !memory)
                {
                    MainText = "";
                    MainText += "6";
                    memory = true;
                }
                else
                {
                    MainText += "6";
                }
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (MainTextToScreen.Length == 11)
            {
                TextDown.FontSize -= 9;
            }
            if (MainTextToScreen.Length == 15)
            {
                TextDown.FontSize -= 7.5;
            }
            if (MainTextToScreen.Length == 19)
            {
                TextDown.FontSize -= 5;
            }
            if (MainTextToScreen.Length == 23)
            {
                TextDown.FontSize -= 3.5;
            }
            if (MainTextToScreen.Length >= 27)
            {
                TextDown.TextWrapping = TextWrapping.WrapWithOverflow;
            }
            if (MainTextToScreen.Length == 54)
            {
                TextDown.FontSize -= 3;
            }
            if (MainTextToScreen.Length == 95)
            {
                TextDown.FontSize -= 4;
            }
            if (MainText == "0")
            {
                MainText = "1";
            }
            else
            {
                if (PeripheralText.Length > 0 && !memory)
                {
                    MainText = "";
                    MainText += "1";
                    memory = true;
                }
                else
                {
                    MainText += "1";
                }
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (MainTextToScreen.Length == 11)
            {
                TextDown.FontSize -= 9;
            }
            if (MainTextToScreen.Length == 15)
            {
                TextDown.FontSize -= 7.5;
            }
            if (MainTextToScreen.Length == 19)
            {
                TextDown.FontSize -= 5;
            }
            if (MainTextToScreen.Length == 23)
            {
                TextDown.FontSize -= 3.5;
            }
            if (MainTextToScreen.Length >= 27)
            {
                TextDown.TextWrapping = TextWrapping.WrapWithOverflow;
            }
            if (MainTextToScreen.Length == 54)
            {
                TextDown.FontSize -= 3;
            }
            if (MainTextToScreen.Length == 95)
            {
                TextDown.FontSize -= 4;
            }
            if (MainText == "0")
            {
                MainText = "2";
            }
            else
            {
                if (PeripheralText.Length > 0 && !memory)
                {
                    MainText = "";
                    MainText += "2";
                    memory = true;
                }
                else
                {
                    MainText += "2";
                }
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (MainTextToScreen.Length == 11)
            {
                TextDown.FontSize -= 9;
            }
            if (MainTextToScreen.Length == 15)
            {
                TextDown.FontSize -= 7.5;
            }
            if (MainTextToScreen.Length == 19)
            {
                TextDown.FontSize -= 5;
            }
            if (MainTextToScreen.Length == 23)
            {
                TextDown.FontSize -= 3.5;
            }
            if (MainTextToScreen.Length >= 27)
            {
                TextDown.TextWrapping = TextWrapping.WrapWithOverflow;
            }
            if (MainTextToScreen.Length == 54)
            {
                TextDown.FontSize -= 3;
            }
            if (MainTextToScreen.Length == 95)
            {
                TextDown.FontSize -= 4;
            }
            if (MainText == "0")
            {
                MainText = "3";
            }
            else
            {
                if (PeripheralText.Length > 0 && !memory)
                {
                    MainText = "";
                    MainText += "3";
                    memory = true;
                }
                else
                {
                    MainText += "3";
                }
            }
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            if (MainTextToScreen.Length == 11)
            {
                TextDown.FontSize -= 9;
            }
            if (MainTextToScreen.Length == 15)
            {
                TextDown.FontSize -= 7.5;
            }
            if (MainTextToScreen.Length == 19)
            {
                TextDown.FontSize -= 5;
            }
            if (MainTextToScreen.Length == 23)
            {
                TextDown.FontSize -= 3.5;
            }
            if (MainTextToScreen.Length >= 27)
            {
                TextDown.TextWrapping = TextWrapping.WrapWithOverflow;
            }
            if (MainTextToScreen.Length == 54)
            {
                TextDown.FontSize -= 3;
            }
            if (MainTextToScreen.Length == 95)
            {
                TextDown.FontSize -= 4;
            }
            if (MainText == "0")
            {
                MainText = "0";
            }
            else
            {
                if (PeripheralText.Length > 0 && !memory)
                {
                    MainText = "";
                    MainText += "0";
                    memory = true;
                }
                else
                {
                    MainText += "0";
                }
            }
        }

        private void ButtonDel_Click(object sender, RoutedEventArgs e)
        {
            MainText = MainText.Substring(0, MainText.Length-1);
            if (MainText.Length == 0)
            {
                MainText = "0";
            }
        }
        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            if (PeripheralText.Contains('='))
            {
                PeripheralText = MainText;
                memory = false;
            }
            if (PeripheralText.Contains('+'))
            {
                var operation = PeripheralText + MainText;
                MainText = MathHelper(operation, '+');
                PeripheralText = MainText + "+";
                if (MainText == "0")
                {
                    PeripheralText = "";                   
                }
                memory = false;
            } 
            else
            {
                PeripheralText = MainText + "+";
                memory = false;
            }
        }
        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            if (PeripheralText.Length>0)
            {
                if (PeripheralText.Contains('='))
                {
                    PeripheralText = MainText;
                    memory = false;
                }
                var operation = PeripheralText + MainText;
                MainText = MathHelper(operation, PeripheralText[^1]);               
                if (MainText == "0")
                {
                    PeripheralText = "";
                    memory = false;
                }
                else
                {
                    PeripheralText = operation + "=";
                    memory = false;
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
                    a = Convert.ToDouble(CalcText.Substring(0,index));
                    b = Convert.ToDouble(CalcText.Substring(index + 1));
                    res = a + b;
                    break;
                case '-':
                    index = CalcText.IndexOf('-');
                    a = Convert.ToDouble(CalcText.Substring(0,index));
                    b = Convert.ToDouble(CalcText.Substring(index + 1));
                    res = a - b;
                    break;
                case '/':
                    index = CalcText.IndexOf('/');
                    a = Convert.ToDouble(CalcText.Substring(0,index));
                    b = Convert.ToDouble(CalcText.Substring(index + 1));
                    res = a / b;
                    break;
                case '*':
                    index = CalcText.IndexOf('*');
                    a = Convert.ToDouble(CalcText.Substring(0,index));
                    b = Convert.ToDouble(CalcText.Substring(index + 1));
                    res = a * b;
                    break;
            }
            return res.ToString();
        }

        private string AddSpaces(string text)
        {
            string textWithSpaces = "";
            int j = 0;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                if (j % 3 == 0 && j != 0)
                {
                    textWithSpaces = textWithSpaces.Insert(0, " ");
                }
                textWithSpaces = textWithSpaces.Insert(0, text[i].ToString());
                j++;
            }
            return textWithSpaces;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
