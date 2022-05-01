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
    public class mediaVM : observableObject
    {

        public ObservableCollection<MediaNasa> medias { get; set; }
        private mediaModel CurrentModel;
        public mediaVM() { }
        public mediaVM(string text)
        {
            CurrentModel = new mediaModel();
            medias = new ObservableCollection<MediaNasa>(CurrentModel.loadData(text));
        }
    }
}
