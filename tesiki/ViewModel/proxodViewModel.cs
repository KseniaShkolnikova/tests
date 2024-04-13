using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using tesiki.Model;
using tesiki.ViewModel.Helpers;

namespace tesiki.ViewModel
{
    internal class proxodViewModel : BindingHelpers
    {
        private List<zadania> _zadanias;
        public List<zadania> Zadanias
        {
            get { return _zadanias; }
            set { _zadanias = value; OnPropertyChanged(); }
        }
        int i = 0;
        int prav = 0;
        private string _name { get; set; }
        public string Namee
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }
        private string _opic { get; set; }
        public string Opicc
        {
            get { return _opic; }
            set { _opic = value; OnPropertyChanged(); }
        }
        private string _1var { get; set; }
        public string _1Var
        {
            get { return _1var; }
            set { _1var = value; OnPropertyChanged(); }
        }
        private string _2var { get; set; }
        public string _2Var
        {
            get { return _2var; }
            set { _2var = value; OnPropertyChanged(); }
        }
        private string _3var { get; set; }
        public string _3Var
        {
            get { return _3var; }
            set { _3var = value; OnPropertyChanged(); }
        }
        private string _pravil { get; set; }
        public string Pravil
        {
            get { return _pravil; }
            set { _pravil = value; OnPropertyChanged(); }
        }

        public BindableCommand ProxodCommand { get; set; }


        private void vivod()
        {
            Namee = Zadanias[i].Name;
            Opicc = Zadanias[i].Opic;
            _1Var = Zadanias[i]._1Var;
            _2Var = Zadanias[i]._2Var;
            _3Var = Zadanias[i]._3Var;
        }
        public proxodViewModel()
        {
            ProxodCommand = new BindableCommand(param => viv(param as string));

            Zadanias = Ser_Desir.Desir<List<zadania>>("testaa.json") ?? new List<zadania>();
            if (Zadanias.Count > 0)
            {
                vivod();
            }
        }
        public void viv(string buttonname)
        {
            if (buttonname == Zadanias[i].Pravil.ToString())
            {
                prav++;
            }
            i++;

            if (i > Zadanias.Count - 1)
            {
                Namee = "Ты прошел тест";
                Opicc = $"Ты набрал {prav} правильных ответов из {i} вопросов ";
                _1Var = null;
                _2Var = null;
                _3Var = null;
            }
            else
            {
                vivod();
            }
            
        }
    }
}
