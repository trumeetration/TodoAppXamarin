using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ViewModels;
using Xamarin.Forms;

namespace TodoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = new ViewModel();
            InitializeComponent();
        }
    }
}
