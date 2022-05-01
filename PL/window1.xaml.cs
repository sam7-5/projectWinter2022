using MaterialDesignThemes.Wpf;
using PL.Commands;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PL
{
    /// <summary>
    /// Logique d'interaction pour essai.xaml
    /// </summary>
    public partial class essai : Window
    {
        private bool _hidden;
        //public RelayCommand daypictureCommand { get; set; }
        mainVM mainVM;
        public essai()
        {
            InitializeComponent();
            //daypictureCommand = new RelayCommand();
             mainVM = new mainVM();
            this.DataContext = mainVM;
            
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        #region panel animation
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {

            if (_hidden)
            {
                var sb = Resources["OpenMenu"] as Storyboard;
                sb?.Begin(SideBar);
                _hidden = false;
                OpenCloseButtonIcon.Kind = PackIconKind.MenuOpen;
            }
            else
            {
                var sb = Resources["CloseMenu"] as Storyboard;
                sb?.Begin(SideBar);
                _hidden = true;
                OpenCloseButtonIcon.Kind = PackIconKind.Menu;
            }

        }
        #endregion

        #region mouse effects and functionality for exit button
        private void Exit_OnMouseEnter(object sender, MouseEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            Exit.Background = (Brush)bc.ConvertFrom("#F1707A");
        }
        private void Exit_OnMouseLeave(object sender, MouseEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            Exit.Background = (Brush)bc.ConvertFrom("#E81123");
        }
        private void Exit_OnMouseDown(object sender, MouseEventArgs e)
        {
            Close();
        }








        #endregion

        
    }
}
