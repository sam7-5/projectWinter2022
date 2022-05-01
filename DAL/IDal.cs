using BE;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDal
    {
        Task<Planet> AddPlanet(Planet p);
        Task<Asteroid> AddAsteroid(Asteroid a);
        Task<Satelite> AddSatelite(Satelite s);

        Task<Planet> DeletePlanet(Planet p);
        Task<Asteroid> DeleteAsteroid(Asteroid a);
        Task<Satelite> DeleteSatelite(Satelite s);

        Task<IEnumerable<Planet>> GetPlanets();
        Task<IEnumerable<Asteroid>> GetAsteroids();
        Task<IEnumerable<Satelite>> GetSatelites();

        Task<Planet> GetPlanet(int i);
        Task<Asteroid> GetAsteroid(int i);
        Task<Satelite> GetSatelite(int i);

        Task<DayPicture> GetPodAsync(string url, string nasaApiKey, string[] service);
        Task<List<Asteroid>> GetNeoWsAsync(string url, string nasaApiKey, string[] service);
        Task<List<MediaNasa>> GetMediaAsync(string url, string nasaApiKey, string[] service);

        Task<List<string>> GetImageDesc(string imageUrl);




    }
}