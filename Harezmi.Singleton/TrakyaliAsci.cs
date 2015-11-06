using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Harezmi.Singleton
{
    public sealed class TrakyaliAsci : IAsci
    {
        private static readonly Lazy<TrakyaliAsci> lazy = new Lazy<TrakyaliAsci>(() => new TrakyaliAsci());

        public static TrakyaliAsci Instance { get { return lazy.Value; } }

        private TrakyaliAsci()
        {
            Console.WriteLine("Trakyalı aşcı işe hazır");
        }

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
