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
    public class asteroidsVM : observableObject
    {
        public ObservableCollection<Asteroid> asteroids { get; set; }
        private asteroidModel CurrentModel;

        public asteroidsVM() { }

        public asteroidsVM(string[] parameters)
        {
            CurrentModel = new asteroidModel();
            asteroids = new ObservableCollection<Asteroid>(CurrentModel.getData(parameters));
        }
    }
}
