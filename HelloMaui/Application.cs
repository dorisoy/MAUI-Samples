using Microsoft.Maui;

namespace HelloMaui
{
	public class Application : IApplication
	{
		public IWindow CreateWindow(IActivationState state)
		{
			Microsoft.Maui.Controls.Compatibility.Forms.Init(state);
			return new MainWindow();
		}
	}
}