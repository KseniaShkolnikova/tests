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
    internal class gg2ViewModel : BindingHelpers
    {
        public BindableCommand AddCommand { get; set; }
        private Frame pageFrame;

        public gg2ViewModel(Frame frame)
        {
            pageFrame = frame;
            AddCommand = new BindableCommand(_ => vigruzka());
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

    }
   
}
