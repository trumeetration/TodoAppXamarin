using System;
using Xamarin.Forms;

namespace TodoApp.Models
{
    public class Todo : BindableObject
    {
        private string _title;
        private bool _isDone;
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public bool IsDone
        {
            get => _isDone;
            set
            {
                _isDone = value;
                OnPropertyChanged(nameof(IsDone));
            }
        }
    }
}