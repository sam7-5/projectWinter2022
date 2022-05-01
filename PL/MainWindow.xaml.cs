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

namespace PL
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


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
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (pseudoTxtBox.Text == "admin" && pswdBox.Password == "yossi")
            {
                essai win1 = new essai();
                win1.Show();
                this.Close();
            }
            else
            {
                errorMsg.Text = "wrong password try again";
            }
            
        }
    }
}
