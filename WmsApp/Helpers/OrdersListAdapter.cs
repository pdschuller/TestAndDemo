using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tlModels;

namespace WmsApp.Helpers
{
    internal class OrdersListAdapter : BaseAdapter
    {

        Context context;
        List<WmsOrderForUi> OrdersList;

        public OrdersListAdapter(Context context)
        {
            this.context = context;
        }
        public OrdersListAdapter(Context context, List<WmsOrderForUi> ordersList)
        {
            this.context = context;
            OrdersList = ordersList;
        }
        public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }

        public override long GetItemId(int position)
        {
            return position;
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View OrderItem = convertView;
            LayoutInflater inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();

            if (OrderItem == null)
            {
                OrderItem = inflater.Inflate(Resource.Layout.orders_list_item, parent, false);
            }
            
            TextView CasesBox = OrderItem.FindViewById<TextView>(Resource.Id.cases_box);
            TextView ShipperCustCodeBox = OrderItem.FindViewById<TextView>(Resource.Id.shipper_box);
            TextView ShipperOrderNumberBox = OrderItem.FindViewById<TextView>(Resource.Id.shipper_number_box);
            WmsOrderForUi o = OrdersList[position];

            CasesBox.Text = o.ExpectedCases.ToString();
            ShipperCustCodeBox.Text = o.ShipperCompanyCode.ToString().Trim();
            ShipperOrderNumberBox.Text = o.ShipperOrderNumber.ToString().Trim();

            return OrderItem;
        }
        public WmsOrderForUi GetOrderByIndex(int theIndex)
        {
            WmsOrderForUi TheOrder = OrdersList[theIndex];
            return TheOrder;
        }
        public override int Count
        {
            get
            {
                if (OrdersList == null)
                {
                    return 0;
                }
                else
                {
                    return OrdersList.Count;
                }
            }
        }

    }

    internal class OrdersListAdapterViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        //public TextView Title { get; set; }
    }
}