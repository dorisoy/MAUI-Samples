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
            if (hello != null)
            {
                label.Text = hello.Hello();
            }
            else
            {
                label.Text = "Cannot create IHelloService";
            }
        }
    }
}
