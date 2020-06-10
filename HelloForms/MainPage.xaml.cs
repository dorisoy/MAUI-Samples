using System;
using SatelliteAssemblyTest;
using Xamarin.Forms;

namespace HelloForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            label.Text = new TextGetter().GetText();
        }
    }
}
