namespace MauiAppPermissions
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            CheckAndRequestLocationPermission();
        }

        public async Task<PermissionStatus> CheckAndRequestLocationPermission()
        {
            PermissionStatus status = 
                await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();

            // could not get this working yet
            //if (Permissions.ShouldShowRationale<Permissions.LocationWhenInUse>())
            //{
            //    // Prompt the user with additional information as to why the permission is needed
            //    await DisplayAlert("Need location", "Gunna need that location", "OK");
            //}

            if (status == PermissionStatus.Granted)                
            { 
                // pds: on Win Location permission is granted by default
                return status; 
            }

            if (status == PermissionStatus.Denied)
            {
                // Prompt the user to turn on in settings
                status = 
                    await Permissions.RequestAsync<Permissions.LocationWhenInUse>();

                return status;
            }
            return status;
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            PermissionStatus status =
                await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();

            //count++;   android.permission.ACCESS_COARSE_LOCATION
            //  android.permission.ACCESS_FINE_LOCATION 

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
