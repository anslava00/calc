using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Сalculator.Models;

namespace DefaultСalc.Views
{
    public class DefaultСalculator : UserControl
    {
        private TextBox MainStrokaMathOperation;
        private TextBox TempStrokaForOperation;
        private float FirstNum = 0;
        private float SecondNum = 0;
        private string TypeOperation = null;
        public DefaultСalculator()
        {
            InitializeComponent();
            
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            MainStrokaMathOperation = this.FindControl<TextBox>("MainStrokaMathOperation");
            TempStrokaForOperation = this.FindControl<TextBox>("TempStrokaForOperation");
            MainStrokaMathOperation.Text = "";
            TempStrokaForOperation.Text = "";
        }

        private void ButtonClickOnResult(object sender, RoutedEventArgs e)
        {
            if (MainStrokaMathOperation.Text != "" && TempStrokaForOperation.Text != "" &&
                MainStrokaMathOperation.Text != ",")
            {
                SecondNum = float.Parse(MainStrokaMathOperation.Text);
                MainStrokaMathOperation.Text = Mathematics.Calc(FirstNum, SecondNum, TypeOperation);
                FirstNum = float.Parse(MainStrokaMathOperation.Text);
                TypeOperation = null;
                TempStrokaForOperation.Text = ""; 
            }
        }

        private void ButtonClickOnOperation(object sender, RoutedEventArgs e)
        {
            if (MainStrokaMathOperation.Text != "" && MainStrokaMathOperation.Text != ",")
            {
                if (TempStrokaForOperation.Text != "")
                {
                    MainStrokaMathOperation.Text = Mathematics.Calc(FirstNum, 
                                                                    float.Parse(MainStrokaMathOperation.Text),
                                                                            TypeOperation);
                }
                
                var ThisButton = (Button) sender;
                TypeOperation = ThisButton.Content.ToString();

                FirstNum = float.Parse(MainStrokaMathOperation.Text);
                MainStrokaMathOperation.Text = "";

                TempStrokaForOperation.Text = FirstNum.ToString() + TypeOperation;
            }
        }

        private void ButtonClickOnClear(object sender, RoutedEventArgs e)
        {
            MainStrokaMathOperation.Text = "";
            TempStrokaForOperation.Text = "";
            FirstNum = 0;
            SecondNum = 0;
            TypeOperation = null;
        }

        private void ButtonClickOnSymbolDel(object sender, RoutedEventArgs e)
        {
            if (MainStrokaMathOperation.Text != "")
            {
                MainStrokaMathOperation.Text =
                    MainStrokaMathOperation.Text.Remove(MainStrokaMathOperation.Text.Length - 1, 1);
                if (MainStrokaMathOperation.Text == "-") MainStrokaMathOperation.Text = "";
            }
        }

        private void ButtonClickOnPoint(object sender, RoutedEventArgs e)
        {
            if (MainStrokaMathOperation.Text.IndexOf(',') == -1)
            {
                var ThisButton = (Button) sender;
                MainStrokaMathOperation.Text += ThisButton.Content.ToString();
                
            }
        }
        
        private void ButtonClickOnNum(object sender, RoutedEventArgs e)
        {
            var ThisButton = (Button) sender;
            if (ThisButton.Content.ToString() == "0" && MainStrokaMathOperation.Text == "")
                return;
            MainStrokaMathOperation.Text += ThisButton.Content.ToString();
        }

        private void ButtonClickOnZnak(object sender, RoutedEventArgs e)
        {
            if (MainStrokaMathOperation.Text != "" && MainStrokaMathOperation.Text != ",") 
                if (MainStrokaMathOperation.Text[0] == '-')
                {
                    MainStrokaMathOperation.Text = MainStrokaMathOperation.Text.Remove(0, 1);
                }
                else
                {
                    MainStrokaMathOperation.Text = "-" + MainStrokaMathOperation.Text;
                }
        }
        
    }
}