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
using System.Threading.Tasks;
using tlModels;

namespace WmsApp.Helpers
{
    internal class ConsigneeListAdapter : BaseAdapter
    {
        Context context;
        List<CustomConsignee> Consignees;
        MainActivity glb;
        WsCalls wsCalls;
        public ConsigneeListAdapter(Context context)
        {
            this.context = context;
        }
        public ConsigneeListAdapter(Context context, List<CustomConsignee> consignees, MainActivity mainActivity)
        {
            this.context = context;
            this.Consignees = consignees;
            glb = mainActivity;
            wsCalls = new WsCalls();
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
            // KeyPress event for this list is in ScreenOne
            return ConsigneeItem;
        }
        public async void ConsigneeItem_Click(object sender, EventArgs e)
        {
            if (sender is ListView)
            {
                ListView lv = sender as ListView;
                int SelectedConsigneeIndex = (int)lv.SelectedItem;
                CustomConsignee SelectedConsignee = GetConsigneeByIndex(SelectedConsigneeIndex);
                string WmsCode = SelectedConsignee.WmsCode;
                glb.screenOne.PopulateOrdersList(WmsCode);

            } else
            {
            var ll = (LinearLayout)sender;
            var WmscodeBox = ll.FindViewById<TextView>(Resource.Id.wmscode);
            string WmsCode = WmscodeBox.Text;
        }
            glb.screenOne.DaysConsigneesListView.Visibility = ViewStates.Gone;
        }
        public CustomConsignee GetConsigneeByIndex (int theIndex)
        {
            CustomConsignee TheConsignee = Consignees[theIndex];
            return TheConsignee;
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