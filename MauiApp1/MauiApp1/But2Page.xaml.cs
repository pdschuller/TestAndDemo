namespace MauiApp1;

public partial class But2Page : ContentPage
{
	public But2Page()
	{
		InitializeComponent();
	}
	// THIS IS BUT 2 PAGE =====================================
    private void GoBackButton_Clicked(object sender, EventArgs e)
    {
		// AppShell.Current.GoToAsync("..");
        AppShell.Current.GoToAsync("//HomeMenu");
    }
    private void GoBut2Sub_Clicked(object sender, EventArgs e)
    {
        AppShell.Current.GoToAsync("But2Sub");
    }
    private void GoBut2SubSub_Clicked(object sender, EventArgs e)
    {
        AppShell.Current.GoToAsync("But2Sub/But2SubSub");
    }
}