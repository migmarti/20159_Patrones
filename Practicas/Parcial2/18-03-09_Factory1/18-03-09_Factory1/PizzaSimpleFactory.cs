using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_09_Factory1 {
    class PizzaSimpleFactory : PizzaFactory {

        public PizzaSimpleFactory() {

        }

        override public Pizza makePizza(String name) {
            if (name == "Pepperoni") {
                return new PizzaPepperoni();
            }
            else if (name == "Hawaian") {
                return new PizzaHawaian();
            }
            else if (name == "Mexican") {
                return new PizzaMexican();
            }
            return null;
        }
    }
}
