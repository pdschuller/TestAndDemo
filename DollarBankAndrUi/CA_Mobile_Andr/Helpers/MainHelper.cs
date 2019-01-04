using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
//using TabsApp.Fragments;
using Android.Support.Design.Widget;
using CA_Mobile_Andr.Fragments;
using Android.Support.V4.App;

namespace CA_Mobile_Andr.Helpers
{
    public class MainHelper
    {
        public void LoadFragment(int id)
        {
            // pds: 1-1-19 - this is not working
            Android.Support.V4.App.Fragment fragment = null;
            switch (id)
            {
                case Resource.Id.menu_home:
                    fragment = Fragment1.NewInstance();
                    break;
                case Resource.Id.menu_audio:
                    fragment = Fragment2.NewInstance();
                    break;
                case Resource.Id.menu_video:
                    fragment = Fragment3.NewInstance();
                    break;
                case Resource.Id.menu_approvals:
                    fragment = ApprovalsFrag.NewInstance();
                    break;
            }
            if (fragment == null)
                return;

            var ff = new FragmentActivity();
            ff.SupportFragmentManager.BeginTransaction()
               .Replace(Resource.Id.content_frame, fragment)
               .Commit();
        }

    }
}