namespace MauiApp1;

public partial class HomeMenu : ContentPage
{
	public HomeMenu()
	{
		InitializeComponent();
	}

    private void MainPageButtonClicked(object sender, EventArgs e)
    {
		AppShell.Current.GoToAsync("MainPage");
    }
}