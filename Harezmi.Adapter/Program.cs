using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            HarezmiSwitch harezmiSwitch = new HarezmiSwitch(new PhilipsLambaAdapter());

            harezmiSwitch.On();
            harezmiSwitch.Off();

            harezmiSwitch.SetLamba(new GeneralElectricLambaAdapter());

            harezmiSwitch.On();
            harezmiSwitch.Off();

            Console.ReadKey();

        }
    }
}
