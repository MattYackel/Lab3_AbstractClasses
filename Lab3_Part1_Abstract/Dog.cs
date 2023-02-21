using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAbstractClasses
{
    internal class Dog : IAnimal
    {
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat");
        }
    }
}
