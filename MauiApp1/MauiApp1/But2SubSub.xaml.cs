namespace MauiApp1;

public partial class But2SubSub : ContentPage
{
	public But2SubSub()
	{
		InitializeComponent();
	}
    // THIS IS BUT 2 SUB SUB PAGE
    private void GoBut2Sub_Clicked(object sender, EventArgs e)
    {
        // AppShell.Current.GoToAsync("..");
        AppShell.Current.GoToAsync("But2Sub");
    }
    private void GoHomeButton_Clicked(object sender, EventArgs e)
    {
        // AppShell.Current.GoToAsync("../..");
        // AppShell.Current.GoToAsync("HomeMenu");
        // AppShell.Current.GoToAsync("//HomeMenu");
        AppShell.Current.GoToAsync("snot");
    }
}