using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class King : Character
    {
        public King() : base() { }

        public override void fight()
        {
            weapon.useWeapon();
        }
    }
}
