using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_09_Factory1 {
    class StyleNY : Decorator {
        Pizza pizza;

        public StyleNY(Pizza pizza) {
            this.pizza = pizza;
        }

        public override string describe() {
            return pizza.describe() + ", New York Style";
        }
    }
}
