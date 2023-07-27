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
//#if __ANDROID__
//		builder.ConfigureMauiHandlers(collection =>
//			{
//				handlers.AddCompatibilityRenderer(typeof(HomeMenu), typeof(MauiApp1.Platforms.Android.HomeMenuPageRenderer));
//			});
//#endif


        //			collection =>
        //            {
        //// #if __ANDROID__
        //            handlers.AddHandler(typeof(HomeMenu), typeof(HomeMenuPageRenderer));
        //// #endif
        //            });


        // handlers.AddHandler(typeof(HomeMenu), typeof(HomeMenuPageRenderer)));


        // next we register our viewmodel and page with the dependency service
        // so that we can inject them into our page like public ToDosPage(MainViewModel _vm)
        // and PageTwo(MainViewModel _vm)
        builder.Services.AddSingleton<ToDosPage>();
		builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddTransient<PageTwo>();
        // builder.Services.AddTransient<PageTwoViewModel>();

        return builder.Build();
	}
}
