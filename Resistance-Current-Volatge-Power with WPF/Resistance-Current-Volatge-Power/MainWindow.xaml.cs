//Navid-Derakhshandeh
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

namespace Resistance_Current_Volatge_Power
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (Calc.SelectedIndex)
            {
                case 0:
                    Resistance();
                    break;
                case 1:
                    Current();
                    break;
                case 2:
                    Volatge();
                    break;
                case 3:
                    Power();
                    break;
            }
        }
        public void Resistance()
        {
            double x = double.Parse(Value1.Text);
            double y = Double.Parse(Value2.Text);
            Result.Content = (x / y).ToString();
        }
        public void Current()
        {
            double x = Double.Parse(Value1.Text);
            double y = Double.Parse(Value2.Text);
            Result.Content = (x / y).ToString();
        }
        public void Volatge()
        {
            double x = Double.Parse(Value1.Text);
            double y = Double.Parse(Value2.Text);
            Result.Content = (x * y).ToString();
        }
        public void Power()
        {
            double x = Double.Parse(Value1.Text);
            double y = Double.Parse(Value2.Text);
            Result.Content = (x * y).ToString();
        }
    }
}
