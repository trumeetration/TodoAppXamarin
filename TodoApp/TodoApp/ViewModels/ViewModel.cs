using System;
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

        private string _noteField;

        public string NoteField
        {
            get => _noteField;
            set
            {
                if (_noteField != value)
                {
                    _noteField = value;
                    OnPropertyChanged(nameof(NoteField));
                }
            }
        }
        

        public Command AddTodo => new Command(() =>
        {
            if (string.IsNullOrWhiteSpace(NoteField) == false)
            {

                Todos.Add(new Todo
                {
                    Title = NoteField
                });
                NoteField = String.Empty;
            }
        });

    }
}