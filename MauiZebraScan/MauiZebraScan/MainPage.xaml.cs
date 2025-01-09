using MauiZebraScan.Interfaces;
using MauiZebraScan.Models;
using Microsoft.Extensions.DependencyInjection;

namespace MauiZebraScan
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public IScanner_Android BcScanner { get; set; }
        public ZebraScannerConfig ConfigForAllowedBarcodes { get; set; }

        public MainPage()
        {
            InitializeComponent();

            // IScanner_Android has methods Enable, SetConfig, Disable, etc.
            // BcScanner = DependencyService.Get<MauiZebraScan.Scanner_Android>();
            // BcScanner = DependencyService.Get<IScanner_Android>();
            // access Scanner_Android from the Android platform with Microsoft.Extensions.DependencyInjection
            BcScanner = MauiProgram.CreateMauiApp().Services.GetRequiredService<IScanner_Android>();
            BcScanner.Enable();
            // set the default scanner profile. Else app uses last-active-profile.
            ConfigForAllowedBarcodes = new ZebraScannerConfig();
            BcScanner.SetConfig(ConfigForAllowedBarcodes);
            BcScanner.OnScanDataCollected -= BcScanner_OnScanDataCollected;
            // BcScanner.OnStatusChanged -= BcScanner_OnStatusChanged;
            BcScanner.OnScanDataCollected += BcScanner_OnScanDataCollected;
            // BcScanner.OnStatusChanged += BcScanner_OnStatusChanged;
        }
        private async void BcScanner_OnScanDataCollected(object? sender, StatusEventArgs e)
        {
            Barcode barcode = new Barcode();
            barcode.Data = e.Data;
            barcode.Type = e.BarcodeType;
            Console.WriteLine("pds: BcScanner_OnScanDataCollected. BC value: " + barcode.Data);
            // ToDo: implement Determine BC type
            await HandleBarcodeScan(barcode.Data);
        }
        private async Task HandleBarcodeScan(string data)
        {
            var rr = data;
        }
        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void TestButtonClicked(object sender, EventArgs e)
        {

        }
    }

}
