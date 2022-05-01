using PL.MVVM.ViewModels;
using System;
using System.Collections.Generic;
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
    /// Logique d'interaction pour mediaView.xaml
    /// </summary>
    public partial class mediaView : UserControl
    {
        public mediaVM mediaVM { get; set; }
        public mediaView()
        {
            InitializeComponent();

        }

        private void getPictures(object sender, RoutedEventArgs e)
        {
            if (dataSearch.Text == "" || dataSearch.Text == "Search for ... (e.g. \"Orion\")")
            {
                dataSearch.Text = "earth";
            }

            mediaVM = new mediaVM(dataSearch.Text);
            DataContext = mediaVM;

        }

        private void dataSearch_GotMouseCapture(object sender, MouseEventArgs e)
        {
            dataSearch.Text = "";
        }
    }
}
