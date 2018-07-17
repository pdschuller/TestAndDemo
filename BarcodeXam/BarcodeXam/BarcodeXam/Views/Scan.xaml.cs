using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BarcodeXam.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Scan : ContentPage
	{
		public Scan ()
		{
			InitializeComponent ();
		}

        private void ScanClicked(object sender, EventArgs e)
        {

        }

        async void List(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListPage());
        }

        private void About(object sender, EventArgs e)
        {

        }
    }
}