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

namespace TestNěmec
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

        private void Jet(object sender, RoutedEventArgs e)
        {

        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            int m = 0;
            try
            {
                m = int.Parse(Distance.Text);
                Distance.Text = m.ToString();
            }
            catch
            {
                Distance.Text += 10;
            }
        }

        private void plusko_Click(object sender, RoutedEventArgs e)
        {
            int m = 0;
            try
            {
                m = int.Parse(Distance.Text);
                Distance.Text = m.ToString();
            }
            catch
            {
                Distance.Text += 20;
            }
        }
    }
}
