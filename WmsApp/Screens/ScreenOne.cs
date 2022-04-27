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
        ConsigneeListAdapter ConListAdapter;
        OrdersListAdapter OrdersListAdapter;
        View ScreenOneUi;
        ListView OrdersListView;
        TextView ScreenOneTitle;
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
            OrdersListView = ScreenOneUi.FindViewById<ListView>(Resource.Id.orders_listview);
            View OrdListHeader = inflater.Inflate(Resource.Layout.orders_list_header, null);
            OrdersListView.AddHeaderView(OrdListHeader);
            OrdersListView.KeyPress += OrdersListView_KeyPress;
            ScreenOneTitle = ScreenOneUi.FindViewById<TextView>(Resource.Id.screen_one_title);
            return ScreenOneUi;
        }
        private async Task PopulateConsigneesList(View screenOneUi)
        {
            DaysConsignees = await wsCalls.GetCustomConsignees(new DateTime(2021, 9, 27));
            DaysConsigneesListView = screenOneUi.FindViewById<ListView>(Resource.Id.consignees_listview);
            ConListAdapter = new ConsigneeListAdapter(Activity, DaysConsignees, glb);
            DaysConsigneesListView.Adapter = ConListAdapter;
            DaysConsigneesListView.KeyPress += DaysConsigneesListView_KeyPress;
        }
        private void OrdersListView_KeyPress(object sender, View.KeyEventArgs e)
        {
            if (e.KeyCode == Keycode.Enter)
            {
                var rr = sender;
                ListView lv = sender as ListView;
                View dd = lv.SelectedView;           // lv.Adapter;
                LinearLayout OrdersRow = (LinearLayout)dd;
                CheckBox OrdersCheckBox = OrdersRow.FindViewById<CheckBox>(Resource.Id.select_order_checkbox);
                OrdersCheckBox.Checked = true;

                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        private void DaysConsigneesListView_KeyPress(object sender, View.KeyEventArgs e)
        {
            if (e.KeyCode == Keycode.Enter)
            {
                ConListAdapter.ConsigneeItem_Click(sender, null);
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
            OrdersListAdapter = new OrdersListAdapter(Activity, WmsOrders);
            OrdersListView.Adapter = OrdersListAdapter;
            OrdersListView.RefreshDrawableState();
            ScreenOneTitle.Text = "ORDERS";
            DaysConsigneesListView.Visibility = ViewStates.Gone;
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