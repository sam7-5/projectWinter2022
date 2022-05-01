using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using BE;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static DAL.SA.ImaggaClient.ImaggaParser;

namespace DAL.SA.ImaggaClient
{
    /// <summary>
    /// service interface for api with IMAGGA
    /// send an image and receive a .jsn Object with details on the image, use AI.
    /// </summary>
    public class ImaggaApiClient
    {
        public async Task<string> GetImaggaApi(string imageUrl)
        {
            string apiKey = "acc_1b54c8a17c0d053";
            string apiSecret = "e3f928e670829f9ca19f80a2943f698f";
            string basicAuthValue = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(String.Format("{0}:{1}", apiKey, apiSecret)));

            RestClient client = new RestClient("https://api.imagga.com/v2/tags");
            client.Timeout = -1;

            var request = new RestRequest(Method.GET);
            request.AddParameter("image_url", imageUrl);
            request.AddHeader("Authorization", String.Format("Basic {0}", basicAuthValue));
            
            //some trys to do async
            /*var cancellationTokenSource = new CancellationTokenSource();
            IRestResponse response = await client.ExecuteAsync(request, cancellationTokenSource.Token);*/

            //IRestResponse response = client.Execute(request);

            IRestResponse response = await Task.FromResult(client.Execute(request));
            return response.Content;
        }


        /// <summary>
        /// func that parse the data recieve from imagga client API.
        /// </summary>
        /// <param name="response"></param>
        public async Task<List<string>> ParseImageAsync(string imageUrl)
        {
            string response = await GetImaggaApi(imageUrl); 
            Root deserialize = JsonConvert.DeserializeObject<Root>(response);
            IEnumerable<Tag> iList = deserialize.result.tags;
            var retList = new List<string>();
            
            foreach (var tag in iList)
            {
                if (tag.confidence > 80)
                {
                    retList.Add(tag.tag.en);
                    /*retList.Add(new ImaggaC()
                    {
                        ImageDescription = tag.tag.en
                    }) ;*/
                }
            }
            return retList;
        }



        /* /// <summary>
         /// func that parse the data recieve from imagga client API.
         /// </summary>
         /// <param name="response"></param>
         public List<string> ParseImage(IRestResponse response)
         {
             Root deserialize = JsonConvert.DeserializeObject<Root>(response.Content);
             IEnumerable<Tag> iList = deserialize.result.tags;
             List<string> retList = new List<string>();
             *//*Dictionary<string, double> imaggaResDict =
                        new Dictionary<string, double>();*//*
             foreach (var tag in iList)
             {
                 if(tag.confidence > 80)
                 {
                     retList.Add(tag.tag.en);
                     //imaggaResDict.Add(tag.tag.en, tag.confidence);
                 }
             }
             return retList;
         }*/
    }

    
}
