using BE.Common;
using BE.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Planet
    { 
        public int Id{ get; set; }

        public string Name { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public double Diameter { get; set; }
        public double DistanceFromSun { get; set; }
        public double Gravity { get; set; }
        public double Mass { get; set; }
        public double MeanTemparature { get; set; }
        public int NumberOfMoon { get; set; }
        public Materials[] PlanetsMaterials { get; set; }

        public Planet() { }


    }
}
