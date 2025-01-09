using MauiZebraScan.Interfaces;
using MauiZebraScan.Models;
using Microsoft.Extensions.DependencyInjection;

namespace MauiZebraScan
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.Services.AddTransient<IScannerConfig, ZebraScannerConfig>();
            // builder.Services.AddTransient<IScanner_Android, Scanner_Android>();
#if ANDROID
            builder.Services.AddTransient<IScannerConfig, ZebraScannerConfig>();

            builder.Services.AddTransient<IScanner_Android, Scanner_Android>();
#endif

            return builder.Build();
        }
    }
}
