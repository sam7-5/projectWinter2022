using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.MVVM.models
{
    class solarSystemModel
    {
        //BL bl;
        public List<Planet> planets { get; set; }
        public solarSystemModel()
        {
            planets = new List<Planet>
            {
                //bl=new bl();
                new Planet{ Name="MERCURY", Picture=@"C:\Users\arielsebbag\source\repos\ProjectWinter22\PL\planets\mercury.png", Diameter=4879, DistanceFromSun=57.9, Gravity=3.7, Mass=0.330, MeanTemparature=167, NumberOfMoon=0, Description="Mercury—the smallest planet in our solar system and closest to the Sun—is only slightly larger than Earth's Moon. Mercury is the fastest planet, zipping around the Sun every 88 Earth days."},
                new Planet{ Name="EARTH",Picture=@"C:\Users\arielsebbag\source\repos\projectWinter22\PL\planets\Earth.png", Diameter=12.756, DistanceFromSun=149.6, Gravity=9.8, Mass=5.97, MeanTemparature=15, NumberOfMoon=1, Description="Earth—our home planet—is the only place we know of so far that’s inhabited by living things. It's also the only planet in our solar system with liquid water on the surface."},
                new Planet{ Name="MARS",Picture=@"C:\Users\arielsebbag\source\repos\projectWinter22\PL\planets\Mars.png", Diameter=6792, DistanceFromSun=228.0, Gravity=3.7, Mass=0.642, MeanTemparature=-65 , NumberOfMoon=2, Description="Mars is a dusty, cold, desert world with a very thin atmosphere. There is strong evidence Mars was—billions of years ago—wetter and warmer, with a thicker atmosphere."},
                new Planet{ Name="JUPITER",Picture=@"C:\Users\arielsebbag\source\repos\projectWinter22\PL\planets\Jupiter.png", Diameter=142.984, DistanceFromSun=778.5, Gravity=23.1, Mass=1898, MeanTemparature=-110  , NumberOfMoon=79, Description="Jupiter is more than twice as massive than the other planets of our solar system combined. The giant planet's Great Red spot is a centuries-old storm bigger than Earth."},
                new Planet{ Name="SATURN",Picture=@"C:\Users\arielsebbag\source\repos\projectWinter22\PL\planets\saturn.png", Diameter=120.536, DistanceFromSun=1432.0 , Gravity=9.0, Mass=568, MeanTemparature=-140   , NumberOfMoon=82, Description="Adorned with a dazzling, complex system of icy rings, Saturn is unique in our solar system. The other giant planets have rings, but none are as spectacular as Saturn's."},
                new Planet{ Name="URANUS",Picture=@"C:\Users\arielsebbag\source\repos\projectWinter22\PL\planets\Uranus.png", Diameter=51.118, DistanceFromSun=2867.0, Gravity=8.7, Mass=86.8, MeanTemparature=-195    , NumberOfMoon=27, Description="Uranus—seventh planet from the Sun—rotates at a nearly 90-degree angle from the plane of its orbit. This unique tilt makes Uranus appear to spin on its side."},
                new Planet{ Name="NEPTUNE",Picture=@"C:\Users\arielsebbag\source\repos\projectWinter22\PL\planets\Neptune.png", Diameter=49.528, DistanceFromSun=4515.0, Gravity=11.0, Mass=102, MeanTemparature=-200   , NumberOfMoon=14, Description="Neptune—the eighth and most distant major planet orbiting our Sun—is dark, cold and whipped by supersonic winds. It was the first planet located through mathematical calculations, rather than by telescope."},
                new Planet{ Name="VENUS",Picture=@"C:\Users\arielsebbag\source\repos\projectWinter22\PL\planets\Venus.png", Diameter=12.104, DistanceFromSun=108.2, Gravity=8.9, Mass=4.87, MeanTemparature=464, NumberOfMoon=0, Description="Venus spins slowly in the opposite direction from most planets. A thick atmosphere traps heat in a runaway greenhouse effect, making it the hottest planet in our solar system."},
            };
        }
    }
}

