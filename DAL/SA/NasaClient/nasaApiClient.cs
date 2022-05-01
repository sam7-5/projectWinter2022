using Microsoft.Graph;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Threading;

namespace DAL.SA.NasaClient
{
    /// <summary>
    /// service agent for api with NASA
    /// </summary>
    public class NasaApiClient
    {
        /// <summary>
        /// func that will get to nasa api and receive data - image of the day.
        /// </summary>
        public async Task<string> GetNasaApi(string cString, string apiKey, string[] service)
        {
            try
            {
                //IRestResponse response;
                var client = new RestClient(cString);//"https://api.nasa.gov/planetary/apod"
                client.Timeout = -1;

                var request = new RestRequest(Method.GET);
                

                if (service.Length > 0)
                {
                    Console.WriteLine(service.Length);
                    if (service[0] == "neoWs")
                    {
                        //add params
                        request.AddParameter("api_key", apiKey);
                        request.AddParameter("start_date", service[1]);
                        request.AddParameter("end_date", service[2]);
                    }
                    
                    else if(service[0] == "apod"){ 
                        request.AddParameter("api_key", apiKey);
                    }
                }


                IRestResponse response = await Task.FromResult(client.Execute(request));
                //IRestResponse response = client.Execute(request);
                return response.Content;
            }
            catch (Exception) { return JsonConvert.SerializeObject(string.Empty); }
        }

        /// <summary>
        /// func that get the data from Apod api of nasa and parse it
        /// </summary>
        /// <param name="cString"></param>
        /// <param name="apiKey"></param>
        /// <param name="service"></param>
        /// <returns></returns>
        public async Task<DayPicture> ParsingApodAsync(string cString, string apiKey, string[] service)
        {
            string response = await GetNasaApi(cString, apiKey, service);
            DayPicture deserialize = JsonConvert.DeserializeObject<DayPicture>(response);
            return deserialize;
        }
        /// <summary>
        /// func that get the data from NeoWs api of nasa and parse it
        /// </summary>
        /// <param name="cString"></param>
        /// <param name="apiKey"></param>
        /// <param name="service"></param>
        /// <returns>List of BE objects of this type</returns>
        public async Task<List<Asteroid>> ParsingNeoWsAsync(string cString, string apiKey, string[] service)
        {
            string response = await GetNasaApi(cString, apiKey, service);
            ParseNeoWs deserialize = JsonConvert.DeserializeObject<ParseNeoWs>(response);
            List<Asteroid> result = new List<Asteroid>();
            foreach (var item in deserialize.near_earth_objects)
            {
                foreach (var item2 in item.close_approach_data) {
                    result.Add(new Asteroid()
                    {//Int32.Parse(item.id)
                        Id = Int32.Parse(item.id),
                        Name = item.name,
                        Is_potentially_hazardous_asteroid = item.is_potentially_hazardous_asteroid,
                        Diameter = item.estimated_diameter.meters.estimated_diameter_min,
                        Nasa_jpl_url = item.nasa_jpl_url,
                        Orbiting_body = item2.orbiting_body,
                        Close_approach_date = item2.close_approach_date,
                    });
                }
            }
            return result; 
        }

        /// <summary>
        /// func that get the data from Media Images api of nasa and parse it
        /// </summary>
        /// <param name="cString"></param>
        /// <param name="apiKey"></param>
        /// <param name="service"></param>
        /// <returns></returns>
        public async Task<List<MediaNasa>> ParsingMediaAsync(string cString, string apiKey, string[] service)
        {
            string response = await GetNasaApi(cString, apiKey, service);
            ParseMediaNasa deserialize = JsonConvert.DeserializeObject<ParseMediaNasa>(response);
            
            var result = new List<MediaNasa>();
            foreach (var item in deserialize.collection.items)
            {
                if (item.links == null) continue;
                
                result.Add(new MediaNasa()
                {
                    imageUri = item.links[0].href
                });
            }
            return result;
        }
    }
}


//this async command doesn't work
/*var cancellationTokenSource = new CancellationTokenSource();
IRestResponse response = await client.ExecuteAsync(request, cancellationTokenSource.Token);*/
