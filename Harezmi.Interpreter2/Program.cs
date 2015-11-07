using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Interpreter2
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context("{cay:1.00,kahve:1.5,corba:2.00}");

            IExpression<FiyatListesi> expr = new FiyatListesiExpression();

            FiyatListesi fiyatListesi = expr.Evaluate(context);

            foreach (FiyatKalemi fiyatKalemi in fiyatListesi.GetFiyatKalemleri())
            {
                Console.WriteLine(fiyatKalemi.Ad + " -> " + fiyatKalemi.Fiyat.ToString());
            }

            Console.ReadKey();
        }
    }
}
