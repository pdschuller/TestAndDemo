using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tlModels;
using WmsApp.Helpers;

namespace WmsApp.Screens
{
    public class ScreenOne : Fragment
    {
        WsCalls wsCalls;
        MainActivity glb;
        List<CustomConsignee> DaysConsignees;
        public ListView DaysConsigneesListView;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            wsCalls = new WsCalls();
        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View ScreenOne = inflater.Inflate(Resource.Layout.ScreenOne, container, false);
            // we dont await her and let the method return ScreenOne when it wants.
            // Then the View is ready when the data is available to populate it
            PopulateConsigneesList(ScreenOne);
            return ScreenOne;
        }
        private async Task PopulateConsigneesList(View ScreenOne)
        {
            DaysConsignees = await wsCalls.GetCustomConsignees(new DateTime(2021, 9, 27));
            DaysConsigneesListView = ScreenOne.FindViewById<ListView>(Resource.Id.consignees_listview);
            ConsigneeListAdapter ad = new ConsigneeListAdapter(Activity, DaysConsignees, glb);
            DaysConsigneesListView.Adapter = ad;
        }
        private OnFragmentInteractionListener mListener;

        public interface OnFragmentInteractionListener
        {      // Android Studio wrote this interface on fragment-create
            void onFragmentInteraction(String llString);  // didn’t need this method
        }

        public override void OnAttach(Context context)
        {
            base.OnAttach(context);  // <<< this has to be there
            if (context is OnFragmentInteractionListener)
            {
                mListener = (OnFragmentInteractionListener)context;
            }
            else
            {
                throw new Exception("must implement OnFragmentInteractionListener");
            }
        }
    }
}