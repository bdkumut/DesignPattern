using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Factory
{
    public class EgeliAsci : IAsci
    {
        public IYiyecek Hazirla(YiyecekTuru yiyecekTuru)
        {
            IYiyecek yiyecek = null;

            switch (yiyecekTuru)
            {
                case YiyecekTuru.MANTI:
                    yiyecek = new EgeUsulu(new Manti());
                    break;
                case YiyecekTuru.CORBA:
                    yiyecek = new EgeUsulu(new Tarhana());
                    break;
                default:
                    throw new Exception("Tanımsız Yiyecek Türü");
            }

            return yiyecek;
        }
    }
}
