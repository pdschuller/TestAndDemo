// using Android;
using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using CA_Mobile_Andr;

namespace CA_Mobile_Andr.Fragments
{
    public class Fragment1 : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
            Button GoToAccountsButton = View.FindViewById<Button>(Resource.Id.go_to_accounts_button);
            GoToAccountsButton.Click += GoToAccountsButton_Click;
        }

        private void GoToAccountsButton_Click(object sender, System.EventArgs e)
        {
            // MainActivity.publicLoadFragment(Resource.Id.menu_audio);

      //      var ff = new FragmentActivity();
      //      var MyFrag = Fragment2.NewInstance();
      //     ff.SupportFragmentManager.BeginTransaction()
      //.Replace(Resource.Id.content_frame, MyFrag)
      //.Commit();

        }

        public static Fragment1 NewInstance()
        {
            var frag1 = new Fragment1 { Arguments = new Bundle() };
            return frag1;
        }


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            return inflater.Inflate(Resource.Layout.fragment1, null);
        }
    }
}