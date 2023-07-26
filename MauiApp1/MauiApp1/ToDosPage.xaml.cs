using MauiApp1.Models;
using MauiApp1.ViewModels;

namespace MauiApp1;

public partial class ToDosPage : ContentPage
{
    MainViewModel vm;

    public ToDosPage(MainViewModel _vm)
    {
        InitializeComponent();
        BindingContext = _vm;
        vm = _vm;
    }

    private void AddButtonClicked(object sender, EventArgs e)
    {
        vm.PopulateCollection();
    }

    private void SwipeItem_Clicked(object sender, EventArgs e)
    {
        SwipeItem swipeItem = (SwipeItem)sender;
        // vm.DeleteItem(swipeItem.CommandParameter);   
    }

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var dd = sender;
        CollectionView cv = (CollectionView)sender;
        ToDoItem tt = (ToDoItem)cv.SelectedItem;
        vm.NavToPageTwo(tt);
    }
}

