using System;
using System.IO;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using SQLite;
using SQLitePCL;
// using Mono. .Android.Data.Sqlite;

namespace SQLiteDemo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;
            Button MyButton = FindViewById<Button>(Resource.Id.button1);
            MyButton.Click += MyButton_Click;
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Creating database, if it doesn't already exist");
            string dbPath = Path.Combine(
                    System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),
                    "ormdemo.db3");
            var db = new SQLiteConnection(dbPath);
            db.CreateTable<Stock>();
            if (db.Table<Stock>().Count() == 0)
            {
                // only insert the data if it doesn't already exist
                var newStock = new Stock();
                newStock.Symbol = "AAPL";
                db.Insert(newStock);
                newStock = new Stock();
                newStock.Symbol = "GOOG";
                db.Insert(newStock);
                newStock = new Stock();
                newStock.Symbol = "MSFT";
                db.Insert(newStock);
            }
            Console.WriteLine("Reading data");
            var table = db.Table<Stock>();
            foreach (var s in table)
            {
                Console.WriteLine(s.Id + " " + s.Symbol);
            }
            


        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
	}


    [Table("Items")]
    public class Stock
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        [MaxLength(8)]
        public string Symbol { get; set; }
    }

}

