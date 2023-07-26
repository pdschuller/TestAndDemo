namespace MauiApp1;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(PageTwo), typeof(PageTwo));
        Routing.RegisterRoute(nameof(ToDosPage), typeof(ToDosPage));
        Routing.RegisterRoute(nameof(HomeMenu), typeof(HomeMenu));
        Routing.RegisterRoute(nameof(But2Page), typeof(But2Page));
        Routing.RegisterRoute(nameof(But3Page), typeof(But3Page));
        Routing.RegisterRoute(nameof(But4Page), typeof(But4Page));
        Routing.RegisterRoute(nameof(But2Sub), typeof(But2Sub));
        Routing.RegisterRoute(nameof(But2SubSub), typeof(But2SubSub));
    }
}
