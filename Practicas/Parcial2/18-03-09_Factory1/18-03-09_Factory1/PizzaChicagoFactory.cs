using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_09_Factory1 {
    class PizzaChicagoFactory : PizzaFactory {
        
        public PizzaChicagoFactory() {

        }

        override public Pizza makePizza(String name) {
            if (name == "Pepperoni") {
                return new StyleChicago(new PizzaPepperoni());
            }
            else if (name == "Hawaian") {
                return new StyleChicago(new PizzaHawaian());
            }
            else if (name == "Mexican") {
                return new StyleChicago(new PizzaMexican());
            }
            return null;
        }
    }
}
