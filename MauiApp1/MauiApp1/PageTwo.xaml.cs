using MauiApp1.ViewModels;

namespace MauiApp1;

public partial class PageTwo : ContentPage
{

	public PageTwo()
    {   // PageTwoViewModel _vm
        InitializeComponent();
	}
    private void GoBack_Clicked(object sender, EventArgs e)
    {
        AppShell.Current.GoToAsync("..");
    }
}