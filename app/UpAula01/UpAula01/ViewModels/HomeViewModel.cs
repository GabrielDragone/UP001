using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using UpAula01.Models;
using Xamarin.Forms;

namespace UpAula01.ViewModels
{
    public sealed class HomeViewModel : BindableObject
    {
        private ObservableCollection<Candy> items = new ObservableCollection<Candy>();

        public ObservableCollection<Candy> Items
        {
            get => items;
            set
            {
                items = value; OnPropertyChanged();
            }
        }

        public HomeViewModel()
        {
            Items = new ObservableCollection<Candy>(
                new List<Candy>
                {
                    new Candy
                    {
                        Name = "WW",
                        Description = "wwww"
                    }
                    //william@mkn.dev
                }
                );
               
        }
    }
}
