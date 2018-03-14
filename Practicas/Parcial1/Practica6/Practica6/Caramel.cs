using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6 {
    class Caramel : Ingredient {

        Drink drink;

        public Caramel(Drink drink) {
            this.drink = drink;
        }

        public override string getDescription() {
            return drink.getDescription() + ", Caramel";
        }

        public override double cost() {
            if (drink.size == "Medium") {
                return drink.cost() + 7;
            }
            else if (drink.size == "Large") {
                return drink.cost() + 8;
            }
            else {
                return drink.cost() + 6;
            }
        }
    }
}
