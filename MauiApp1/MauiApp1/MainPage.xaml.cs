﻿using MauiApp1.ViewModels;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

    //public MainPage(MainViewModel vm)
    //{
    //	InitializeComponent();
    //	BindingContext = vm;
    //}
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel();
    }

}

