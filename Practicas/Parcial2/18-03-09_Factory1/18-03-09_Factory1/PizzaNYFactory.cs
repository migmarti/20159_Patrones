using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_09_Factory1 {
    class PizzaNYFactory : PizzaFactory {
        public PizzaNYFactory() {

        }

        override public Pizza makePizza(String name) {
            if (name == "Pepperoni") {
                return new StyleNY(new PizzaPepperoni());
            }
            else if (name == "Hawaian") {
                return new StyleNY(new PizzaHawaian());
            }
            else if (name == "Mexican") {
                return new StyleNY(new PizzaMexican());
            }
            return null;
        }
    }
}
