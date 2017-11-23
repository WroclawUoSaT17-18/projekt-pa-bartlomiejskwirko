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
        int charCount = 0;

       

        double wzrost;
        double waga;
        double wynik;
        double bmi;



        void Button_Click(object sender, RoutedEventArgs e)
        {
            
             
                try
                {
                    wzrost = double.Parse(TXBWZR.Text);
                    waga = double.Parse(TXBWAGA.Text);
                    wynik = (waga / (wzrost * wzrost)) * 10000;

                    bmi = Math.Round(wynik, MidpointRounding.AwayFromZero);
                }
                catch (FormatException)//podana wartosc nie jest cyrfra
                {
                    MessageBox.Show("zly format");
                }
                catch (OverflowException)//za duza liczba
                {
                    MessageBox.Show("Podales za duze liczby");
                }
                catch (ArithmeticException)
                {

                    MessageBox.Show("podzieliles przez 0");
                }
            if (KobietaBT.IsChecked == true)
            { 
                if (bmi >= 24)
                        {
                        MessageBox.Show("Dla Kobiety " + bmi.ToString() + " BMI" + " jest za duże - masz nadwagę");
                        }

                else if (bmi <= 17)
                        {

                    MessageBox.Show("Dla Kobiety " + bmi.ToString() + " BMI" + " jest za małe - masz niedowagę");
                        }

                else
                        {
                    MessageBox.Show("Dla Kobiety " + bmi.ToString() + " BMI" + " jest w normie.");
                         }
                
            }
                else if(KobietaBT.IsChecked == false && MezczyznaBT.IsChecked == false)
                    {
                MessageBox.Show("Wybierz płeć!");
                    }
                    
                    else if(MezczyznaBT.IsChecked == true)
                            {
                if (bmi >= 26)
                {
                    MessageBox.Show("Dla mężczyzny " + bmi.ToString() + " BMI" + " jest za duże - masz nadwagę");
                }

                else if (bmi <= 16)
                {

                    MessageBox.Show("Dla mężczyzny " + bmi.ToString() + " BMI" + " jest za małe - masz niedowagę");
                }

                else
                {
                    MessageBox.Show("Dla mężczyzny " + bmi.ToString() + " BMI" + " jest w normie.");
                }
            }
        }

        
    }
}
