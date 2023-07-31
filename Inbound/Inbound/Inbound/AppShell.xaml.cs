using Inbound.ViewModels;
using Inbound.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Inbound
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));

            Routing.RegisterRoute(nameof(TrailerSealPage), typeof(TrailerSealPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));

            ShellContent sc = new ShellContent();
            // Shell.Current.GoToAsync(nameof(LoginPage));
            sc.Content = new LoginPage();
        }

    }
}
