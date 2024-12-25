using System;
using System.ComponentModel.DataAnnotations;
using System.Windows;
using System.Windows.Threading;

namespace Prakticheskaia12
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

        private void btZadanie1_Click(object sender, RoutedEventArgs e)
        {
            Zadanie1 zadanie1 = new Zadanie1();
            bool boolKatet1 = int.TryParse(tbKatet1.Text, out int katet1);
            bool boolKatet2 = int.TryParse(tbKatet2.Text, out int katet2);
            if (boolKatet1 || boolKatet2)
            {
                zadanie1.SetParams(katet1, katet2);
                double result = zadanie1.Gipotenyza();
                tbResult.Text = Convert.ToString(result);
                tbKatet1.Focus();
            }
            else MessageBox.Show("Что то не так");
        }

        private void btZadanie2_Click(object sender, RoutedEventArgs e)
        {
            Zadanie2 zadanie2 = new Zadanie2();
            bool boolChislo = int.TryParse(tbChislo.Text, out int chislo);
            if (boolChislo)
            {
                zadanie2.SetParams(chislo);
                double result = zadanie2.RazradSoten();
                tbResult2.Text = Convert.ToString(result);
                tbChislo.Focus();
            }
            else MessageBox.Show("Что то точнно не так");
        }

        private void btInfo(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Информация");
        }

        private void btExit(object sender, RoutedEventArgs e)
        {
            Close();
        }
        DispatcherTimer timer;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 1);
            timer.IsEnabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            time.Text = d.ToString("HH:mm");
            data.Text = d.ToString("dd.MM.yyyy");
        }
        private void Katet_Changed(object sender, EventArgs e)
        {
            tbResult.Text = "";
        }
        private void Chislo_Changed(object sender, EventArgs e)
        {
            tbResult2.Text = "";
        }
    }
}