using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            Troll troll = new Troll();
            Queen queen = new Queen();
            King king = new King();
            Knight knight = new Knight();

            troll.setWeapon(new AxeBehavior());
            queen.setWeapon(new KnifeBehavior());
            king.setWeapon(new SwordBehavior());
            knight.setWeapon(new CrossbowBehavior());

        }
    }
}
