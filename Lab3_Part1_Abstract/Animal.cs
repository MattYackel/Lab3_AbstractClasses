using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAbstractClasses
{
    internal abstract class IAnimal
    {
        private string name;
        private string color;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public abstract void Eat();
    }
}