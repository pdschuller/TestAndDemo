using Inbound.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inbound.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            // [XamlCompilation(XamlCompilationOptions.Compile)]
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
        private async void DoLogin(object sender, EventArgs e)
        {
            // Shell.Current.GoToAsync(nameof(TrailerSealPage));
            await Shell.Current.GoToAsync(nameof(TrailerSealPage));
            // NO  Shell.Current.GoToAsync(nameof(AboutPage));
            // next line works
            // Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}");
        }

        private async void DoLogin2(object sender, EventArgs e)
        {
            // AppShell.Current.GoToAsync(nameof(TrailerSealPage))
            // AppShell.Current.GoToAsync(nameof(TrailerSealPage)); ;
            // NO  AppShell.Current.GoToAsync(nameof(AboutPage));
            // next line works
            await Shell.Current.GoToAsync(nameof(ItemDetailPage));
        }
    }
}