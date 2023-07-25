
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MauiApp1.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public void NavToPageTwo()
        {
            AppShell.Current.GoToAsync(nameof(PageTwo));
        }
        public void PopulateCollection()
        {
            myCollection = new ObservableCollection<string>();
            myCollection.Add("snot");
            myCollection.Add("snot2");
        }
        public void DeleteItem(string item)
        {
            myCollection.Remove(item);
        }

        #region === PROPERTIES =====================================
        // private and public ObservableCollections
        private ObservableCollection<string> mycollection;
        public ObservableCollection<string> myCollection
        {
            get => mycollection;
            set
            {
                mycollection = value;
                OnPropertyChanged(nameof(myCollection));
            }
        }

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
        #endregion
    }
}
