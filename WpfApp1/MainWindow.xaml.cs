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

namespace WpfApp1
{

    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        void BTN9_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double w = Convert.ToDouble(TBy8.Text);
                double y = Convert.ToDouble(TBt2.Text);
                MessageBox.Show($"V = {Math.Pow((y + 2 * w), 3) / Math.Log10(y + 0.75)}");


            }
            catch
            {
                MessageBox.Show("Ошибка ", "задание 1.9",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
        }
    }
}