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

namespace projekt1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        double wzrost;
        double waga;
        double wynik;
        double zaokraglenie;

        void Button_Click(object sender, RoutedEventArgs e)
        {
        
            wzrost = double.Parse(TXBWZR.Text);
            waga = double.Parse(TXBWAGA.Text);
            wynik = (waga/(wzrost*wzrost))*10000;
           
            zaokraglenie = Math.Round(wynik, MidpointRounding.AwayFromZero);

          
            MessageBox.Show(zaokraglenie.ToString()+ " BMI");

        }

        private void KobietaBT_Checked(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
