using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_09_Factory1 {
    class Sausage : Decorator {
        Pizza pizza;

        public Sausage(Pizza pizza) {
            this.pizza = pizza;
        }

        public override string describe() {
            return pizza.describe() + ", Sausage";
        }
    }
}
