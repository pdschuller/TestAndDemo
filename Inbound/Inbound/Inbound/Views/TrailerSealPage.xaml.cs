using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inbound.Views
{
    public partial class TrailerSealPage : ContentPage
    {
        // [XamlCompilation(XamlCompilationOptions.Compile)]
        public TrailerSealPage()
        {
            InitializeComponent();
        }

        private async void SealPage_Esc(object sender, EventArgs e)
        {
            // await Shell.Current.GoToAsync(nameof(LoginPage));
            await Shell.Current.GoToAsync("../");
        }
    }
}