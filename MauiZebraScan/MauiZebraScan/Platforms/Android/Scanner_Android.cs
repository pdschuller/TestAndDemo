using System;
using Android.App;
using Android.Content;
using Android.OS;
using MauiZebraScan.Interfaces;
using MauiZebraScan.Models;

namespace MauiZebraScan
{
    public class Scanner_Android : IScanner_Android
    {
        private Context _context = null;
        private bool _bRegistered = false;
        private DataWedgeReceiver _broadcastReceiver = null;
        private static string ACTION_DATAWEDGE_FROM_6_2 = "com.symbol.datawedge.api.ACTION";
        private static string EXTRA_CREATE_PROFILE = "com.symbol.datawedge.api.CREATE_PROFILE";
        private static string EXTRA_SET_CONFIG = "com.symbol.datawedge.api.SET_CONFIG";
        private static string EXTRA_PROFILE_NAME = "Wms App Andr Profile";

        public Scanner_Android()
        {
            // _context = Application.Context;
            // set _context to global application context
            _context = Android.App.Application.Context;

            _broadcastReceiver = new DataWedgeReceiver();

            _broadcastReceiver.scanDataReceived += (s, scanData) =>
            {
                OnScanDataCollected?.Invoke(this, scanData);
            };
            CreateProfile();   // pds, commented out 2-6-23. and commented it back in 2-7-23
                               // the scans were not getting to my handler in VM
                               // everything was fine for a day though AND I made a prod ver and it ran fine
                               // Zebra says this method is fine b c it just does
                               // profileConfig.PutString("CONFIG_MODE", "UPDATE"); not CREATE
            // Create2dProfile();

        }
        public event EventHandler<StatusEventArgs> OnScanDataCollected;
        public event EventHandler<string> OnStatusChanged;
        public void Disable()
        {

            if ((null != _broadcastReceiver) && (null != _context) && _bRegistered)
            {
                // Unregister the broadcast receiver
                _context.UnregisterReceiver(_broadcastReceiver);
                _bRegistered = false;
            }
            DisableProfile();
        }        
        public void Enable()
        {
            _context = Android.App.Application.Context;

            if ((null != _broadcastReceiver) && (null != _context))
            {
                // Register the broadcast receiver
                IntentFilter filter = new IntentFilter(DataWedgeReceiver.IntentAction);
                filter.AddCategory(DataWedgeReceiver.IntentCategory);
                _context.RegisterReceiver(_broadcastReceiver, filter);
                _bRegistered = true;
            }
            EnableProfile();
        }
        //public void Enable2d()
        //{
        //    _context = Application.Context;

        //    if ((null != _broadcastReceiver) && (null != _context))
        //    {
        //        // Register the broadcast receiver
        //        IntentFilter filter = new IntentFilter(DataWedgeReceiver.IntentAction);
        //        filter.AddCategory(DataWedgeReceiver.IntentCategory);
        //        _context.RegisterReceiver(_broadcastReceiver, filter);
        //        _bRegistered = true;
        //    }
        //    Enable2dProfile();
        //}
        public void Read()
        {
            // We can use this to activate a Soft triggered barcode scanning decoding
            throw new NotImplementedException();
        }
        public void SetConfig(IScannerConfig a_config)
        {   //
            //   THIS IS CALLED FROM THE MAIN PAGE VIEW MODEL =========================
            //
            ZebraScannerConfig config = (ZebraScannerConfig)a_config;
            // MobileApp.Build(config) for this app << This the JS logger stuff
            //);

            Bundle profileConfig = new Bundle();
            profileConfig.PutString("PROFILE_NAME", EXTRA_PROFILE_NAME);
            profileConfig.PutString("PROFILE_ENABLED", _bRegistered ? "true" : "false"); //  Seems these are all strings
            profileConfig.PutString("CONFIG_MODE", "UPDATE");
            Bundle barcodeConfig = new Bundle();
            barcodeConfig.PutString("PLUGIN_NAME", "BARCODE"); // pds: NAME can have many values including VOICE and KEYSTROKE
            barcodeConfig.PutString("RESET_CONFIG", "false"); //  This is the default but never hurts to specify
            Bundle barcodeProps = new Bundle();
            barcodeProps.PutString("scanner_input_enabled", "true");
            barcodeProps.PutString("scanner_selection", "auto"); //  Could also specify a number here, the id returned from ENUMERATE_SCANNERS.
                                                                 //  Do NOT use "Auto" here (with a capital 'A'), it must be lower case.

            // **********************************************************************************************
            //
            // pds: even though we use strings here, these are properties in the built in Zebra object
            //      the have to exist in file: ZebraScannerConfig.  The values set there are the defaults FOR THIS APP
            //  
            //    you can use the properties in the ZebraScannerConfig class to set the values here
            //      but using strings makes the code more readable             
            //
            //      both ways are shown below
            //      NOTE: a min length (length1) of 4 will include BCs with 4 digits
            //      The Zebra documentation on these properties is at https://techdocs.zebra.com/datawedge/11-0/guide/decoders/
            //
            // **********************************************************************************************

            barcodeProps.PutString("decoder_i2of5", "true");            
            barcodeProps.PutString("decoder_i2of5_length1", "4");    // decoder_i2of5_length1           
            barcodeProps.PutString("decoder_i2of5_length2", "50");    // decoder_i2of5_length2

            // pds: next line lets the scanner scan Code 39 BCs
            barcodeProps.PutString("decoder_code39", "true");
            barcodeProps.PutString("decoder_code11_length1", config.decoder_code11_length1.ToString() );
            barcodeProps.PutString("decoder_code11_length2", config.decoder_code11_length2.ToString());

            barcodeProps.PutString("decoder_code128", config.IsCode128 ? "true" : "false");
            barcodeProps.PutString("decoder_code128_length1", config.decoder_code128_length1.ToString()) ;
            barcodeProps.PutString("decoder_code128_length2", config.decoder_code128_length2.ToString());

            // pds, 5-9-23, without this you cannot scan UPCA switching back to this config
            //              when the app initial starts you can scan UPCA fine
            barcodeProps.PutString("decoder_upca", "true");
            barcodeProps.PutString("decoder_qrcode", "true");
            barcodeProps.PutString("decoder_datamatrix", config.IsDataMatrix ? "true" : "false");

            //barcodeProps.PutString("decoder_ean8", config.IsEAN8 ? "true" : "false");
            //barcodeProps.PutString("decoder_ean13", config.IsEAN13 ? "true" : "false");
            //barcodeProps.PutString("decoder_upca", config.IsUPCA ? "true" : "false");
            //barcodeProps.PutString("decoder_upce0", config.IsUPCE0 ? "true" : "false");
            //barcodeProps.PutString("decoder_upce1", config.IsUPCE1 ? "true" : "false");
            //barcodeProps.PutString("decoder_d2of5", config.IsD2of5 ? "true" : "false");
            //barcodeProps.PutString("decoder_aztec", config.IsAztec ? "true" : "false");
            //barcodeProps.PutString("decoder_pdf417", config.IsPDF417 ? "true" : "false");
            //barcodeProps.PutString("decoder_qrcode", config.IsQRCode ? "true" : "false");

            // pds: put barcodeProps into barcodeConfig.  barcodeConfig is a Bundle object
            barcodeConfig.PutBundle("PARAM_LIST", barcodeProps);
            // pds: put barcodeConfig into profileConfig
            profileConfig.PutBundle("PLUGIN_CONFIG", barcodeConfig);
            Bundle appConfig = new Bundle();
            appConfig.PutString("PACKAGE_NAME", Android.App.Application.Context.PackageName);      //  Associate the profile with this app
            appConfig.PutStringArray("ACTIVITY_LIST", new String[] { "*" });
            profileConfig.PutParcelableArray("APP_LIST", new Bundle[] { appConfig });
            // pds: pass profileConfig to SendDataWedgeIntentWithExtras.  profileConfig is a Bundle object
            SendDataWedgeIntentWithExtra(ACTION_DATAWEDGE_FROM_6_2, EXTRA_SET_CONFIG, profileConfig);
        }
        //public void SetConfigFromIScannerConfig(IScannerConfig a_config)
        //{   //   All the properties set here are from the ^ config that is passed in
        //    //   THIS IS CALLED FROM THE MAIN PAGE VIEW MODEL =========================
        //    //
        //    // ulong uid = MobileApp.Logger.MethodEntry();

        //    // for this method to work with all config classes this next cast will have to be changed
        //    ZebraScanModeConfig config = (ZebraScanModeConfig)a_config;

        //    //MobileApp.Logger.Verbose(
        //    //    uid,
        //    //    "ZebraScanModeConfig (a_config):\r\n" + 
        //    //    MobileApp.Build(config)
        //    //);

        //    Bundle profileConfig = new Bundle();
        //    profileConfig.PutString("PROFILE_NAME", EXTRA_PROFILE_NAME);
        //    profileConfig.PutString("PROFILE_ENABLED", _bRegistered ? "true" : "false"); //  Seems these are all strings
        //    profileConfig.PutString("CONFIG_MODE", "UPDATE");
        //    Bundle barcodeConfig = new Bundle();
        //    barcodeConfig.PutString("PLUGIN_NAME", "BARCODE"); // pds: NAME can have many values including VOICE and KEYSTROKE
        //    barcodeConfig.PutString("RESET_CONFIG", "false"); //  This is the default but never hurts to specify
        //    Bundle barcodeProps = new Bundle();
        //    barcodeProps.PutString("scanner_input_enabled", "true");
        //    barcodeProps.PutString("scanner_selection", "auto"); //  Could also specify a number here, the id returned from ENUMERATE_SCANNERS.
        //                                                         //  Do NOT use "Auto" here (with a capital 'A'), it must be lower case.
        //    // **********************************************************************************************
        //    //
        //    // pds: even though we use strings here, these are properties in the built in Zebra object
        //    //      the have to exist in file: ZebraScannerConfig.  The values set there are the defaults FOR THIS APP
        //    //  
        //    //    This method sets all the properties based on the Config file that is passed in
        //    //
        //    //      NOTE: a min length (length1) of 4 will include BCs with 4 digits
        //    //      The Zebra documentation on these properties is at https://techdocs.zebra.com/datawedge/11-0/guide/decoders/
        //    //
        //    // **********************************************************************************************

        //    barcodeProps.PutString("decoder_ean8", config.IsEAN8 ? "true" : "false");
        //    barcodeProps.PutString("decoder_ean13", config.IsEAN13 ? "true" : "false");
        //    barcodeProps.PutString("decoder_code39", config.IsCode39.ToString());
        //    barcodeProps.PutString("decoder_code128", config.IsCode128 ? "true" : "false");
        //    barcodeProps.PutString("decoder_code128_length1", config.decoder_code128_length1.ToString());
        //    barcodeProps.PutString("decoder_code128_length2", config.decoder_code128_length2.ToString());
        //    barcodeProps.PutString("decoder_upca", config.IsUPCA ? "true" : "false");
        //    barcodeProps.PutString("decoder_upce0", config.IsUPCE0 ? "true" : "false");
        //    barcodeProps.PutString("decoder_upce1", config.IsUPCE1 ? "true" : "false");
        //    barcodeProps.PutString("decoder_d2of5", config.IsD2of5 ? "true" : "false");
            
        //    barcodeProps.PutString("decoder_i2of5", config.IsI2of5.ToString());
        //    barcodeProps.PutString("decoder_i2of5_length1", config.decoder_i2of5_length1.ToString());
        //    barcodeProps.PutString("decoder_i2of5_length2", config.decoder_i2of5_length2.ToString());
            
        //    barcodeProps.PutString("decoder_aztec", config.IsAztec ? "true" : "false");
        //    barcodeProps.PutString("decoder_pdf417", config.IsPDF417 ? "true" : "false");
        //    barcodeProps.PutString("decoder_qrcode", config.IsQRCode ? "true" : "false");
        //    barcodeProps.PutString("decoder_datamatrix", config.IsDataMatrix ? "true" : "false");

        //    // pds: put barcodeProps into barcodeConfig.  barcodeConfig is a Bundle object
        //    barcodeConfig.PutBundle("PARAM_LIST", barcodeProps);
        //    // pds: put barcodeConfig into profileConfig
        //    profileConfig.PutBundle("PLUGIN_CONFIG", barcodeConfig);
        //    Bundle appConfig = new Bundle();
        //    appConfig.PutString("PACKAGE_NAME", Android.App.Application.Context.PackageName);      //  Associate the profile with this app
        //    appConfig.PutStringArray("ACTIVITY_LIST", new String[] { "*" });
        //    profileConfig.PutParcelableArray("APP_LIST", new Bundle[] { appConfig });
        //    // pds: pass profileConfig to SendDataWedgeIntentWithExtras.  profileConfig is a Bundle object
        //    SendDataWedgeIntentWithExtra(ACTION_DATAWEDGE_FROM_6_2, EXTRA_SET_CONFIG, profileConfig);

        //    // MobileApp.Logger.MethodExit(uid);
        //}
        //public void Set2dConfig(IScannerConfig a_config)
        //{   //
        //    //   THIS IS CALLED FROM THE MAIN PAGE VIEW MODEL =========================
        //    //
        //    // ulong uid = MobileApp.Logger.MethodEntry();

        //    Zebra2dScannerConfig config = (Zebra2dScannerConfig)a_config;

        //    //MobileApp.Logger.Verbose(
        //    //    uid,
        //    //    "ZebraScanModeConfig (a_config):\r\n" +
        //    //    MobileApp.Build(config)
        //    //);

        //    Bundle profileConfig = new Bundle();
        //    // profileConfig.PutString("PROFILE_NAME", "WmsTwoDeeProfile");
        //    profileConfig.PutString("PROFILE_NAME", EXTRA_PROFILE_NAME);

        //    // profileConfig.PutString("PROFILE_ENABLED", _bRegistered ? "true" : "false"); //  Seems these are all strings
        //    profileConfig.PutString("PROFILE_ENABLED", "true");
        //    profileConfig.PutString("CONFIG_MODE", "UPDATE");
        //    Bundle barcodeConfig = new Bundle();
        //    barcodeConfig.PutString("PLUGIN_NAME", "BARCODE"); // pds: NAME can have many values including VOICE and KEYSTROKE
        //    barcodeConfig.PutString("RESET_CONFIG", "false"); //  This is the default but never hurts to specify
        //    Bundle barcodeProps = new Bundle();
        //    barcodeProps.PutString("scanner_input_enabled", "true");
        //    barcodeProps.PutString("scanner_selection", "auto"); //  Could also specify a number here, the id returned from ENUMERATE_SCANNERS.
        //                                                         //  Do NOT use "Auto" here (with a capital 'A'), it must be lower case.

        //    //barcodeProps.PutString("decoder_i2of5", "true");
        //    //barcodeProps.PutString("decoder_i2of5_length1", "4");    // decoder_i2of5_length1           
        //    //barcodeProps.PutString("decoder_i2of5_length2", "50");    // decoder_i2of5_length2

        //    //// pds: next line lets the scanner scan Code 39 BCs
        //    //barcodeProps.PutString("decoder_code39", "true");
        //    //barcodeProps.PutString("decoder_code11_length1", config.decoder_code11_length1.ToString());
        //    //barcodeProps.PutString("decoder_code11_length2", config.decoder_code11_length2.ToString());

        //    barcodeProps.PutString("IsCode128", "false");
        //    // decoder_code128
        //    barcodeProps.PutString("decoder_code128", "false");
        //    // decoder_upca
        //    barcodeProps.PutString("decoder_upca", "false"); 
        //    barcodeProps.PutString("decoder_i2of5", "false");

        //    //barcodeProps.PutString("decoder_code128_length1", config.decoder_code128_length1.ToString());
        //    //barcodeProps.PutString("decoder_code128_length2", config.decoder_code128_length2.ToString());

        //    ////barcodeProps.PutString("decoder_ean8", config.IsEAN8 ? "true" : "false");
        //    ////barcodeProps.PutString("decoder_ean13", config.IsEAN13 ? "true" : "false");
        //    ////barcodeProps.PutString("decoder_upca", config.IsUPCA ? "true" : "false");
        //    ////barcodeProps.PutString("decoder_upce0", config.IsUPCE0 ? "true" : "false");
        //    ////barcodeProps.PutString("decoder_upce1", config.IsUPCE1 ? "true" : "false");
        //    ////barcodeProps.PutString("decoder_d2of5", config.IsD2of5 ? "true" : "false");
        //    ////barcodeProps.PutString("decoder_aztec", config.IsAztec ? "true" : "false");
        //    ////barcodeProps.PutString("decoder_pdf417", config.IsPDF417 ? "true" : "false");
        //    barcodeProps.PutString("decoder_qrcode", config.IsQRCode ? "true" : "false");
        //    barcodeProps.PutString("decoder_datamatrix", "true");

        //    //// pds: put barcodeProps into barcodeConfig.  barcodeConfig is a Bundle object
        //    barcodeConfig.PutBundle("PARAM_LIST", barcodeProps);
        //    //// pds: put barcodeConfig into profileConfig
        //    profileConfig.PutBundle("PLUGIN_CONFIG", barcodeConfig);
            
        //    Bundle appConfig = new Bundle();
        //    appConfig.PutString("PACKAGE_NAME", Android.App.Application.Context.PackageName);  //  Associate the profile with this app
        //    appConfig.PutStringArray("ACTIVITY_LIST", new String[] { "*" });
        //    profileConfig.PutParcelableArray("APP_LIST", new Bundle[] { appConfig });
        //    // pds: pass profileConfig to SendDataWedgeIntentWithExtras.  profileConfig is a Bundle object
        //    // private static string EXTRA_SET_CONFIG = "com.symbol.datawedge.api.SET_CONFIG";
        //    SendDataWedgeIntentWithExtra(ACTION_DATAWEDGE_FROM_6_2, EXTRA_SET_CONFIG, profileConfig);

        //    // MobileApp.Logger.MethodExit(uid);
        //}
        //public void SetDataMatrixConfig(IScannerConfig a_config)
        //{   //
        //    //   THIS IS CALLED FROM THE MAIN PAGE VIEW MODEL =========================
        //    //
        //    // ulong uid = // MobileApp.Logger.MethodEntry();

        //    ZebraDataMatrixConfig config = (ZebraDataMatrixConfig)a_config;

        //    Bundle profileConfig = new Bundle();
        //    // profileConfig.PutString("PROFILE_NAME", "WmsTwoDeeProfile");
        //    profileConfig.PutString("PROFILE_NAME", EXTRA_PROFILE_NAME);

        //    // profileConfig.PutString("PROFILE_ENABLED", _bRegistered ? "true" : "false"); //  Seems these are all strings
        //    profileConfig.PutString("PROFILE_ENABLED", "true");
        //    profileConfig.PutString("CONFIG_MODE", "UPDATE");
        //    Bundle barcodeConfig = new Bundle();
        //    barcodeConfig.PutString("PLUGIN_NAME", "BARCODE"); // pds: NAME can have many values including VOICE and KEYSTROKE
        //    barcodeConfig.PutString("RESET_CONFIG", "false"); //  This is the default but never hurts to specify
        //    Bundle barcodeProps = new Bundle();
        //    barcodeProps.PutString("scanner_input_enabled", "true");
        //    barcodeProps.PutString("scanner_selection", "auto"); //  Could also specify a number here, the id returned from ENUMERATE_SCANNERS.
        //                                                         //  Do NOT use "Auto" here (with a capital 'A'), it must be lower case.

        //    //barcodeProps.PutString("decoder_i2of5", "true");
        //    //barcodeProps.PutString("decoder_i2of5_length1", "4");    // decoder_i2of5_length1           
        //    //barcodeProps.PutString("decoder_i2of5_length2", "50");    // decoder_i2of5_length2

        //    //// pds: next line lets the scanner scan Code 39 BCs
        //    //barcodeProps.PutString("decoder_code39", "true");
        //    //barcodeProps.PutString("decoder_code11_length1", config.decoder_code11_length1.ToString());
        //    //barcodeProps.PutString("decoder_code11_length2", config.decoder_code11_length2.ToString());

        //    barcodeProps.PutString("IsCode128", "false");
        //    // decoder_code128
        //    barcodeProps.PutString("decoder_code128", "false");
        //    // decoder_upca
        //    barcodeProps.PutString("decoder_upca", "false");
        //    // decoder_datamatrix
        //    barcodeProps.PutString("decoder_datamatrix", "true");
        //    barcodeProps.PutString("decoder_qrcode", "false");
        //    // no effect   barcodeProps.PutString("IsI2of5", "false");    
        //    barcodeProps.PutString("decoder_i2of5", "false");    // this made it NOT scan I2of5
        //                                                         // It was already set to false in the Config file
        //    //// pds: put barcodeProps into barcodeConfig.  barcodeConfig is a Bundle object
        //    barcodeConfig.PutBundle("PARAM_LIST", barcodeProps);
        //    //// pds: put barcodeConfig into profileConfig
        //    profileConfig.PutBundle("PLUGIN_CONFIG", barcodeConfig);

        //    Bundle appConfig = new Bundle();
        //    appConfig.PutString("PACKAGE_NAME", Android.App.Application.Context.PackageName);  //  Associate the profile with this app
        //    appConfig.PutStringArray("ACTIVITY_LIST", new String[] { "*" });
        //    profileConfig.PutParcelableArray("APP_LIST", new Bundle[] { appConfig });
        //    // pds: pass profileConfig to SendDataWedgeIntentWithExtras.  profileConfig is a Bundle object
        //    // private static string EXTRA_SET_CONFIG = "com.symbol.datawedge.api.SET_CONFIG";
        //    SendDataWedgeIntentWithExtra(ACTION_DATAWEDGE_FROM_6_2, EXTRA_SET_CONFIG, profileConfig);

        //    // MobileApp.Logger.MethodExit(uid);
        //}

        private void EnableProfile()
        {
            // ulong uid = MobileApp.Logger.MethodEntry();

            //  Now configure that created profile to apply to our application
            Bundle profileConfig = new Bundle();
            profileConfig.PutString("PROFILE_NAME", EXTRA_PROFILE_NAME);
            profileConfig.PutString("PROFILE_ENABLED", "true"); //  Seems these are all strings
            profileConfig.PutString("CONFIG_MODE", "UPDATE");
            SendDataWedgeIntentWithExtra(ACTION_DATAWEDGE_FROM_6_2, EXTRA_SET_CONFIG, profileConfig);

            // MobileApp.Logger.MethodExit(uid);
        }
        private void DisableProfile()
        {
            // ulong uid = MobileApp.Logger.MethodEntry();

            //  Now configure that created profile to apply to our application
            Bundle profileConfig = new Bundle();
            profileConfig.PutString("PROFILE_NAME", EXTRA_PROFILE_NAME);
            profileConfig.PutString("PROFILE_ENABLED", "false"); //  Seems these are all strings
            profileConfig.PutString("CONFIG_MODE", "UPDATE");
            SendDataWedgeIntentWithExtra(ACTION_DATAWEDGE_FROM_6_2, EXTRA_SET_CONFIG, profileConfig);

            // MobileApp.Logger.MethodExit(uid);
        }
        private void CreateProfile()
        {
            // ulong uid = MobileApp.Logger.MethodEntry();

            String profileName = EXTRA_PROFILE_NAME;
            SendDataWedgeIntentWithExtra(ACTION_DATAWEDGE_FROM_6_2, EXTRA_CREATE_PROFILE, profileName);

            //  Now configure that created profile to apply to our application
            Bundle profileConfig = new Bundle();
            profileConfig.PutString("PROFILE_NAME", EXTRA_PROFILE_NAME);
            profileConfig.PutString("PROFILE_ENABLED", "true"); //  Seems these are all strings
            profileConfig.PutString("CONFIG_MODE", "UPDATE");
            Bundle barcodeConfig = new Bundle();
            barcodeConfig.PutString("PLUGIN_NAME", "BARCODE");
            barcodeConfig.PutString("RESET_CONFIG", "true"); //  This is the default but never hurts to specify
            Bundle barcodeProps = new Bundle();
            barcodeConfig.PutBundle("PARAM_LIST", barcodeProps);
            profileConfig.PutBundle("PLUGIN_CONFIG", barcodeConfig);
            Bundle appConfig = new Bundle();
            //  Associate the profile with this app
            appConfig.PutString("PACKAGE_NAME", Android.App.Application.Context.PackageName);      
            appConfig.PutStringArray("ACTIVITY_LIST", new String[] { "*" });
            profileConfig.PutParcelableArray("APP_LIST", new Bundle[] { appConfig });
            SendDataWedgeIntentWithExtra(ACTION_DATAWEDGE_FROM_6_2, EXTRA_SET_CONFIG, profileConfig);
            //  You can only configure one plugin at a time, we have done the barcode input,
            //  now do the intent output
            profileConfig.Remove("PLUGIN_CONFIG");
            Bundle intentConfig = new Bundle();
            intentConfig.PutString("PLUGIN_NAME", "INTENT");
            intentConfig.PutString("RESET_CONFIG", "true");
            Bundle intentProps = new Bundle();
            intentProps.PutString("intent_output_enabled", "true");

            //  intentProps.PutString("intent_action", DataWedgeReceiver.IntentAction); 
            // We can use this ^ when we're going to define the DataWedgeReceiver class
            intentProps.PutString("intent_action", "barcodescanner.RECVR");
            intentProps.PutString("intent_delivery", "2");
            intentConfig.PutBundle("PARAM_LIST", intentProps);
            profileConfig.PutBundle("PLUGIN_CONFIG", intentConfig);
            SendDataWedgeIntentWithExtra(ACTION_DATAWEDGE_FROM_6_2, EXTRA_SET_CONFIG, profileConfig);

            // MobileApp.Logger.MethodExit(uid);
        }
        private void SendDataWedgeIntentWithExtra(String action, String extraKey, Bundle extras)
        {
            // ulong uid = MobileApp.Logger.MethodEntry();

            Intent dwIntent = new Intent();
            dwIntent.SetAction(action);
            dwIntent.PutExtra(extraKey, extras);
            _context.SendBroadcast(dwIntent);

            // MobileApp.Logger.MethodExit(uid);
        }        
        private void SendDataWedgeIntentWithExtra(String action, String extraKey, String extraValue)
        { //         SendDataWedgeIntentWithExtra
            // ulong uid = MobileApp.Logger.MethodEntry();

            Intent dwIntent = new Intent();
            dwIntent.SetAction(action);
            dwIntent.PutExtra(extraKey, extraValue);
            _context.SendBroadcast(dwIntent);

            // MobileApp.Logger.MethodExit(uid);
        }
    }
}
