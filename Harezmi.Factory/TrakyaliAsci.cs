using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Factory
{
    public class TrakyaliAsci : IAsci
    {
        public IYiyecek Hazirla(YiyecekTuru yiyecekTuru)
        {
            IYiyecek yiyecek = null;

            switch (yiyecekTuru)
            {
                case YiyecekTuru.MANTI:
                    yiyecek = new TrakyaUsulu(new Manti());
                    break;
                case YiyecekTuru.CORBA:
                    yiyecek = new TrakyaUsulu(new Tarhana());
                    break;
                default:
                    throw new Exception("Tanımsız Yiyecek Türü");
            }

            return yiyecek;
        }
    }
}
