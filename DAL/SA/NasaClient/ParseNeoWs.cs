﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SA.NasaClient
{
    
    public class Kilometers
    {
        public double estimated_diameter_min { get; set; }
        public double estimated_diameter_max { get; set; }
    }

    public class Meters
    {
        public double estimated_diameter_min { get; set; }
        public double estimated_diameter_max { get; set; }
    }



    public class EstimatedDiameter
    {
        public Kilometers kilometers { get; set; }
        public Meters meters { get; set; }
    }

    

    public class MissDistance
    {
        public string kilometers { get; set; }
        
    }

    public class CloseApproachData
    {
        public string close_approach_date { get; set; }
        public string close_approach_date_full { get; set; }
        public MissDistance miss_distance { get; set; }//need it
        public string orbiting_body { get; set; }
    }

    public class OrbitClass
    {
        public string orbit_class_type { get; set; }
        public string orbit_class_description { get; set; }
        public string orbit_class_range { get; set; }
    }

    public class OrbitalData
    {
        public string orbit_id { get; set; }
        public string orbit_determination_date { get; set; }
        public string first_observation_date { get; set; }
        public string last_observation_date { get; set; }
        public int data_arc_in_days { get; set; }
        public int observations_used { get; set; }
        public string orbit_uncertainty { get; set; }
        public string minimum_orbit_intersection { get; set; }
        public string jupiter_tisserand_invariant { get; set; }
        public string epoch_osculation { get; set; }
        public string eccentricity { get; set; }
        public string semi_major_axis { get; set; }
        public string inclination { get; set; }
        public string ascending_node_longitude { get; set; }
        public string orbital_period { get; set; }
        public string perihelion_distance { get; set; }
        public string perihelion_argument { get; set; }
        public string aphelion_distance { get; set; }
        public string perihelion_time { get; set; }
        public string mean_anomaly { get; set; }
        public string mean_motion { get; set; }
        public string equinox { get; set; }
        public OrbitClass orbit_class { get; set; }
    }

    public class NearEarthObject
    {
        public string id { get; set; }
        public string name { get; set; }
        public string name_limited { get; set; }
        //public string designation { get; set; }
        public string nasa_jpl_url { get; set; }
        public EstimatedDiameter estimated_diameter { get; set; }
        public bool is_potentially_hazardous_asteroid { get; set; }
        public List<CloseApproachData> close_approach_data { get; set; }
        public OrbitalData orbital_data { get; set; }
    }


    public class ParseNeoWs
    {
        //public Links links { get; set; }
        //public Page page { get; set; }
        public List<NearEarthObject> near_earth_objects { get; set; }
    }
    
}
