using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using calculator.Models;

namespace BinCalc.Views
{
    public class BinCalculator : UserControl
    {
        private TextBox MainStrokaMathOperation;
        private TextBox TempStrokaForOperation;
        private string FirstNum = null;
        private string SecondNum = null;
        private string Operation = null;
        public BinCalculator()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            MainStrokaMathOperation = this.FindControl<TextBox>("MainStrokaMathOperation");
            MainStrokaMathOperation.Text = "";
            TempStrokaForOperation = this.FindControl<TextBox>("TempStrokaForOperation");
            TempStrokaForOperation.Text = "";
        }

        private void ButtonClickOnClear(object sender, RoutedEventArgs e)
        {
            MainStrokaMathOperation.Text = "";
            TempStrokaForOperation.Text = "";
        }
        
        private void ButtonClickOnResult(object sender, RoutedEventArgs e)
        {
            if (MainStrokaMathOperation.Text != "" && TempStrokaForOperation.Text != "")
            {
                SecondNum = MainStrokaMathOperation.Text;
                MainStrokaMathOperation.Text = BinaryMathematics.Calc(FirstNum, SecondNum, Operation);
                FirstNum = MainStrokaMathOperation.Text;
                Operation = null;
                TempStrokaForOperation.Text = ""; 
            }
        }
        
        private void ButtonClickOnOperation(object sender, RoutedEventArgs e)
        {
     
            if (MainStrokaMathOperation.Text != "")
            {
                if (TempStrokaForOperation.Text != "")
                {
                    SecondNum = MainStrokaMathOperation.Text;
                    MainStrokaMathOperation.Text = BinaryMathematics.Calc(FirstNum, SecondNum, Operation);
                }
            
                var ThisButton = (Button) sender;
                Operation = ThisButton.Content.ToString();

                FirstNum = MainStrokaMathOperation.Text;
                MainStrokaMathOperation.Text = "";

                TempStrokaForOperation.Text = FirstNum + Operation;
            }
            
        }
        
        private void ButtonClickOnInversiya(object sender, RoutedEventArgs e)
        {
            if(MainStrokaMathOperation.Text != "")
                MainStrokaMathOperation.Text = BinaryMathematics.Inversiya(MainStrokaMathOperation.Text);
        }
        
        private void ButtonClickOnNum(object sender, RoutedEventArgs e)
        {
            var ThisButton = (Button) sender;
            MainStrokaMathOperation.Text = ThisButton.Content.ToString() + MainStrokaMathOperation.Text;
        }
    }
}

// ++  -- ** 