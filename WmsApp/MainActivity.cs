using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.BottomNavigation;
using WmsApp.Screens;

namespace WmsApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class MainActivity : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        public ScreenOne screenOne;
        public ScreenTwo screenTwo;
        public ScreenThree screenThree;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            screenOne = new ScreenOne();
            screenTwo = new ScreenTwo();
            screenThree = new ScreenThree();
            SetContentView(Resource.Layout.activity_main);

            BottomNavigationView navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            navigation.SetOnNavigationItemSelectedListener(this);
            LoadFragment(Resource.Id.navigation_home);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        public bool OnNavigationItemSelected(IMenuItem item)
        {

            bool NavResult = LoadFragment(item.ItemId);
            if (NavResult)
            {
                item.SetChecked(true);
            }
            return NavResult;
        }
        public bool LoadFragment(int id)
        {
            Fragment fragment = null;
            switch (id)
            {
                case Resource.Id.navigation_home:
                    // textMessage.SetText(Resource.String.title_home);
                    fragment = screenOne;
                    break;
                case Resource.Id.navigation_dashboard:
                    fragment = screenTwo;
                    break;
                case Resource.Id.navigation_notifications:
                    fragment = screenThree;
                    break;
            }
            if (fragment == null)
            {
                return false;
            }

            FragmentTransaction frag_transaction = FragmentManager.BeginTransaction();
            // next value helps us monitor the user's navigation
            // frag_transaction.AddToBackStack(fragment.ToString().Substring(0, 5));
            frag_transaction.Replace(Resource.Id.main_screen_content, fragment);
            frag_transaction.Commit();
            return true;
        }
    }
}

