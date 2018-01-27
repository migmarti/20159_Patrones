using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    abstract class Character
    {
        public WeaponBehavior weapon;

        public Character() { }

        public abstract void fight();

        public void setWeapon(WeaponBehavior weaponBehavior)
        {

        }
    }
}
