using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using tesiki.Model;
using tesiki.ViewModel.Helpers;


namespace tesiki.ViewModel
{
    internal class redactorViewModel : BindingHelpers
    {
        ObservableCollection<zadania> zadaniaList = Ser_Desir.Desir<ObservableCollection<zadania>>("testaa.json") ?? new ObservableCollection<zadania>();
        private ObservableCollection<zadania> zadaniass = new ObservableCollection<zadania>();
        public BindableCommand AddItem { get; set; }
        public ObservableCollection<zadania> Zadanias
        {
            get { return zadaniass; }
            set { zadaniass = value; OnPropertyChanged(); }
        }
        public redactorViewModel()
        {
            Zadanias = new ObservableCollection<zadania>(zadaniaList);
            AddItem = new BindableCommand(_ => dobav());
        }

        private void dobav()
        {
            zadaniaList.Add(new zadania("Название вопроса", "Описание вопроса", "0", "0", "0", "0"));
            Ser_Desir.Serialize(zadaniaList, "testaa.json");
            Zadanias = new ObservableCollection<zadania>(zadaniaList);
        }

        private void Gridik_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Ser_Desir.Serialize(zadaniaList, "testaa.json");
        }
    }
}
