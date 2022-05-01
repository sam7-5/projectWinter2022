using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace PL.model
{
    class dayPictureModel
    {
        BL.BL bl = new BL.BL();
        public List<DayPicture> dayPicture { get; set; }
        
        public dayPictureModel()
        {
            string[] text = { "apod"};
            var BLDayPicture = bl.GetPicOfDay(text);
            //bl.AddAsteroid(new Asteroid(2020){Name= "testAsteroid"});
            dayPicture = new List<DayPicture>
            { 
                new DayPicture(){
                url = BLDayPicture.Result.url,
                explanation = BLDayPicture.Result.explanation,
                date = BLDayPicture.Result.date,
                title = BLDayPicture.Result.title }
            };
        }
    }
}
