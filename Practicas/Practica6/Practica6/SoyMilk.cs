using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6 {
    class SoyMilk : Ingredient {

        Drink drink;

        public SoyMilk(Drink drink) {
            this.drink = drink;
        }

        public override string getDescription() {
            return drink.getDescription() + ", Soy Milk";
        }

        public override double cost() {
            if (drink.size == "Medium") {
                return drink.cost() + 9;
            }
            else if (drink.size == "Large") {
                return drink.cost() + 10;
            }
            else {
                return drink.cost() + 8;
            }
        }
    }
}
