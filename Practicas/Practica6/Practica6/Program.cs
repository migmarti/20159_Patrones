using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6 {
    class Program {
        static void Main(string[] args) {
            Drink beverage = new PayucaMocha("Large");
            Console.WriteLine(beverage.getDescription() + " $" + beverage.cost());
            beverage = new SoyMilk(beverage);
            Console.WriteLine(beverage.getDescription() + " $" + beverage.cost());
            beverage = new Caramel(beverage);
            Console.WriteLine(beverage.getDescription() + " $" + beverage.cost());
            Drink beverage2 = new PayucaExpress();
            Console.WriteLine(beverage2.getDescription() + " $" + beverage2.cost());
            Console.ReadLine();
        }
    }
}
