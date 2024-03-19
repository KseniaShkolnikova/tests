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
using System.Windows.Shapes;

namespace tesiki
{
    /// <summary>
    /// Логика взаимодействия для gg.xaml
    /// </summary>
    public partial class gg : Window
    {
        bool avtor1;
        public gg(bool avtor)
        {
            InitializeComponent();
            if (avtor==false) 
            {
                change.IsEnabled = false;
            }
            else if (avtor == true)
            {
                change.IsEnabled = true;
            }
            avtor1 = avtor;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<zadania> zadanias = Ser_Desir.Desir<List<zadania>>("testaa.json") ?? new List<zadania>() ?? new List<zadania>();
            if (zadanias.Count > 0)
            {
                PageFrame.Content = new prohod();
            }
            else
            {
                PageFrame.Content = new netu();
            }
            
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
            if (avtor1 == false)
            {
                change.IsEnabled = false;
            }
            else if (avtor1 == true)
            {
                change.IsEnabled = true;
            }
        }

        private void change_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new redaktor();
        }
    }
}
