using System.Collections.ObjectModel;
using TodoApp.Models;
using Xamarin.Forms;

namespace TodoApp.ViewModels
{
    public class ViewModel : BindableObject
    {
        public ObservableCollection<Todo> Todos { get; set; }

        public ViewModel()
        {
            Todos = new ObservableCollection<Todo>()
            {
                new Todo {Title = "Title1"},
                new Todo {Title = "Title2"},
                new Todo {Title = "Title3"}
            };
        }

        private string _note;

        public string Note
        {
            get => _note;
            set
            {
                if (_note != value)
                {
                    _note = value;
                    OnPropertyChanged("Note");
                }
            }
        }
    }
}