using PL.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.MVVM.ViewModels
{
    public class mainVM : observableObject
    {
        public RelayCommand daypictureCommand { get; set; }
        public RelayCommand solarSystemCommand { get; set; }
        public RelayCommand infoCommand { get; set; }
        public RelayCommand mediaSearchCommand { get; set; }
        public RelayCommand asteroidsCommand { get; set; }


        public dayPictureVM dayPictureVM { get; set; }
        public solarSystemVM solarSystemVM { get; set; }
        public infoVM infoVM { get; set; }
        public mediaVM mediaVM { get; set; }
        public asteroidsVM asteroidsVM { get; set; }

        private observableObject _currentView;

        public observableObject CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }



        public mainVM()
        {
            dayPictureVM = new dayPictureVM();
            solarSystemVM = new solarSystemVM();
            infoVM = new infoVM();
            mediaVM = new mediaVM();
            asteroidsVM = new asteroidsVM();

            daypictureCommand = new RelayCommand(s =>
            {
                CurrentView = dayPictureVM;
            });
            solarSystemCommand = new RelayCommand(s =>
            {
                CurrentView = solarSystemVM;
            });
            infoCommand = new RelayCommand(s =>
            {
                CurrentView = infoVM;
            });
            mediaSearchCommand = new RelayCommand(s =>
            {
                CurrentView = mediaVM;
            });
            asteroidsCommand = new RelayCommand(s =>
            {
                CurrentView = asteroidsVM;
            });

        }
    }
}
