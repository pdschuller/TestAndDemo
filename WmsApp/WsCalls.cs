using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using tlModels;

namespace WmsApp
{
    public class WsCalls
    {
        #region === URL set up, constructors etc ====================================================
        // **********************************************************************************
        // ******  4-27-21  Whatever is MainIPAddress here, LoginActivity uses **************
        //***********************************************************************************
        // CLV
        // public static readonly string MainIPAddress = "http://palletloader.beitlerfinalmile.com/api/";
        // phil_hp ===========================
        public static readonly string MainIPAddress = "http://192.168.1.8/tlWebApi/api/";

        // public static readonly string MainIPAddress = "http://localhost/tlWebApi/api/";

        // public static readonly string ClvMainIPAddress = "http://palletloader.beitlerfinalmile.com/api/";
        // public static readonly string ClvBackupIPAddress = "HTTP://192.168.1.4/tlWebApi/api/";

        // PROD PIT
        // public static readonly string MainIPAddress = "https://palletloader.wjbeitler.com/api/";
        // public static readonly string BackupIPAddress = "HTTP://palletloader.wjbeitler.com/api/";
        // public static readonly string ClvMainIPAddress = "http://palletloader.wjbeitler.com/api/";
        // public static readonly string ClvBackupIPAddress = "HTTP://palletloader.wjbeitler.com/api/";

        // MIS11   http://mis11.beitler.local/tlWebApi/api/appversion
        // public static readonly string MainIPAddress = "http://mis11.beitler.local/tlWebApi/api/";
        // public static readonly string MainIPAddress = "https://localhost/tlWebApi/api/";



        // the value for IPAddress is being set in the LoginActivity by the popup url picker
        public static string IPAddress = "";

        public static readonly int Port = 80;
        // public static string BaseUrlForClass => $"{IPAddress}:{Port}/tlWebApi/api/";
        // public static string BaseUrlForClass => $"{IPAddress}";
        public static string BaseUrlForClass => $"{MainIPAddress}";
        // public static string BaseUrlForClass = IPAddress;

        // HttpClient is in System.Net.Http. Although we sometimes get java.io.IOException
        private HttpClient _client = new HttpClient();
        private MainActivity glb;

        public WsCalls(Activity context)
        {
            glb = (MainActivity)context;
        }
        public WsCalls()
        {
        }
        #endregion
        public async Task<List<WmsOrderForUi>> GetWmsOrders(DateTime dd, string wmsCode)
        {
            // hit web service
            string strDd = dd.ToString("yyyy-MM-dd");
            string BaseUrl = BaseUrlForClass + "GetWmsOrders/" + strDd + "/" + wmsCode;
            Uri theUrl = new Uri(BaseUrl);
            HttpResponseMessage resp = null;
            try
            {
                List<WmsOrderForUi> TheWmsOrdersForUi = new List<WmsOrderForUi>();
                resp = await _client.GetAsync(theUrl);
                if (resp.IsSuccessStatusCode)
                {
                    string str = await resp.Content.ReadAsStringAsync();
                    TheWmsOrdersForUi =
    (List<WmsOrderForUi>)JsonConvert.DeserializeObject<List<WmsOrderForUi>>(str);
                }
                if (resp.StatusCode == System.Net.HttpStatusCode.RequestedRangeNotSatisfiable)
                {
                    throw new Exception(resp.StatusCode.ToString());
                    // glb.homeScreen.Pop_OneButtonOkMsg_ToUiThread("Web Service Error", resp.ReasonPhrase);
                }
                return TheWmsOrdersForUi;
            }
            catch (Exception ee)
            {
                bool IsNetworkException = ee.Message.Contains("Failed to connect") || ee.Message.Contains("Software caused connection abort") ? true : false;
                if (ee.Message.Contains("timeout"))
                {
                    //glb.homeScreen.Pop_OneButtonOkMsg_ToUiThread("Web service error.", "The web service call timed out.  Try leaving PU mode and going back in.");
                    // return null;
                    throw ee;
                }
                else
                if (IsNetworkException)
                {
                    return null;
                }
                {
                    throw ee;
                }
            }
        }

        public async Task<int> DoLogin(string usersInitials, string usersPin)
        {
            int MobileUsersId = 0;
            Uri theUrl =
                new Uri(BaseUrlForClass + "tllogin/" + usersInitials + "/" + usersPin);
            HttpResponseMessage resp = null;
            try
            {
                resp = await _client.GetAsync(theUrl);
                if (resp.IsSuccessStatusCode)
                {
                    string str = await resp.Content.ReadAsStringAsync();
                    bool IsInt = int.TryParse(str, out MobileUsersId);
                    if (IsInt)
                    {
                        return MobileUsersId;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else { return 0; }
            }
            catch (Exception ee)
            {
                throw ee;
            }
        }
        public async Task<List<CustomConsignee>> GetCustomConsignees(DateTime dd)
        {
            // hit web service
            string strDd = dd.ToString("yyyy-MM-dd");
            string BaseUrl = BaseUrlForClass + "GetCustomConsignees/" + strDd;
            Uri theUrl = new Uri(BaseUrl);
            HttpResponseMessage resp = null;
            try
            {
                List<CustomConsignee> TheCustomConsignees = new List<CustomConsignee>();
                resp = await _client.GetAsync(theUrl);
                if (resp.IsSuccessStatusCode)
                {
                    string str = await resp.Content.ReadAsStringAsync();
                    TheCustomConsignees =
    (List<CustomConsignee>)JsonConvert.DeserializeObject<List<CustomConsignee>>(str);
                }
                if (resp.StatusCode == System.Net.HttpStatusCode.RequestedRangeNotSatisfiable)
                {
                    throw new Exception(resp.StatusCode.ToString());
                    // glb.homeScreen.Pop_OneButtonOkMsg_ToUiThread("Web Service Error", resp.ReasonPhrase);
                }
                return TheCustomConsignees;
            }
            catch (Exception ee)
            {
                bool IsNetworkException = ee.Message.Contains("Failed to connect") || ee.Message.Contains("Software caused connection abort") ? true : false;
                if (ee.Message.Contains("timeout"))
                {
                    //glb.homeScreen.Pop_OneButtonOkMsg_ToUiThread("Web service error.", "The web service call timed out.  Try leaving PU mode and going back in.");
                    // return null;
                    throw ee;
                }
                else
                if (IsNetworkException)
                {
                    return null;
                }
                {
                    throw ee;
                }
            }
        }
    }
}