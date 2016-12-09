using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace CenterBug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new DummyViewModel();
        }
    }

    public class DummyViewModel
    {
        public ICommand AddMoreCommand { get; set; }
        public ObservableCollection<DummyItems> ListViewItems { get; set; }

        public DummyViewModel()
        {
            ListViewItems = new ObservableCollection<DummyItems>();
            for (int i = 0; i < 500; i++)
            {
                ListViewItems.Add(new DummyItems() { PropA = $"A {i}" });
            }

            AddMoreCommand = new Command(() =>
            {
                ListViewItems.Insert(0, new DummyItems() { PropA = "New!" });
            });

        }
    }

    public class DummyItems
    {
        public string PropA { get; set; }
    }
}
