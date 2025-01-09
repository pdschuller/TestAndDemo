namespace MauiZebraScan.Models
{
    public class Barcode
    {
        private string data;
        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public Barcode() { }
    }
}
