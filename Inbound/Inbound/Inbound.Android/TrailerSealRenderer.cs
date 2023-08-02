using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Inbound.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Inbound.Views.TrailerSealPage), typeof(Inbound.Droid.TrailerSealRenderer))]
namespace Inbound.Droid
{
    public class TrailerSealRenderer : PageRenderer
    {
        // global::Android.Views.View view;
        TrailerSealPage _context;
        public TrailerSealRenderer(Context context) : base(context)
        {
            // _context = (MainPage)context;
            // does nothing    this.KeyPress += MainPageRenderer_KeyPress;
            // this.KeyPress
        }
        public override bool DispatchKeyEvent(KeyEvent ke)
        {
            // MainPage.ReceiveKeyPress(e); is the method that this method returns to
            bool KeyPressWasHandled = false;
            KeyPressWasHandled = (Element as Inbound.Views.TrailerSealPage).ReceiveKeyPress(ke);
            if (KeyPressWasHandled)
            {
                // this next block seems to be needed so that this class
                // continues to receive the keypress event after an Entry box has had the focus
                this.Focusable = true;
                this.FocusableInTouchMode = true;
                this.RequestFocus();
                return true;  // returning true tells the parent class that the keypress has been handled
            }
            else
            {
                try
                {   // in development, just hit F5 here to continue. See catch.
                    return base.DispatchKeyEvent(ke);
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Input string was not in a correct format"))
                    {   // we are sometime getting ^ this when pressing back space delete
                        return false;
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            // }
            // Console.WriteLine("pds: The value2 of KeyPressWasHandledis: " + KeyPressWasHandled.ToString());
            // return KeyPressWasHandled;
            // return base.DispatchKeyEvent(ke);
            // return false;
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);
            // view = this;
            if (e.OldElement != null || Element == null)
            {
                return;
            }
            try
            {
                // (Element as Page).Focused += MainPageRenderer_Focused; // this handler never gets hit
                //(Element as Android.Views.View).Focus();  // "cannot convert Xamarin.Forms.Page to View"

                //(Element as Page).Focus();   
                //bool ff = (Element as Page).IsFocused;  // this remains false

                // ((Android.Views.View)Element).Focus();     // "cannot convert Xamarin.Forms.Page to View"
                // bool ff2 = (Element as ContentPage).IsFocused;

                #region === hit on init.  Makes it work on Consignees View
                this.Focusable = true;
                this.FocusableInTouchMode = true;
                this.RequestFocus();
                bool f = IsFocused;
                #endregion


                // pds: do stuff   pds: ??I think you must do this
                // AddView(this);
                // this.SetBackgroundColor(Android.Graphics.Color.Bisque); //Color.AliceBlue);
                // OnKeyDown(Keycode.A) += SendToParent("A");



            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(@"            ERROR: ", ex.Message);
            }
        }
    }
}