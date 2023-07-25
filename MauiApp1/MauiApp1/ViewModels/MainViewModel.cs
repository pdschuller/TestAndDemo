
using MauiApp1.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MauiApp1.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        //public void GoBackToMainPage()
        //{
        //    AppShell.Current.GoToAsync("..");
        //}
        public void NavToPageTwo(ToDoItem s)
        {
            AppShell.Current.GoToAsync("PageTwo?TheItem=" + s.Id.ToString());
        }
        public void PopulateCollection()
        {
            myCollection = new ObservableCollection<ToDoItem>();
            myCollection.Add(new ToDoItem { Id = 1, ToDoName = "Find Demolition Guy", DueDate = "8/1/2023", ExpectedCost = "$900" });
            myCollection.Add(new ToDoItem { Id = 2, ToDoName = "Draw Prints", DueDate = "8/3/2023", ExpectedCost = "$0" });
            myCollection.Add(new ToDoItem { Id = 3, ToDoName = "Find Right Hand Man", DueDate = "8/9/2023", ExpectedCost = "$500" });
            myCollection.Add(new ToDoItem { Id = 4, ToDoName = "Build Form", DueDate = "8/10/2023", ExpectedCost = "$300" });
        }        
        public void DeleteItem(ToDoItem item)
        {
            myCollection.Remove(item);
        }

        #region === PROPERTIES =====================================
        // private and public ObservableCollections
        private ObservableCollection<ToDoItem> mycollection;
        public ObservableCollection<ToDoItem> myCollection
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
