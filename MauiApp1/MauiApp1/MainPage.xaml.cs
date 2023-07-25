using MauiApp1.ViewModels;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    MainViewModel vm;

    public MainPage(MainViewModel _vm)
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
        vm.DeleteItem((sender as SwipeItem).CommandParameter.ToString());   
    }

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var dd = sender;
        CollectionView cv = (CollectionView)sender;
        var tt = cv.SelectedItem;
    }
}

