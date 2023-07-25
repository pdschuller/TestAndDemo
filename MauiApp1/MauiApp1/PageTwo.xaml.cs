using MauiApp1.ViewModels;

namespace MauiApp1;

[QueryProperty("ThePageTwoItem", "TheItem")]

public partial class PageTwo : ContentPage
{
    string thePageTwoItem = string.Empty;
    MainViewModel vm;
    public string ThePageTwoItem
    {
        get
        { 
            return thePageTwoItem;
        }
        set
        {
            thePageTwoItem = Uri.UnescapeDataString(value ?? string.Empty);
            string MatchingStringFromCollection = vm.myCollection
                            .Where(x => x == ThePageTwoItem).FirstOrDefault();
            vm.myText = MatchingStringFromCollection;
        }
    }

	public PageTwo(MainViewModel _vm)
    { 
        InitializeComponent();
        string ff = ThePageTwoItem;
        string ff2 = thePageTwoItem;
        // thePageTwoItem = Uri.UnescapeDataString(value);
        BindingContext = vm = _vm;        

        string tt = ThePageTwoItem;
	}
    private void GoBack_Clicked(object sender, EventArgs e)
    {
        AppShell.Current.GoToAsync("..");
    }
}