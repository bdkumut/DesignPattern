using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Strategy
{
    public class Hayvan
    {
        public int BacakSayisi 
        { 
            get; 
            private set; 
        }

        public Hayvan(int bacakSayisi)
        {
            BacakSayisi = bacakSayisi;
        }

        public void HareketEt(Ortam.OrtamTipi ortamTipi)
        {
            Console.WriteLine("Hayvan'ın bacak sayısı : " + BacakSayisi);
            Ortam.Instance.GetHareketSekli(ortamTipi).HareketEt();
        }
    }
}
