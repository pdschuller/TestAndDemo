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
        private void SealPage_Esc(object sender, EventArgs e)
        {
            // await Shell.Current.GoToAsync("../");
            Shell.Current.GoToAsync("//LoginPage");
        }
        private void SealPage_Ok(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(ScanPage));
        }
        //private void SealPage_ViaRoute(object sender, EventArgs e)
        //{
        //    Shell.Current.GoToAsync("//LoginPage");
        //    // throws relative route excep await Shell.Current.GoToAsync(nameof(LoginPage));
        //}
    }
}