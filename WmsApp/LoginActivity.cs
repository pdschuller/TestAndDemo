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

namespace WmsApp
{
    [Activity(Label = "LoginActivity", Theme = "@style/AppTheme", MainLauncher = true)]
    public class LoginActivity : Activity
    {
        Button LoginButton;
        WsCalls wsCalls;
        EditText UserInitialsBox;
        EditText UserPasswordBox;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            wsCalls = new WsCalls();
            SetContentView(Resource.Layout.LoginActivity);
            UserInitialsBox = FindViewById<EditText>(Resource.Id.users_initials);
            UserPasswordBox = FindViewById<EditText>(Resource.Id.users_pwd);
            UserInitialsBox.Text = "pds";
            UserPasswordBox.Text = "1234";
            LoginButton = FindViewById<Button>(Resource.Id.login_submit_button);
            LoginButton.Click += LoginButton_Click;
            // Create your application here
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            int UserId = await wsCalls.DoLogin(UserInitialsBox.Text.Trim(), UserPasswordBox.Text.Trim());
            if (UserId > 0)
            {
                Intent i = new Intent(this, typeof(MainActivity));
                i.PutExtra("mobileUserId", UserId);
                this.StartActivity(i);  
            } else
            {
                return;
            }
        }
    }
}