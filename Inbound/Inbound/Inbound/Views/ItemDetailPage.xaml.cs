using Inbound.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Inbound.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}