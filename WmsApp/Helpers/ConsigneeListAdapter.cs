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
        MainActivity glb;
        public ConsigneeListAdapter(Context context)
        {
            this.context = context;
        }
        public ConsigneeListAdapter(Context context, List<CustomConsignee> consignees, MainActivity mainActivity)
        {
            this.context = context;
            this.Consignees = consignees;
            glb = mainActivity;
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
                ConsigneeItem = inflater.Inflate(Resource.Layout.consignee_list_item, parent, false);
            }
            TextView ConsigneeNameBox = ConsigneeItem.FindViewById<TextView>(Resource.Id.consignee_name);
            TextView WmscodeBox = ConsigneeItem.FindViewById<TextView>(Resource.Id.wmscode);
            CustomConsignee cc = Consignees[position];
            ConsigneeNameBox.Text = cc.CompanyName;
            WmscodeBox.Text = cc.WmsCode;
            ConsigneeItem.Click -= ConsigneeItem_Click;
            ConsigneeItem.Click += ConsigneeItem_Click;
            // ConsigneeItem.KeyPress -= ConsigneeItem_KeyPress;
            // ConsigneeItem.KeyPress += ConsigneeItem_KeyPress;
            return ConsigneeItem;
        }

        //private void ConsigneeItem_KeyPress(object sender, View.KeyEventArgs e)
        //{
        //    var ff = e.GetType();
        //    if (e.KeyCode == Keycode.Enter)
        //    {
        //        var dd = ff.ToString();

        //    }
        //    else
        //    {
        //        e.Handled = false;
        //    }
        //}

        public void ConsigneeItem_Click(object sender, EventArgs e)
        {
            if (sender is ListView)
            {
                ListView lv = sender as ListView;
                int SelectedConsigneeIndex = (int)lv.SelectedItem;

                // var WmscodeBox = dd.FindViewById<TextView>(Resource.Id.wmscode);
            } else
            {
            var ll = (LinearLayout)sender;
            var WmscodeBox = ll.FindViewById<TextView>(Resource.Id.wmscode);
            string WmsCode = WmscodeBox.Text;
        }
            glb.screenOne.DaysConsigneesListView.Visibility = ViewStates.Invisible;
        }
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