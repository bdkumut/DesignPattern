using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Singleton
{
    public sealed class EgeliAsci : IAsci
    {
        private static readonly Lazy<EgeliAsci> lazy = new Lazy<EgeliAsci>(() => new EgeliAsci());

        public static EgeliAsci Instance { get { return lazy.Value; } }

        private EgeliAsci()
        {
            Console.WriteLine("Egeli aşcı işe hazır");
        }

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
