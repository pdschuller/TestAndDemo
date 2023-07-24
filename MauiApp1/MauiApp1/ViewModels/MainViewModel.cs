
using System.ComponentModel;

namespace MauiApp1.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        string mytext;
        public string myText
        {
            get => mytext;
            set
            {
                mytext = value;
                OnPropertyChanged(nameof(myText));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string name) => 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));        
    }
}
