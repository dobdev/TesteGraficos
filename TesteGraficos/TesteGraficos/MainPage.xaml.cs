using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TesteGraficos
{
    public partial class MainPage : ContentPage
    {
        OxyExData Model { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Model = new OxyExData();
            
            BindingContext = Model;
        }
    }
}
