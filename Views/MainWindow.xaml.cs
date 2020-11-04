using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Сalculator.Views
{
    public class MainWindow : Window
    {
        private UserControl DefaultCalc;
        private UserControl BinaryCalc;
        public MainWindow()
        {
            InitializeComponent();
            DefaultCalc = this.FindControl<UserControl>("DefaultCalculator");
            BinaryCalc = this.FindControl<UserControl>("BinCalculator");
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void Button_click_show_DefCalc(object sender, RoutedEventArgs e)
        {
            DefaultCalc.IsVisible = true;
            BinaryCalc.IsVisible = false;
        }
        
        private void Button_click_show_BinCalc(object sender, RoutedEventArgs e)
        {
            DefaultCalc.IsVisible = false;
            BinaryCalc.IsVisible = true;
        }
    }
}