using Microsoft.Maui;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Hosting;

namespace HelloMaui
{
    public class Startup : IStartup
    {
        public void Configure(IAppHostBuilder appBuilder)
        {
            appBuilder
                .RegisterCompatibilityRenderers()
                .ConfigureFonts((hostingContext, fonts) =>
				{
					fonts.AddFont("ionicons.ttf", "IonIcons");
					fonts.AddFont("digitaldismay.otf", "DigitalDismay");
				})
                .UseMauiApp<Application>();
        }
    }

}