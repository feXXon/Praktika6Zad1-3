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

namespace PrakLaba6Zad1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double f(double x)
            {
                return Math.Pow(x, 3) - Math.Sin(x);
            }

            double a = 0;
            double b = Math.PI;

            double fa = f(a);
            double fb = f(b);

            if (fa > fb)
            {
                txt1.Text = ($"Функция f(x) принимает наибольшее значение в точке a: {fa}");
            }
            else
            {
                txt1.Text = ($"Функция f(x) принимает наибольшее значение в точке b: {fb}");
            }
        }
    }
}
