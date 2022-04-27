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
        ConsigneeListAdapter ad;
        View ScreenOneUi;
        ListView lv;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            glb = (MainActivity)mListener;
            wsCalls = new WsCalls();
        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            ScreenOneUi = inflater.Inflate(Resource.Layout.ScreenOne, container, false);
            // we dont await here and let the method return ScreenOne when it wants.
            // Then the View is ready when the data is available to populate it
            PopulateConsigneesList(ScreenOneUi);
            lv = ScreenOneUi.FindViewById<ListView>(Resource.Id.orders_listview);
            return ScreenOneUi;
        }
        private async Task PopulateConsigneesList(View screenOneUi)
        {
            DaysConsignees = await wsCalls.GetCustomConsignees(new DateTime(2021, 9, 27));
            DaysConsigneesListView = screenOneUi.FindViewById<ListView>(Resource.Id.consignees_listview);
            ad = new ConsigneeListAdapter(Activity, DaysConsignees, glb);
            DaysConsigneesListView.Adapter = ad;
            DaysConsigneesListView.KeyPress += DaysConsigneesListView_KeyPress;
        }
        private void DaysConsigneesListView_KeyPress(object sender, View.KeyEventArgs e)
        {
            if (e.KeyCode == Keycode.Enter)
            {
                ad.ConsigneeItem_Click(sender, null);
            }
            else
            {
                e.Handled = false;
            }
        }
        public async void PopulateOrdersList(string wmsCode)
        {
            List<WmsOrderForUi> WmsOrders =
                    await(Task<List<WmsOrderForUi>>)wsCalls.GetWmsOrders(new DateTime(2021, 9, 27), wmsCode);
            // ListView lv = ScreenOneUi.FindViewById<ListView>(Resource.Id.orders_listview);
            OrdersListAdapter oad = new OrdersListAdapter(Activity, WmsOrders);
            lv.Adapter = oad;
            lv.RefreshDrawableState();
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