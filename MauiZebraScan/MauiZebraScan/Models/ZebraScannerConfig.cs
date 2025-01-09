using MauiZebraScan.Interfaces;
using System;

namespace MauiZebraScan.Models
{
    public class ZebraScannerConfig : IScannerConfig
    {
        public TriggerType TriggerType { get; set; }

        public bool IsEAN8 { get; set; }
        public bool IsEAN13 { get; set; }
        public bool IsCode39 { get; set; }
        public int decoder_code11_length1 { get; set; }  // bad name. It is len for Code 39
        public int decoder_code11_length2 { get; set; }  // bad name. It is len for Code 39
        public bool IsCode128 { get; set; }
        public int decoder_code128_length1 { get; set; }
        public int decoder_code128_length2 { get; set; }
        public bool IsContinuous { get; set; }
        public bool IsUPCA { get; set; }
        public bool IsUPCE0 { get; set; }
        public bool IsUPCE1 { get; set; }
        public bool IsD2of5 { get; set; }
        public bool IsI2of5 { get; set; }
        public bool IsAztec { get; set; }
        public bool IsPDF417 { get; set; }
        public bool IsQRCode { get; set; }
        public bool IsDataMatrix { get; set; }

        public ZebraScannerConfig()
        {
            //
            //  THIS IS THE DEFAULT CONFIGURATION FOR THE ZEBRA SCANNER
            //
            IsEAN8 = true;
            IsEAN13 = true;
            IsCode39 = true;
            decoder_code11_length1 = 4;
            decoder_code11_length2 = 50;
            IsCode128 = true;
            decoder_code128_length1 = 1;
            decoder_code128_length2 = 50;
            IsUPCA = true;
            IsUPCE0 = true;
            IsUPCE1 = true;
            IsD2of5 = false;
            IsI2of5 = true;
            IsAztec = false;
            IsPDF417 = true;
            IsQRCode = true;
            IsDataMatrix = true;

            // IsContinuous = true;  // pds: commented 1-28-23
            IsContinuous = true;
            TriggerType = TriggerType.HARD;
        }
    }

    public enum TriggerType
    {
        HARD,
        SOFT
    }
}

