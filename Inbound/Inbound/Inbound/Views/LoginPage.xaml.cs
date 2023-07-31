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
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
        private void DoLogin(object sender, EventArgs e)
        {
            AppShell.Current.GoToAsync("TrailerSealPage");
            // Shell.Current.GoToAsync("TrailerSealPage");
        }
    }
}