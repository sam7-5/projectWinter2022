using BE;
using DAL.Exceptions;
using DAL.SA;
using DAL.SA.NasaClient;
using DAL.SA.ImaggaClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Dal : IDal
    {
        private readonly spatialDbContext _dbContext;
        private NasaApiClient nasaApiClient = new NasaApiClient();
        private ImaggaApiClient imaggaApiClient = new ImaggaApiClient();    


        public Dal(spatialDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Dal()
        {
            _dbContext = new spatialDbContext();
        }

        #region C.R.U.D
        // all functions will add the object to the db by EF.
        #region ADD

        public async Task<Planet> AddPlanet(Planet planet)
        {
            if (planet == null)
                throw new ArgumentNullException(nameof(planet));
            else if (_dbContext.Planets.Any(p => p.Id == planet.Id))//check if good
                throw new IdAlreadyExistException("Planet ID already exist");

            return await _dbContext.AddPlanet(planet);
        }


        public async Task<Asteroid> AddAsteroid(Asteroid asteroid)
        {
            if (asteroid == null) //.Where(p => p.Id == planet.Id)
                throw new ArgumentNullException(nameof(asteroid));
            //else if (_dbContext.Planets.Any(p => p.Id == asteroid.Id))
               // throw new IdAlreadyExistException("Astroid ID already exist");

            return await _dbContext.AddAsteroid(asteroid);
        }


        public async Task<Satelite> AddSatelite(Satelite satelite)
        {
            if (satelite == null)
                throw new ArgumentNullException(nameof(satelite));
            else if (_dbContext.Planets.Any(p => p.Id == satelite.Id))
                throw new IdAlreadyExistException("Satelite ID already exist");

            return await _dbContext.AddSatelite(satelite);
        }


        #endregion ADD

        // all functions will remove the object requested from the db by EF.
        #region DELETE


        public async Task<Planet> DeletePlanet(Planet planet)
        {

            if (planet == null)
                throw new ArgumentNullException(nameof(planet));
            else if (_dbContext.Planets.FirstOrDefault(p => p.Id == planet.Id) == null)
                throw new IdNotExistException("Planet ID doesn't exist");

            return await _dbContext.RemovePlanet(planet.Id);
        }

        public async Task<Asteroid> DeleteAsteroid(Asteroid asteroid)
        {
            return await _dbContext.RemoveAsteroid(asteroid.Id);
        }

        public async Task<Satelite> DeleteSatelite(Satelite satelite)
        {
            return await _dbContext.RemoveSatelite(satelite.Id);
        }

        #endregion DELETE

        #region UPDATE
        #endregion UPDATE

        // all functions will returns a list of objects from the db by EF.
        #region GET ALL

        public async Task<IEnumerable<Planet>> GetPlanets() 
        {
            return await _dbContext.GetPlanets(); //Good???
        }
        public async Task<IEnumerable<Asteroid>> GetAsteroids() //async -?
        {
            return await _dbContext.GetAsteroids();
        }
        public async Task<IEnumerable<Satelite>> GetSatelites() //async -?
        {
            return await _dbContext.GetSatelites();
        }
        #endregion GET ALL

        // all functions will return the requested object from the db by EF.
        #region GET ONE

        public async Task<Planet> GetPlanet(int planetId)
        {
            return await _dbContext.returnPlanet(planetId);
        }
        public async Task<Asteroid> GetAsteroid(int AsteroidId)
        {
            return await _dbContext.returnAsteroid(AsteroidId);
        }

        public async Task<Satelite> GetSatelite(int SateliteId)
        {
            return await _dbContext.returnSatelite(SateliteId);
        }

        #endregion GET ONE

        #endregion C.R.U.D

        // functions that will parse the data from client api's.
        #region Parse data from API's

        #region NASA API

        /// <summary>
        /// Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
        /// func that will use the api of nasa to get the picture of the day 
        /// </summary>
        /// <returns>Object of p.o.d</returns>
        public async Task<DayPicture> GetPodAsync(string urlApod, string nasaApiKey, string[] service) /*async Task<dayPicture>*/
        { // in BL need to check the param - service - space between the word to define the params
            return await nasaApiClient.ParsingApodAsync(urlApod, nasaApiKey, service);
        }

        /// <summary>
        /// func that will use the api of nasa to get the informations about the asteroids and commet.
        /// </summary>
        /// <param name="service">params for the API query</param>
        /// <returns>List of Objects of NeoWs</returns>
        public async Task<List<Asteroid>> GetNeoWsAsync(string urlNeoWs, string nasaApiKey, string[] service) /*async Task<dayPicture>*/
        { // in BL need to check the param - service - space between the word to define the params
            return await nasaApiClient.ParsingNeoWsAsync(urlNeoWs, nasaApiKey, service);
        }

        // need to finish
        /// <summary>
        /// 
        /// </summary>
        /// <param name="service">params for the API query</param>
        /// <returns></returns>
        public async Task<List<MediaNasa>> GetMediaAsync(string urlMedia, string nasaApiKey, string[] service) //async Task<dayPicture>
        { // in BL need to check the param - service - space between the word to define the params
            return await nasaApiClient.ParsingMediaAsync(urlMedia, nasaApiKey, service);
        }
        
        
        //NOT IN USE?
        /// <summary>
        /// func that will use the function that use the API to get the urls of the media.
        /// </summary>
        /// <returns>List of the urls images/videos</returns>
        /*public List<string> GetUrlsMedia(string urlMedia, string nasaApiKey, string[] service)
        {
            var urlsList = GetMediaAsync(urlMedia, nasaApiKey, service).Result.ToList();
            var retList = new List<string>();
            foreach (var url in urlsList)
            {
                retList.Add(url.ImageUri);
            }
            return retList;
        }*/

        #endregion NASA API

        #region IMAGGA API

        public async Task<List<string>> GetImageDesc(string imageUrl)
        {
           /* var retList = ParseImageAsync(imageUrl);
            //retList = ParseIma*/
            return await imaggaApiClient.ParseImageAsync(imageUrl);
        }

        #endregion IMAGGA API


        #endregion Parse data from API's








    }
}
