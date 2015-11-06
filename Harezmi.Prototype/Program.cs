using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel personel1 = new Personel("Umut", 31);

            Personel personel2 = personel1.Clone();

            personel1.Age = 55;

            Console.WriteLine(personel2.Age);

            Console.ReadKey();
        }
    }
}
