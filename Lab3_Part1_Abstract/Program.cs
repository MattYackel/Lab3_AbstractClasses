using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal dog;
            dog = new Dog();

            dog.Name = "Max";
            dog.Color = "black";
            dog.Age = 3;

            IAnimal cat = new Cat();
            cat.Color = "orange";
            cat.Name = "MouseEater";
            cat.Age = 30;

            Console.WriteLine("Name: " + dog.Name + " Age: " + dog.Age + " Color: " + dog.Color);
            dog.Eat();
            Console.WriteLine("Name: " + cat.Name + " Age: " + cat.Age + " Color: " + cat.Color);
            cat.Eat();
        }
    }
}
