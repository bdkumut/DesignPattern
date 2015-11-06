using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Prototype
{
    public class Personel
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Personel(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Personel Clone()
        {
            return this.MemberwiseClone() as Personel;
        }
    }
}
