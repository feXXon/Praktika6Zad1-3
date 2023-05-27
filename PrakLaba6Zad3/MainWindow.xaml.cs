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

namespace PrakLaba6Zad3
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
            double CircleS(double R)
            {
                double pi = 3.14;
                return pi * R * R;
            }

            double r1 = double.Parse(txt1.Text);
            double r2 = double.Parse(txt2.Text);
            double r3 = double.Parse(txt3.Text);

            double s1 = CircleS(r1);
            double s2 = CircleS(r2);
            double s3 = CircleS(r3);

            txt4.Text = ($"{s1}");
            txt5.Text = ($"{s2}");
            txt6.Text = ($"{s3}");
        }
    }
}
