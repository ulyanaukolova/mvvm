using MVVM.Model;
using MVVM.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModel
{
    internal class MainViewModel: BindingHelper
    {
        private Polz dan;

        public Polz Dan
        {
            get { return dan; }
            set
            {
                dan = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Polz> polzs;

        public ObservableCollection<Polz> Polzs
        {
            get { return polzs; }
            set { polzs = value; OnPropertyChanged(); }
        }

        public MainViewModel()
        {
            Polzs = new ObservableCollection<Polz>()
            {
                new Polz("KS", "127.0.0.0"),
                new Polz("Ulyasha", "26.85.79.42")
            };
        }
    }
}
