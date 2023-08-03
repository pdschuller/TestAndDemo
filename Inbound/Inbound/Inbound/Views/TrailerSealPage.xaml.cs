using Android.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// using Xamarin.Forms.PlatformConfiguration.Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace Inbound.Views
{
    public partial class TrailerSealPage : ContentPage
    {
        // [XamlCompilation(XamlCompilationOptions.Compile)]
        public TrailerSealPage()
        {
            InitializeComponent();
            // turn off back button at top left of screen
            Shell.SetBackButtonBehavior(this, new BackButtonBehavior
            {
                // IconOverride = "transparent.png",
                IsEnabled = false
            });
        }
        protected override bool OnBackButtonPressed()
        {
            // this works for Android back button that is off the screen at the bottom
            // but NOT for the back button in the top left corner of the screen
            Device.BeginInvokeOnMainThread(async () =>
            {  });
            return true;
        }


        public bool ReceiveKeyPress(KeyEvent e)
        {   // this method is called from my TrailerSealRenderer.DispatchKeyEvent method in the Android platform code
            // if (e.Action == KeyEventActions.Down)  so down arrow fires once
            if (e.KeyCode == Keycode.ButtonL1)
            {
                return false;
            }
            if (e.Action == KeyEventActions.Down)
            {
                bool KeyPressWasHandled = false;
                Keycode TheKeyCode = e.KeyCode;
                if (TheKeyCode != Keycode.ButtonL1)  // pretty sure that this is the RS scanner Scan button
                {
                    // SendDbLoggedInfo.Send("Info", "The user pressed: " + TheKeyCode.ToString());
                }
                // NOTE: each scanner has the Diamond key mapped to Keycode.ShiftLeft, and we handle THAT below
                VerifyDiamondKey(TheKeyCode);

                bool IsALetter = TheKeyCode.ToString().Length == 1 ? true : false;
                
                    // the boolean KeyPressWasHandled will be false if no "arm" in the switch expression handles
                    // the KeyPress then we can return KeyPressWasHandled to the Android platform code and it will go ahead w default behavior
                    KeyPressWasHandled = TheKeyCode switch
                    {
                        // Keycode.Escape => "Escape",
                        Keycode.Escape => HandleEscKeyPress(),
                        //Keycode.Enter => HandleEnterKeyPress(),
                        //Keycode.Num1 => HandleNumpad1KeyPress(),
                        //Keycode.Num2 => HandleNumpad2KeyPress(),
                        //Keycode.Num3 => HandleNumpad3KeyPress(),
                        //Keycode.Num4 => HandleNumpad4KeyPress(),
                        //Keycode.Num5 => HandleNumpad5KeyPress(),
                        //Keycode.Num6 => HandleNumpad6KeyPress(),
                        //Keycode.DpadDown => HandleDownArrowKeyPress(),
                        //Keycode.DpadUp => HandleUpArrowKeyPress(),
                        //Keycode.DpadLeft => HandleLeftArrowKeyPress(),
                        //Keycode.DpadRight => HandleRightArrowKeyPress(),
                        //Keycode.F1 => HandleF1KeyPress(),
                        //Keycode.F2 => HandleF2KeyPress(),
                        //Keycode.F3 => HandleF3KeyPress(),
                        //Keycode.F4 => HandleF4KeyPress(),
                        //Keycode.F5 => HandleF5KeyPress(),
                        //Keycode.F6 => HandleF6KeyPress(),
                        //Keycode.F7 => HandleF7KeyPress(),
                        //Keycode.F8 => HandleF8KeyPress(),
                        //Keycode.F10 => HandleF10KeyPress(),
                        //Keycode.Period => HandlePeriodKeyPress(),
                        //Keycode.ShiftLeft => HandleDiamondKeyPress(),
                        //Keycode.Del => HandleDeleteKeyPress(),
                        //Keycode.Space => HandleSpaceKeyPress(),
                        _ => false
                    };
                
                return KeyPressWasHandled;
            }
            else { return false; }
        }

        private bool HandleEscKeyPress()
        {
            return true;
        }

        private async void VerifyDiamondKey(Keycode TheKeyCode)
        {   // NOTE: each scanner has the Diamond key mapped to Keycode.ShiftLeft, and we handle THAT below
            if ((int)TheKeyCode == 10039)
            {
                // vm.ScreenHeaderText = "Scanner Not Setup";
                await App.Current.MainPage.DisplayAlert("Scanner Not Setup", "It looks like the scanner has not been correctly setup. " +
                    "The Diamond key needs to be mapped to SHIFT_LEFT. See Beitler IT.", "OK");
                Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
            }
        }



    private void SealPage_Esc(object sender, EventArgs e)
        {
            // await Shell.Current.GoToAsync("../");
            Shell.Current.GoToAsync("//LoginPage");
        }
        private void SealPage_Ok(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(ScanPage));
        }
        //private void SealPage_ViaRoute(object sender, EventArgs e)
        //{
        //    Shell.Current.GoToAsync("//LoginPage");
        //    // throws relative route excep await Shell.Current.GoToAsync(nameof(LoginPage));
        //}
    }
}