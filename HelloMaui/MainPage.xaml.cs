using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.AspNetCore.Components.WebView.Maui;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HelloMaui
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage, IPage
	{
		public MainPage()
		{
	       // Configure services
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddBlazorWebView();
            Resources.Add("services", serviceCollection.BuildServiceProvider());

			InitializeComponent();
		}
	}
}
