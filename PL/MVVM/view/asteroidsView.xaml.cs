using BE;
using PL.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Logique d'interaction pour asteroidsView.xaml
    /// </summary>
    public partial class asteroidsView : UserControl
    {
        bool flag = false;
        public asteroidsVM vM { get; set; }
        public asteroidsView()
        {
            InitializeComponent();
            asteroidData.Margin = new Thickness(0, 5000, 0, 0);
            listAsteroids.Margin = new Thickness(0, 5000, 0, 0);
            list.Margin = new Thickness(0, 5000, 0, 0);
            menuTitle.Margin= new Thickness(0, 5000, 0, 0);

            vM = new asteroidsVM();
            this.DataContext = vM;
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            this.parameters.Margin = new Thickness(0, 5000, 0, 0);
            asteroidData.Margin = new Thickness(0, 0, 0, 0);
            listAsteroids.Margin = new Thickness(0, 0, 0, 0);
            list.Margin = new Thickness(0, 0, 0, 0);
            menuTitle.Margin = new Thickness(150, 50, 0, 0);

            string date = startDate.SelectedDate.ToString();
            DateTime date1 = (DateTime)startDate.SelectedDate;
            string endDate = date1.AddDays(7).ToString();
            string diametre = diameter.Text;
            string hazard = hazardous.IsChecked.ToString();

            string[] parameters = { "neoWs", date, endDate, diametre, hazard };

            vM = new asteroidsVM(parameters);
            DataContext = vM;        
        }

        private void PrametersButton_Click(object sender, RoutedEventArgs e)
        {
            asteroidData.Margin = new Thickness(0, 5000, 0, 0);
            listAsteroids.Margin = new Thickness(0, 5000, 0, 0);
            menuTitle.Margin = new Thickness(0, 5000, 0, 0);
            parameters.Margin = new Thickness(0, 0, 0, 0);
        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            flag = false;
            Asteroid asteroid = listAsteroids.SelectedItem as Asteroid;
            if(asteroid==null)return;           
            nameAsteroid.Content = asteroid.Name;
            id.Text = asteroid.Id.ToString();
            diameters.Text=asteroid.Diameter.ToString();
            hazar.Text = asteroid.Is_potentially_hazardous_asteroid.ToString();
            orbit.Text=asteroid.Orbiting_body.ToString();
            moreInfo.Tag = asteroid.Nasa_jpl_url;
            moreInfo.Click += MoreInfo_Click;
        }

        private void MoreInfo_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true) return;
            var btn = sender as Button;
            Process.Start(btn.Tag.ToString());
            flag = true;
        }
    }


}

