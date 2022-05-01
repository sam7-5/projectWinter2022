using BE;
using PL.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PL.MVVM.view
{
    /// <summary>
    /// Logique d'interaction pour solarSystemView.xaml
    /// </summary>
    public partial class solarSystemView : UserControl
    {
        public solarSystemVM vM { get; set; }
        public solarSystemView()
        {
            InitializeComponent();
            vM = new solarSystemVM();
            this.DataContext = vM;
            this.Mycarousel.ItemsSource= vM.planets;
        }
    }
}
