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
		}
        private void CloseThisModal(object sender, EventArgs e)
        {
			Shell.Current.GoToAsync(nameof(ScanPage));
        }
    }
}