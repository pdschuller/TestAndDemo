using Microsoft.Maui.Platform;
#if ANDROID
using Android.Views;
#endif


// using Microsoft.Maui.Controls.PlatformConfiguration.Android;

namespace MauiApp1;

public partial class HomeMenu : ContentPage
{
	public HomeMenu()
	{
		InitializeComponent();


//#if ANDROID        
//Microsoft.Maui.Handlers.ViewHandler.ViewMapper.AppendToMapping(nameof(IView.Background), (h, v) =>
//{
//(h.PlatformView as Microsoft.Maui.Controls.PlatformConfiguration.Android.Views.View)
//    .SetBackgroundColor(Microsoft.Maui.Graphics.Colors.Red.ToPlatform());
//});
//#endif



    }

    private void MainPageButtonClicked(object sender, EventArgs e)
    {
		AppShell.Current.GoToAsync("ToDosPage");
    }
    private void Button2Clicked(object sender, EventArgs e)
    {
        AppShell.Current.GoToAsync("But2Page");
    }
    private void Button3Clicked(object sender, EventArgs e)
    {
        AppShell.Current.GoToAsync("But3Page");
    }
    private void Button4Clicked(object sender, EventArgs e)
    {
        AppShell.Current.GoToAsync("But4Page");
    }
}