using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastane_lab
{
    class Hasta
    {
        public Poliklinik SonGidilenPoliklinik { get; set; }//aggregeşın
        private KimlikBilgileri kimlik;
        public KimlikBilgileri Kimlik
        {   
            get
            {
                if(kimlik== null)
                {
                    kimlik = new KimlikBilgileri();
                    
                }
                return kimlik;
            }
        }
    }
}
