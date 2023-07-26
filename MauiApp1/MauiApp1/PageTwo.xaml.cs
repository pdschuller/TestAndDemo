using MauiApp1.Models;
using MauiApp1.ViewModels;

namespace MauiApp1;

[QueryProperty("PageTwoToDoId", "TheItem")]

public partial class PageTwo : ContentPage
{
    // int thePageTwoItem;
    MainViewModel vm;
    public string PageTwoToDoId
    {
        set
        {
            string theId = Uri.UnescapeDataString(value ?? string.Empty);
            int intId = Convert.ToInt32(theId);
            ToDoItem MatchingToDoFromCollection = vm.myCollection
                            .Where(x => x.Id == intId).FirstOrDefault();
            vm.SelectedToDo = MatchingToDoFromCollection;
        }
    }
	public PageTwo(MainViewModel _vm)
    { 
        InitializeComponent();
        vm = _vm;
        BindingContext = vm;        
	}
    private void GoBack_Clicked(object sender, EventArgs e)
    {
        AppShell.Current.GoToAsync("..");
    }
}