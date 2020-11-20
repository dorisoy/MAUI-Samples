using System;
using Xamarin.Forms;

namespace HelloForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var hello = DependencyService.Get<IHelloService>();
            label.Text = hello.Hello();
        }
    }
}
