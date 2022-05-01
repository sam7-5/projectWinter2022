using BE;
using DAL;
using DAL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BL :IBL
    {
        private IDal myDal;
        public BL()
        {
            myDal = new DAL.Dal();
        }

        private string nasaApiKey = "CxuV2ZUdmgOQZPuXCuih4pchBVAb7c8LoNZ74Aow";
        private string urlApod = "https://api.nasa.gov/planetary/apod";
        private string urlNeoWs = "https://api.nasa.gov/neo/rest/v1/neo/browse/";
        
        private string urlMedia = "https://images-api.nasa.gov/search?q=";
        List<string> KeyWords = new List<string> { "Planete","celestial body", "moon","asteroid","planet",
                                                    "astronaut","star","astronomie"};

        #region C.R.U.D

        #region ADD BL
        public void AddPlanet(Planet planet)
        {
            try 
            { 
                myDal.AddPlanet(planet); 
            }catch (IdAlreadyExistException ex) { throw ex.InnerException; }//throw new Exception(ex.Message);
        }


        public void AddAsteroid(Asteroid asteroid)
        {
            try
            {
                myDal.AddAsteroid(asteroid);
            }catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void AddSatelite(Satelite satelite)
        {
            try
            {
                myDal.AddSatelite(satelite);
            }
            catch (Exception ex){ throw new Exception(ex.Message); }
        }
        #endregion ADD BL

        #region DELETE BL
        public void DeletePlanet(Planet planet)
        {
            try
            {
                myDal.DeletePlanet(planet);
            }
            catch (IdAlreadyExistException ex) { throw ex.InnerException; }//throw new Exception(ex.Message);
        }


        public void DeleteAsteroid(Asteroid asteroid)
        {
            try
            {
                myDal.DeleteAsteroid(asteroid);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void DeleteSatelite(Satelite satelite)
        {
            try
            {
                myDal.DeleteSatelite(satelite);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        #endregion DELETE BL

        #region UPDATE BL
        /*public void UpdatePlanet(Planet planet)
        {
            try
            {
                myDal.UpdatePlanet(planet);
            }
            catch (IdAlreadyExistException ex) { throw ex.InnerException; }//throw new Exception(ex.Message);
        }


        public void UpdateAsteroid(Asteroid asteroid)
        {
            try
            {
                myDal.UpdateAsteroid(asteroid);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void UpdateSatelite(Satelite satelite)
        {
            try
            {
                myDal.UpdateSatelite(satelite);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }*/
        #endregion UPDATE BL
        
        #region GET ALL BL
        public IEnumerable<Planet> GetPlanets()
        {
            try
            {
               return (IEnumerable<Planet>)myDal.GetPlanets();// need to check
            }
            catch (IdAlreadyExistException ex) { throw ex.InnerException; }//need to change
        }

        /*public IEnumerable<Asteroid> GetAsteroids()
        {
            try
            {
                return (IEnumerable<Asteroid>)myDal.GetAsteroids();
            }
            catch (IdAlreadyExistException ex) { throw ex.InnerException; }//need to change
        }
*/
        public IEnumerable<Satelite> GetSatelites()
        {
            try
            {
               return (IEnumerable<Satelite>)myDal.GetSatelites();
            }
            catch (IdAlreadyExistException ex) { throw ex.InnerException; }//need to change
        }

        #endregion GET ALL BL

        #region GET ONE BL
        #endregion GET ONE BL

        #endregion C.R.U.D

        #region API's

        public async Task<DayPicture> GetPicOfDay(string[] service)
        {
            return await myDal.GetPodAsync(urlApod, nasaApiKey, service);
        }
        public async Task<List<Asteroid>> GetNeoWsData(string[] service)
        {
            return await myDal.GetNeoWsAsync(urlNeoWs, nasaApiKey, service);
        }

        public async Task<List<MediaNasa>> GetMedia(string[] service)//MediaNasa
        {
            return await myDal.GetMediaAsync(urlMedia + service[1], nasaApiKey, service); 
        }


        public async Task<List<string>> FilterImage(string imageUrl)
        {
            var retList = myDal.GetImageDesc(imageUrl);
            return await Task.FromResult(retList).Result;
        }
        #endregion API's

        #region HELP API FUNC

        /// <summary> check if FINISH!!!
        /// func that will select some of the api data parsed from the other func(GetNeoWs). 
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        public List<Asteroid> GetAsteroids(string[] service)
        {
            var asteroidsList = Task.Run(() => GetNeoWsData(service)).Result;
            var retList = new List<Asteroid>();
            foreach(var item in asteroidsList){
                if (item.Is_potentially_hazardous_asteroid.ToString() == service[4] && item.Diameter > Double.Parse(service[3])){
                        retList.Add(item);
                }
            }
            
            var retListnodup = new List<Asteroid>();
            retListnodup = retList.Distinct(new ItemEqualityComparer<Asteroid>(nameof(Asteroid.Id))).ToList();
            foreach (var item in retListnodup) { 
                myDal.AddAsteroid(item);
            }
            return retListnodup; 
            
        }
        
        /*public List<string> GetMedia(string[] service){
            
        }*/


        #endregion HELP API FUNC

    }
}
