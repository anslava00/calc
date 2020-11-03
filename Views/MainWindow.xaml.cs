using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace calculator.Views
{
    public class MainWindow : Window
    {
        private UserControl Def_calc;
        private UserControl Bin_calc;
        public MainWindow()
        {
            InitializeComponent();
            Def_calc = this.FindControl<UserControl>("DefCalculator");
            Bin_calc = this.FindControl<UserControl>("BinCalculator");
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void Button_click_show_DefCalc(object sender, RoutedEventArgs e)
        {
            Def_calc.IsVisible = true;
            Bin_calc.IsVisible = false;
        }
        
        private void Button_click_show_BinCalc(object sender, RoutedEventArgs e)
        {
            Def_calc.IsVisible = false;
            Bin_calc.IsVisible = true;
        }
    }
}