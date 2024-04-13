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
using tesiki.ViewModel;

namespace tesiki.View
{
    /// <summary>
    /// Логика взаимодействия для gg2.xaml
    /// </summary>
    public partial class gg2 : Window
    {
        public gg2()
        {
            InitializeComponent();
            DataContext= new gg2ViewModel(PageFrame);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            Close();
        }

    }
}
