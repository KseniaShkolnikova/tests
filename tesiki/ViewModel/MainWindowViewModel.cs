using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using tesiki.ViewModel.Helpers;
using System.Windows.Documents;
using tesiki.View;

namespace tesiki.ViewModel
{
    internal class MainWindowViewModel : BindingHelpers
    {
        private string password = "";
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged();
            }
        }
        public BindableCommand RegisterCommand { get; set; }
        public BindableCommand ProxodCommand { get; set; }  
        public MainWindowViewModel()
        {
            RegisterCommand = new BindableCommand(_ => ShowWindow());
            ProxodCommand = new BindableCommand(_ => proxod());
        }
        private void proxod()
        {
            gg2 gg2 = new gg2();
            gg2.Show();
            Application.Current.Windows.OfType<MainWindow>().First().Close();
        }
        private void ShowWindow()
        {
            if (Password == "tt")
            {
                gg gg = new gg();
                gg.Show();
                Application.Current.Windows.OfType<MainWindow>().First().Close();
            }
        }
    }
}
