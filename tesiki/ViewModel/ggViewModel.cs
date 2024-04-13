using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using tesiki.Model;
using tesiki.ViewModel.Helpers;

namespace tesiki.ViewModel 
{
    internal class ggViewModel : BindingHelpers
    {
        public BindableCommand AddCommand { get; set; }
        public BindableCommand IzmenCommand { get; set; }

        private Frame pageFrame;

        public ggViewModel(Frame frame)
        {
            pageFrame = frame;
            AddCommand = new BindableCommand(_ => vigruzka());
            IzmenCommand = new BindableCommand (_  => izmin());
        }
        private void vigruzka()
        {
            List<zadania> zadanias = Ser_Desir.Desir<List<zadania>>("testaa.json") ?? new List<zadania>();
            if (zadanias.Count > 0)
            {
                pageFrame.Content = new prohod();
            }
            else
            {
                pageFrame.Content = new netu();
            }
        }
        private void izmin()
        {
            pageFrame.Content = new redaktor();
        }

    }
}
