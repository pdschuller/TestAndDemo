using System;

namespace WPCordovaClassLib.Cordova.Commands
{
    public class dlScanner : BaseCommand
    {
        public void scanBarcode(string options)
        {
            // string upperCase = JSON.JsonHelper.Deserialize<string[]>(options)[0].ToUpper();
            //string upperCase = options.ToUpper();
            //PluginResult result;
            //if (upperCase != "")
            //{
            //    result = new PluginResult(PluginResult.Status.OK, upperCase);
            //}
            //else
            //{
            //    result = new PluginResult(PluginResult.Status.ERROR, upperCase);
            //}

            // DispatchCommandResult(result);
            DispatchCommandResult("result");
        }
    }
}
