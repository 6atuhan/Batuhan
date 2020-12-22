using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastane_lab
{
    class KimlikBilgileri
    {
        public int TCKimlikNo { get;private set; }
        public string Ad { get;private set; }
        public string Soyad { get;private set; }

        public void KimlikBilgileriniGetir (int kimlikno)
        {
            TCKimlikNo = kimlikno;
            Ad = "batuhan";
            Soyad = "Boran";
        }

    }
}
