using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace PL.MVVM.models
{
    class asteroidModel
    {
        public BL.BL bl;
        public List<Asteroid> asteroids;

        public asteroidModel()
        {
            bl = new BL.BL();
            asteroids = new List<Asteroid>();
        }

        public List<Asteroid> getData(string[] parameters)
        {
             asteroids = bl.GetAsteroids(parameters);
         //  List<Asteroid> data = new List<Asteroid>
         // {
         //     new Asteroid{ Id="100", Diameter=10.2, Name="ljlj", Orbiting_body="iuioiuo", Is_potentially_hazardous_asteroid=false, Close_approach_date="20/08/2005", Nasa_jpl_url="http://youtube.com/"},
         //     new Asteroid{ Id="200", Diameter=11.9, Name="ll", Orbiting_body="iuioiuo", Is_potentially_hazardous_asteroid=true, Close_approach_date="25/08/2020", Nasa_jpl_url="http://youtube.com/"},
         //     new Asteroid{ Id="300", Diameter=82.3, Name="reres", Orbiting_body="iuioiuo", Is_potentially_hazardous_asteroid=false, Close_approach_date="20/08/2022", Nasa_jpl_url="http://youtube.com/"},
         // };
            return asteroids;
        }
    }
}
