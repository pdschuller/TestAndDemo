using System;
using System.Collections.Generic;
// using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PL
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // works  DataTable dt = new DataTable();
            // this is wrongly trying to use a namespace like a type
            // System.Data.SqlClient pp = new System.Data.SqlClient();
        }
    }
}
