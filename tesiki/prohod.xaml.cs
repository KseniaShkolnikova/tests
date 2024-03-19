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

namespace tesiki
{
    /// <summary>
    /// Логика взаимодействия для prohod.xaml
    /// </summary>
    public partial class prohod : Page
    {
        List<zadania> zadanias = Ser_Desir.Desir<List<zadania>>("testaa.json") ?? new List<zadania>() ?? new List<zadania>();
        int i = 0;
        int prav = 0;
        
        private void vivod()
        {
            Name.Text = zadanias[i].Name;
            Opic.Text = zadanias[i].Opic;
            odin.Content = zadanias[i]._1Var;
            dva.Content = zadanias[i]._2Var;
            tri.Content = zadanias[i]._3Var;
        }
        public prohod()
        {
            InitializeComponent();
            vivod();
        }

        private void _1var_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Name == zadanias[i].Pravil.ToString())
            {
                prav++;
            }
            i++;
            if (i > zadanias.Count-1)
            {
                Name.Text = "Ты прошел тест";
                Opic.Text = $"Ты набрал {prav} правильных ответов из {i} вопросов ";
                odin.Content = null;
                dva.Content = null;
                tri.Content = null;
                odin.IsEnabled = false;
                dva.IsEnabled = false;
                tri.IsEnabled = false;
            }
            else
            {
                vivod();
            }            
        }
    }
}
