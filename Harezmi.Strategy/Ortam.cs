using Harezmi.Strategy.Hareket;
using Harezmi.Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Strategy
{
    public class Ortam
    {
        public enum OrtamTipi
        {
            KARA,
            HAVA,
            DENIZ
        }

        private static Ortam instance = new Ortam();

        private Ortam()
        {

        }

        public static Ortam Instance
        {
            get
            {
                return instance;
            }
        }

        public IHareketSekli GetHareketSekli(OrtamTipi ortamTipi)
        {
            IHareketSekli hareketSekli = null;

            switch (ortamTipi)
            {
                case OrtamTipi.KARA:
                    hareketSekli = new Yurumek();
                    break;
                case OrtamTipi.HAVA:
                    hareketSekli = new Ucmak();
                    break;
                case OrtamTipi.DENIZ:
                    hareketSekli = new Yuzmek();
                    break;
                default:
                    break;
            }

            return hareketSekli;
        }
    }
}
