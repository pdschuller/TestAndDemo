namespace MauiApp1;

public partial class But2Sub : ContentPage
{
	public But2Sub()
	{
		InitializeComponent();
	}

    // THIS IS BUT 2 SUB PAGE
    private void GoToBut2Page_Clicked(object sender, EventArgs e)
    {
		// AppShell.Current.GoToAsync("..");
        AppShell.Current.GoToAsync("But2Page");
    }
    private void GoToSubSub_Clicked(object sender, EventArgs e)
    {
        AppShell.Current.GoToAsync("But2SubSub");
    }
}