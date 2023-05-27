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

namespace PrakLaba6Zad2
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
            int f(int x) 
            {
                if (x % 5 == 0)
                {
                    return x / 5;
                }
                else
                {
                    return x + 1;
                }
            }

            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);

            txt3.Text = ($"f({a}) = {f(a)}");
            txt4.Text = ($"f({b}) = {f(b)}");
        }
    }
}
