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
        public ObservableCollection<DummyItem> ListViewItems { get; set; }

        public DummyViewModel()
        {
            ListViewItems = new ObservableCollection<DummyItem>();
            for (int i = 0; i < 500; i++)
            {
                ListViewItems.Add(new DummyItem() { PropA = $"A {i}" });
            }

            AddMoreCommand = new Command(() =>
            {
                ListViewItems.Insert(0, new DummyItem() { PropA = "New!" });
            });

        }
    }

    public class DummyItem
    {
        public string PropA { get; set; }
    }
}
