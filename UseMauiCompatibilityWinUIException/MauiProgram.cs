using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace UseMauiCompatibilityWinUIException;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder()
            // remove the below line to fix the project
            .UseMauiCompatibility();

        builder.UsePrism(
            (a) =>
            {
                a
                    .RegisterTypes(c =>
                    {
                        c.RegisterForNavigation<MainPage>();
                    })
                    .OnAppStart((c, n) =>
                    {
                        n.NavigateAsync("MainPage");
                    });
            });

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        return builder.Build();
    }
}
