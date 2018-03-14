using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_09_Factory1 {
    class Bacon : Decorator {
        Pizza pizza;

        public Bacon(Pizza pizza) {
            this.pizza = pizza;
        }

        public override string describe() {
            return pizza.describe() + ", Bacon";
        }
    }
}
