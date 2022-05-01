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
using BE;
using PL.MVVM.ViewModels;

namespace PL.MVVM.view
{
    /// <summary>
    /// Logique d'interaction pour TodayPictureView.xaml
    /// </summary>
    public partial class TodayPictureView : UserControl
    {
        public dayPictureVM vM { get; set; }
        public TodayPictureView()
        {
            InitializeComponent();
            vM = new dayPictureVM();
            //this.DataContext = vM;
            DayPicture picture = vM.dayPictures[0];
            flipper.DataContext = picture;
          // img.ImageSource = new BitmapImage(new Uri(picture.url));
          // title.Content = picture.title;
          // date.Content = picture.date;
          // description.Text = picture.explanation;
        }
    }
}
