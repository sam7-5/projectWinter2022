using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    /// <summary>
    /// class that will handle the data receive by nasa neoWs API.
    /// </summary>
    public class NeoWsData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Diameter { get; set; }
        public bool isHazardousAsteroid { get; set; }
        public string StartDate { get; set; } // yyyy-mm-dd maybe better datetime...
        public string EndDate { get; set; } //yyyy-mm-dd maybe better datetime...

        //TODO: Distance de la terre
        //public string ConString { get; private set; }

        //public NeoWsData() { ConString = "https://api.nasa.gov/neo/rest/v1/neo/browse/"; }

    }
}
