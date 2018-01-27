using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Queen : Character
    {
        public Queen() : base() { }

        override public void fight()
        {
            weapon.useWeapon();
        }
    }
}
