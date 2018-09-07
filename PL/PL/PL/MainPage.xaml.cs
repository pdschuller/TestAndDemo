using PL.PalletLoadedDataSetTableAdapters;
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
            
        }

        private void DisplayItems(object sender, EventArgs e)
        {
            ClientBarcodeTypeTableAdapter adpt = new ClientBarcodeTypeTableAdapter();            
            adpt.Connection = new SqlConnection(@"Data Source = PHIL_PC\SQLEXPRESS2017; Initial Catalog = wjbeitler; Integrated Security = True");
                                //                Data Source = PHIL_PC\SQLEXPRESS2017; Initial Catalog = wjbeitler; Integrated Security = True
            // adpt.Connection.ConnectionString = @"Data Source=PHIL_PC\SQLEXPRESS2017;Initial Catalog=wjbeitler;Integrated Security=True";
            // adpt.Connection.ConnectionString = @"Data Source=PHIL_PC\SQLEXPRESS2017;user id=sa;password=qweqwe101622;Initial Catalog=wjbeitler";
            //                                   Data Source={SQL_INSTANCE_NAME};user id={SQL_USERNAME};password={SQL_PASS};Initial Catalog={DB:NAME};
            //                                   data source={server_address};initial catalog={database_name};user id={user_id};password={password};Connect Timeout={seconds}
            // keyword not supported   adpt.Connection.ConnectionString = @"PHIL_PC\SQLEXPRESS2017;Initial Catalog=wjbeitler;Integrated Security=True";

            try
            {
                // BcTypesListView.ItemsSource = PalletLoadedDataSet.ClientBarcodeTypeDataTable;  // adpt.GetData();
                adpt.Connection.Open();
                BcTypesListView.ItemsSource = adpt.GetData();
                adpt.Connection.Close();
            }
            catch (Exception exp)
            {
                adpt.Connection.Close();
                var r = exp;
            }
        }
    }
}
