using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lets create the Director first
            Manufacturer newManufacturer = new Manufacturer();
            // Lets have the Builder class ready
            IPhoneBuilder phoneBuilder = null;

            // Now let us create an android phone
            phoneBuilder = new AndroidPhoneBuilder();
            newManufacturer.Construct(phoneBuilder);
            Console.WriteLine("A new Phone built:\n{0}", phoneBuilder.Phone.ToString());

            Console.WriteLine("\n");

            // Now let us create a Windows Phone
            phoneBuilder = new WindowsPhoneBuilder();
            newManufacturer.Construct(phoneBuilder);
            Console.WriteLine("A new Phone built:\n{0}", phoneBuilder.Phone.ToString());

            Console.ReadKey();
        }
    }
}
