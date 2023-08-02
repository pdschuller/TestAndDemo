using Inbound.ModalViews;
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
    public partial class ScanPage : ContentPage
    {
        public ScanPage()
        {
            InitializeComponent();
        }
        private void GoToLogin(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//LoginPage");
        }
        private void CloseUrClick(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(CloseUrModal));
        }
    }
}