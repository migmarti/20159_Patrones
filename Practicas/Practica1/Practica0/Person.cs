using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica0
{
    abstract class Person
    {
        public String name { get; set; }
        public int age { get; set; }
        public Walkable walkingBehavior { get; set; }

        public Person() { }

        public void walk() 
        {

        }
        public void poop()
        {

        }
        public void eat()
        {

        }


    }
}
