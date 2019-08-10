using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpAula01.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UpAula01.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            var vm = new HomeViewModel();
            BindingContext = vm;
        }
    }
}