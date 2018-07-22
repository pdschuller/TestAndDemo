using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using System;
using ZXing;
using ZXing.Mobile;
using ZXing.Net.Mobile;
using ZXing.Net.Mobile.Android;

namespace BarcodeAndr
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    // public class MainActivity : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    public class MainActivity : AppCompatActivity
    {
        private TextView MyTextView;

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.navigation_home:
                    MyTextView.SetText(Resource.String.title_home);
                    return true;
                case Resource.Id.navigation_dashboard:
                    MyTextView.SetText(Resource.String.title_dashboard);
                    return true;
                case Resource.Id.navigation_notifications:
                    MyTextView.SetText(Resource.String.title_notifications);
                    return true;
            }
            return false;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // next we grab the xaml ... er, I mean the axml ... aka layout
            SetContentView(Resource.Layout.activity_main);
            // wire up the Label; we change its text to match the Avtivity/View that is displayed
            MyTextView = FindViewById<TextView>(Resource.Id.MyTextView);

            //BottomNavigationView navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            //navigation.SetOnNavigationItemSelectedListener(this);
            
            // grab the button
            Button ScanButton = FindViewById<Button>(Resource.Id.ScanButton);
            ScanButton.Click += OpenScannerAsync;
        }
        async void OpenScannerAsync(object sender, EventArgs e)
        {
            // Initialize the scanner first so it can track the current context
            MobileBarcodeScanner.Initialize(Application);

            var scanner = new ZXing.Mobile.MobileBarcodeScanner();

            var result = await scanner.Scan();

            if (result != null)
                Console.WriteLine("Scanned Barcode: " + result.Text);

        }
    }
}

