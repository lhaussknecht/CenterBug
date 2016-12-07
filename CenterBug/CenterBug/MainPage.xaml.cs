using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

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
        public IList<DummyItems> ListViewItems { get; set; }

        public DummyViewModel()
        {
            ListViewItems = new List<DummyItems>();
            for (int i = 0; i < 50; i++)
            {
                ListViewItems.Add(new DummyItems() { PropA = $"A {i}" });
            }

        }
    }

    public class DummyItems
    {
        public string PropA { get; set; }
    }
}
