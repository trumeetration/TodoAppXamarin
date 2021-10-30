using System;
using System.Collections.ObjectModel;
using TodoApp.Models;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace TodoApp.ViewModels
{
    public class ViewModel : BindableObject
    {
        public ObservableCollection<Todo> Todos { get; set; }
        

        public ViewModel()
        {
            Todos = new ObservableCollection<Todo>();
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

        public Command<Todo> DeleteTodo => new Command<Todo>(task =>
        {
            Todos.Remove(task);
        });

        

    }
}