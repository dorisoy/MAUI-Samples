using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Extensions.DependencyInjection;

namespace HelloMaui
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage, IPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
	}
}
