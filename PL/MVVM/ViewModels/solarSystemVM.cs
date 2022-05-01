using BE;
using PL.Commands;
using PL.MVVM.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.MVVM.ViewModels
{
    public class solarSystemVM : observableObject
    {
        public ObservableCollection<Planet> planets { get; set; }
        private solarSystemModel CurrentModel;

        public solarSystemVM()
        {
            CurrentModel = new solarSystemModel();
            planets = new ObservableCollection<Planet>(CurrentModel.planets);

        }


    }


}