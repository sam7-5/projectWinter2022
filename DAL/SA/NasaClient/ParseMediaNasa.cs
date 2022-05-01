using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SA.NasaClient
{
    public class ParseMediaNasa
    {
        public Collection collection { get; set; }
    }
    public class Collection//Collection
    {
        public string version { get; set; }
        public string href { get; set; }
        public List<Item> items { get; set; }//good
        public Metadata metadata { get; set; }
        public List<Link> links { get; set; }//good
    }
    public class Item
    {
        public string href { get; set; }//good
        public List<Datum> data { get; set; }//good
        public List<Link> links { get; set; }//good
    }

    public class Datum
    {
        public string center { get; set; }
        public string title { get; set; }//good
        public string nasa_id { get; set; }
        public string media_type { get; set; }//good
        public List<string> keywords { get; set; }//good
        public DateTime date_created { get; set; }
        public string description_508 { get; set; }
        public string secondary_creator { get; set; }
        public string description { get; set; }//good
        public List<string> album { get; set; }
        public string photographer { get; set; }
        public string location { get; set; }
    }

    public class Link
    {
        public string href { get; set; }//good - get the url of the media
        public string rel { get; set; }
        public string render { get; set; }
        public string prompt { get; set; }
    }

    public class Metadata
    {
        public int total_hits { get; set; }
    }
    
}
