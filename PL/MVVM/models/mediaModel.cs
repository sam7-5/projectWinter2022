using BE;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.MVVM.models
{
    class mediaModel
    {
        public BL.BL bL;
        public List<MediaNasa> medias;
      //  media fst, snd,t,q,c;
       // string text= @"https://upload.wikimedia.org/wikipedia/commons/6/6f/Earth_Eastern_Hemisphere.jpg";
        public mediaModel()
        {
            bL = new BL.BL();
            medias = new List<MediaNasa>();
          //  fst=new media();
          //  snd=new media();
          //  t=new media();
          //  q=new media();
          //  c=new media();
          
        }


        public List<MediaNasa> loadData(string text)
        {
            string[] texts = { "media", text };
            return medias = Task.Run(() => bL.GetMedia(texts)).Result;//bL.GetMedia(texts);
            // "https://upload.wikimedia.org/wikipedia/commons/7/7b/Earth_Western_Hemisphere.jpg";
            //  "https://upload.wikimedia.org/wikipedia/commons/6/6f/Earth_Eastern_Hemisphere.jpg";
            // fst.imageUri = @"https://upload.wikimedia.org/wikipedia/commons/7/7b/Earth_Western_Hemisphere.jpg";
            // snd.imageUri = "https://upload.wikimedia.org/wikipedia/commons/6/6f/Earth_Eastern_Hemisphere.jpg";
            // t.imageUri = "https://upload.wikimedia.org/wikipedia/commons/6/6f/Earth_Eastern_Hemisphere.jpg";
            // q.imageUri = "https://upload.wikimedia.org/wikipedia/commons/6/6f/Earth_Eastern_Hemisphere.jpg";
            // c.imageUri = "https://upload.wikimedia.org/wikipedia/commons/6/6f/Earth_Eastern_Hemisphere.jpg";
            // medias.Add(fst);
            // medias.Add(snd);
            // medias.Add(t);
            // medias.Add(q);
            // medias.Add(c);
            //return medias;
        }
    }
}
