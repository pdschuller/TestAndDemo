using MauiApp1.ViewModels;

namespace MauiApp1;

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
        // next we register our viewmodel and page with the dependency service
        // so that we can inject them into our page like public MainPage(MainViewModel _vm)
		// and PageTwo(MainViewModel _vm)
        builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddTransient<PageTwo>();
        // builder.Services.AddTransient<PageTwoViewModel>();

        return builder.Build();
	}
}
