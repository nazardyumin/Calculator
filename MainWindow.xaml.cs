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
            if (PeripheralText.Contains('=')) PeripheralText = "";
            MainText = "0";
            TextDown.FontSize = 45;
            TextDown.TextWrapping = TextWrapping.NoWrap;
            memory = false;
        }

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            MainText = "0";
            PeripheralText = "";
            TextDown.FontSize = 45;
            TextDown.TextWrapping = TextWrapping.NoWrap;
            memory = false;
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {           
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
                PeripheralText = MainText + "+";
                memory = false;
                return;
            }
            if (PeripheralText.Contains('+'))
            {
                if (MainText == "0")
                {
                    MainText = PeripheralText.Remove(PeripheralText.Length - 1, 1);
                    return;
                }                   
                var operation = PeripheralText + MainText;
                MainText = MathHelper(operation, '+');
                PeripheralText = MainText + "+";
                memory = false;
            } 
            else
            {
                if (MainText.Length > 0 && PeripheralText.Length > 0)
                {
                    var operation = PeripheralText + MainText;
                    PeripheralText = MathHelper(operation, PeripheralText[^1]) + "+";
                    memory = false;
                }
                else
                {
                    PeripheralText = MainText + "+";
                    memory = false;
                }              
            }
        }
        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            if (MainText == "0")
            {
                PeripheralText = "0-";
                return;
            }
            if (PeripheralText.Contains('='))
            {
                PeripheralText = MainText + "-";
                memory = false;
                return;
            }
            if (PeripheralText.Contains('-'))
            {
                var operation = PeripheralText + MainText;
                MainText = MathHelper(operation, '-');
                PeripheralText = MainText + "-";
                memory = false;
            }
            else
            {
                if (MainText.Length > 0 && PeripheralText.Length > 0)
                {
                    var operation = PeripheralText + MainText;
                    PeripheralText = MathHelper(operation, PeripheralText[^1]) + "-";
                    memory = false;
                }
                else
                {
                    PeripheralText = MainText + "-";
                    memory = false;
                }
            }
        }
        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (PeripheralText.Contains('='))
            {
                PeripheralText = MainText + "*";
                memory = false;
                return;
            }
            if (PeripheralText.Contains('*'))
            {
                if (MainText == "0")
                {
                    MainText = PeripheralText.Remove(PeripheralText.Length - 1, 1);
                    return;
                }
                var operation = PeripheralText + MainText;
                MainText = MathHelper(operation, '*');
                PeripheralText = MainText + "*";
                memory = false;
            }
            else
            {
                if (MainText.Length > 0 && PeripheralText.Length > 0)
                {
                    var operation = PeripheralText + MainText;
                    PeripheralText = MathHelper(operation, PeripheralText[^1]) + "*";
                    memory = false;
                }
                else
                {
                    PeripheralText = MainText + "*";
                    memory = false;
                }
            }
        }
        private void ButtonDevide_Click(object sender, RoutedEventArgs e)
        {
            if (MainText == "0") return;
            if (PeripheralText.Contains('='))
            {
                PeripheralText = MainText + "/";
                memory = false;
                return;
            }
            if (PeripheralText.Contains('/'))
            {
                var operation = PeripheralText + MainText;
                MainText = MathHelper(operation, '/');
                PeripheralText = MainText + "/";
                memory = false;
            }
            else
            {
                if (MainText.Length > 0 && PeripheralText.Length > 0)
                {
                    var operation = PeripheralText + MainText;
                    PeripheralText = MathHelper(operation, PeripheralText[^1]) + "/";
                    memory = false;
                }
                else
                {
                    PeripheralText = MainText + "/";
                    memory = false;
                }
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
                    index = CalcText.LastIndexOf('-');
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
            int i;
            int j = 0;
            if (text.Contains(','))
            {
                i = text.IndexOf(',')-1;
                textWithSpaces=text.Substring(i+1);
            }
            else
            {
                i = text.Length - 1;
            }
            for (; i >= 0; i--)
            {
                if (j % 3 == 0 && j != 0)
                {
                    textWithSpaces = textWithSpaces.Insert(0, " ");
                }
                textWithSpaces = textWithSpaces.Insert(0, text[i].ToString());
                j++;
            }           
            if (textWithSpaces.Length >0 && textWithSpaces.Length<=11)
            {
                TextDown.FontSize=45;
            }
            else if (textWithSpaces.Length > 11 && textWithSpaces.Length <= 13)
            {
                TextDown.FontSize = 39;
            }
            else if (textWithSpaces.Length > 13 && textWithSpaces.Length <= 15)
            {
                TextDown.FontSize = 33;
            }
            else if (textWithSpaces.Length > 15 && textWithSpaces.Length <= 20)
            {
                TextDown.FontSize = 27;
            }
            else if (textWithSpaces.Length > 20 && textWithSpaces.Length <= 30)
            {
                TextDown.FontSize = 21;
                TextDown.TextWrapping = TextWrapping.WrapWithOverflow;
            }           
            return textWithSpaces;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ButtonComma_Click(object sender, RoutedEventArgs e)
        {
            if (!MainText.Contains(','))
            {
                MainText += ",";
            }          
        }   
    }
}
