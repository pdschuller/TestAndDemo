namespace MauiApp1;

public partial class HomeMenu : ContentPage
{
	public HomeMenu()
	{
		InitializeComponent();
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