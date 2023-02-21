using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAbstractClasses
{
    internal class Cat : IAnimal
    {
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice");
        }
    }
}
