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
            dog.Height = 5.5;
            dog.Color = "black";
            dog.Age = 3;

            //dog.Eat();
            //Console.WriteLine(dog.Cry());
            //Console.WriteLine("Name: " + dog.Name + " Age: " + dog.Age + " Color: " + dog.Color + "Height: " + dog.Height);

            IAnimal cat = new Cat();
            cat.Color = "orange";
            cat.Name = "MouseEater";
            cat.Age = 30;
            cat.Height= 3.2;

            //cat.Eat();
            //Console.WriteLine(cat.Cry());
            //Console.WriteLine("Name: " + cat.Name + " Age: " + cat.Age + " Color: " + cat.Color + "Height: " + cat.Height);

            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(dog);
            animals.Add(cat);

            foreach (IAnimal animal in animals)
            {
                animal.Eat();
                Console.WriteLine(animal.Cry());
                Console.WriteLine("Name:{0}, Age:{1}, Color:{2}, Height:{3}", animal.Name, animal.Age, animal.Color, animal.Height);
            }
        }
    }
}
