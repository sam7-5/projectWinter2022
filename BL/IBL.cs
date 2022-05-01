using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    interface IBL
    {
        
        void AddPlanet(Planet p);
        void AddAsteroid(Asteroid a);
        void AddSatelite(Satelite s);

        void DeletePlanet(Planet p);
        void DeleteAsteroid(Asteroid a);
        void DeleteSatelite(Satelite s);

        IEnumerable<Planet> GetPlanets();
        //IEnumerable<Asteroid> GetAsteroids();
        IEnumerable<Satelite> GetSatelites();


        Task<DayPicture> GetPicOfDay(string[] service);
        Task<List<Asteroid>> GetNeoWsData(string[] service);
        List<Asteroid> GetAsteroids(string[] service);
        Task<List<MediaNasa>> GetMedia(string[] service);
        //List<string> GetMedia(string[] service);
        //List<Asteroid> getAsteroidsInfo(string[] service);
    }
}
