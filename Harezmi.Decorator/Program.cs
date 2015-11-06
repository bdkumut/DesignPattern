using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IIcecek icecek = new BuzluKarisim(new SutluKarisim(new Cay()));

            Console.WriteLine(icecek.GetName());

            Console.ReadKey();
        }
    }
}
