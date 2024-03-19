using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using static System.Net.Mime.MediaTypeNames;

namespace tesiki
{
    /// <summary>
    /// Логика взаимодействия для redaktor.xaml
    /// </summary>
    public partial class redaktor : Page 
    {
        List<zadania> zadanias = Ser_Desir.Desir<List<zadania>>("testaa.json") ?? new List<zadania>() ?? new List<zadania>();
        public redaktor()
        {
            InitializeComponent();
            Gridik.ItemsSource = zadanias;
        }

        private void dobav_Click(object sender, RoutedEventArgs e)
        {
            Gridik.ItemsSource = null;
            zadanias.Add(new zadania("Название вопроса","Описание вопроса","0","0","0",Enum.odin));
            Ser_Desir.Serialize(zadanias, "testaa.json");
            Gridik.ItemsSource = zadanias;
            
        }

        private void Gridik_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {           
            Ser_Desir.Serialize(zadanias, "testaa.json");           
        }
    }
}
