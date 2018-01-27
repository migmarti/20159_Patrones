using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Troll : Character
    {
        public Troll() : base() { }

        override public void fight() 
        {
            weapon.useWeapon();
        }
    }
}
