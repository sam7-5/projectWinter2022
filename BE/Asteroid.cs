using BE.Common;
using BE.Enums;
using System.ComponentModel.DataAnnotations;

namespace BE
{
    public class Asteroid 
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Diameter { get; set; }
        public string Close_approach_date { get; set; }// date of closest approach
        public string Orbiting_body { get; set; } // closet spacial body to asteroid
        public string Nasa_jpl_url { get; set; } // link to more info
        public bool Is_potentially_hazardous_asteroid { get; set; }
        
        public Materials[] AsteroidMaterials { get; set; }

        public Asteroid() { }//int id
        public Asteroid(int id) { }


    }
}

