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
        Kamion Scania;

        public MainWindow()
        {
            InitializeComponent();

            Scania = new Kamion();
            Scania.Jmeno = "I V E C O";
            Zobraz(Scania, );

        }

        public void Zobraz(Kamion nakladak, TextBox textBox)
        {
            textBox.Text = nakladak.Jmeno + "\n";
            textBox.Text += "Nosnost v kg: " + nakladak.Nosnost.ToString() + "\n";
            textBox.Text += "Palivo v l: " + nakladak.Palivo.ToString() + "\n";
            textBox.Text += "Spotřeba xl/100km: " + nakladak.Spotreba.ToString() + "\n";
            textBox.Text += "Vzdálenost: " + nakladak.Vzdalenost.ToString() + "\n";
            textBox.Text += "Náklad: " + nakladak.Naklad.ToString() + "\n";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Scania.Nalozit();
            Zobraz(Scania, );
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Scania.Vylozit();
            Zobraz(Scania, );
        }

    }
}