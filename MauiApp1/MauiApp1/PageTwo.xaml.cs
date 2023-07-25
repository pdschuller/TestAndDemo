using MauiApp1.ViewModels;

namespace MauiApp1;

public partial class PageTwo : ContentPage
{

	public PageTwo(MainViewModel _vm)
    { 
        InitializeComponent();
        BindingContext = _vm;        
	}
    private void GoBack_Clicked(object sender, EventArgs e)
    {
        AppShell.Current.GoToAsync("..");
    }
}