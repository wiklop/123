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

namespace BiuroPodrozy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Podroz planNaPodroz = new Podroz();

        public MainWindow()
        {
            InitializeComponent();
            panelAutobus.Visibility = Visibility.Hidden;
            panelPociag.Visibility = Visibility.Hidden;
            panelSprawdzenieDaty.Visibility = Visibility.Hidden;
        }

        private void buttonAutobus_Click(object sender, RoutedEventArgs e)
        {
            panelAutobus.Visibility = Visibility.Visible;
            panelPociag.Visibility = Visibility.Hidden;
            panelSprawdzenieDaty.Visibility = Visibility.Hidden;
        }

        private void buttonPociag_Click(object sender, RoutedEventArgs e)
        {
            panelAutobus.Visibility = Visibility.Hidden;
            panelPociag.Visibility = Visibility.Visible;
            panelSprawdzenieDaty.Visibility = Visibility.Hidden;
        }

        private void buttonUstawDate_Click(object sender, RoutedEventArgs e)
        {
            panelAutobus.Visibility = Visibility.Hidden;
            panelPociag.Visibility = Visibility.Hidden;
            panelSprawdzenieDaty.Visibility = Visibility.Visible;
        }

        private void buttonUsunOstatni_Click(object sender, RoutedEventArgs e)
        {
            planNaPodroz.UsunOstatni();
             textblockPlanPodrozy.Text = planNaPodroz.ToString();
             
            
        }

        private void buttonWyczysc_Click(object sender, RoutedEventArgs e)
        {
            planNaPodroz.Wyczysc();
            textblockPlanPodrozy.Text = planNaPodroz.ToString();
           
        }

        private void buttonDodajAutobus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int liczbaMiejsc = int.Parse(textboxMiejscaAutobus.Text);
                if (liczbaMiejsc <= 0) throw new ArgumentOutOfRangeException();
                planNaPodroz.DodajAutobus(liczbaMiejsc);
                textblockPlanPodrozy.Text = planNaPodroz.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDodajPociag_Click(object sender, RoutedEventArgs e)
        {
             try
            {
                int liczbaMiejsc = int.Parse(textboxMiejscaPociag.Text);
                int dlugoscTrasy = int.Parse(textboxDlugoscTrasy.Text);
                if (liczbaMiejsc <= 0) throw new ArgumentOutOfRangeException();
                if (dlugoscTrasy <= 0) throw new ArgumentOutOfRangeException();
                planNaPodroz.DodajPociag(liczbaMiejsc, dlugoscTrasy);

                textblockPlanPodrozy.Text = planNaPodroz.ToString();
            }
            catch
            {
                MessageBox.Show("Oj! Któraś z podanych liczb jest niepoprawna!");
            }
        }

        private void buttonSprawdzDate_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
