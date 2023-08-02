using Inbound.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inbound.ModalViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CloseUrModal : ContentPage
	{
		public CloseUrModal ()
		{
			InitializeComponent ();
            // turn off back button at top left of screen
            Shell.SetBackButtonBehavior(this, new BackButtonBehavior
            {
                IsEnabled = false
            });
        }
        protected override bool OnBackButtonPressed()
        {
            // this works for Android back button that is off the screen at the bottom
            // but NOT for the back button in the top left corner of the screen
            Device.BeginInvokeOnMainThread(async () =>
            { });
            return true;
        }
        private void CloseThisModal(object sender, EventArgs e)
        {
			Shell.Current.GoToAsync(nameof(ScanPage));
        }
    }
}