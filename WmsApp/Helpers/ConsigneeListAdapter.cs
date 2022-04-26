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
    internal class ConsigneeListAdapter : BaseAdapter
    {
        Context context;
        List<CustomConsignee> Consignees;
        public ConsigneeListAdapter(Context context)
        {
            this.context = context;
        }
        public ConsigneeListAdapter(Context context, List<CustomConsignee> consignees)
        {
            this.context = context;
            this.Consignees = consignees;
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
            View ConsigneeItem = convertView;
            LayoutInflater inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();

            if (ConsigneeItem == null)
            {
                //replace with your item and your holder items
                //comment back in
                ConsigneeItem = inflater.Inflate(Resource.Layout.consignee_list_item, parent, false);
            }

            //ConsigneeListAdapterViewHolder holder = null;
            //if (view != null)
            //    holder = view.Tag as ConsigneeListAdapterViewHolder;
            //if (holder == null)
            //{
            //    holder = new ConsigneeListAdapterViewHolder();
            TextView ConsigneeNameBox = ConsigneeItem.FindViewById<TextView>(Resource.Id.consignee_name);
            TextView WmscodeBox = ConsigneeItem.FindViewById<TextView>(Resource.Id.wmscode);
            CustomConsignee cc = Consignees[position];
            ConsigneeNameBox.Text = cc.CompanyName;
            WmscodeBox.Text = cc.WmsCode;
            //holder.Title = view.FindViewById<TextView>(Resource.Id.text);
            // view.Tag = holder;
            // }
            //fill in your items
            //holder.Title.Text = "new text here";
            return ConsigneeItem;
        }
        //Fill in count here, currently 0
        public override int Count
        {
            get
            {
                if (Consignees == null)
                {
                    return 0;
                } else
                {
                    return Consignees.Count;
                }
            }
        }
    }
    internal class ConsigneeListAdapterViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        //public TextView Title { get; set; }
    }
}