using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAbstractClasses
{
    interface IAnimal
    {

        public string Name
        {
            get;
            set;
        }
        public string Color
        {
            get;
            set;
        }
        public double Height
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }

        public void Eat(); //don't need abstract? Why does the word doc say abstract for this.
        public string Cry();
    }
}