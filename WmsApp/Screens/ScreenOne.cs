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
using tlModels;
using WmsApp.Helpers;

namespace WmsApp.Screens
{
    public class ScreenOne : Fragment
    {
        WsCalls wsCalls;
        List<CustomConsignee> DaysConsignees;
        public override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            wsCalls = new WsCalls();
            DaysConsignees = await wsCalls.GetCustomConsignees(new DateTime(2021, 9, 27));
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View ScreenOne = inflater.Inflate(Resource.Layout.ScreenOne, container, false);
            
            ListView lv = ScreenOne.FindViewById<ListView>(Resource.Id.consignees_listview);
            ConsigneeListAdapter ad = new ConsigneeListAdapter(Activity, DaysConsignees);
            lv.Adapter = ad;
            
            return ScreenOne;

            // return base.OnCreateView(inflater, container, savedInstanceState);
        }
    }
}