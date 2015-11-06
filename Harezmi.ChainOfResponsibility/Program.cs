using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Yonetim yonetim = new Yonetim(new ProjeYoneticisi(), new BaskanYardimcisi(), new Baskan());

            Talep talep1 = new Talep(500);

            yonetim.TalepOnayla(talep1);

            Console.WriteLine(string.Format("Talep1 Durumu : {0}, Son Degerlendiren : {1}", 
                talep1.Status.ToString(), talep1.Makam.GetType().Name));

            Talep talep2 = new Talep(120000);

            yonetim.TalepOnayla(talep2);

            Console.WriteLine(string.Format("Talep1 Durumu : {0}, Son Degerlendiren : {1}",
                talep2.Status.ToString(), talep2.Makam.GetType().Name));

            Console.ReadKey();
        }
    }
}
