using BE;
using PL.Commands;
using PL.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.MVVM.ViewModels
{
    public  class dayPictureVM : observableObject
    {
      
        public ObservableCollection<DayPicture> dayPictures { get; set; }   
        private dayPictureModel CurrentModel;
       
        public dayPictureVM()
        {
            CurrentModel = new dayPictureModel();
            dayPictures = new ObservableCollection<DayPicture>(CurrentModel.dayPicture);
        }
    }
}
