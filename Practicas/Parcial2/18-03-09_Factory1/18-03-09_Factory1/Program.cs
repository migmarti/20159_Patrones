using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_09_Factory1 {
    class Program {
        static void Main(string[] args) {
            PizzaFactory simpleFactory = new PizzaSimpleFactory();
            PizzaFactory chicagoFactory = new PizzaChicagoFactory();
            PizzaFactory nyFactory = new PizzaNYFactory();
            PizzaStore pizzaStore1 = new PizzaStore(simpleFactory);
            PizzaStore pizzaStore2 = new PizzaStore(chicagoFactory);
            PizzaStore pizzaStore3 = new PizzaStore(nyFactory);
            List<String> pizzas = new List<String> { "Pepperoni", "Hawaian", "Mexican" };
            foreach (String p in pizzas) {

                Pizza pizza1 = pizzaStore1.makePizza(p);
                pizza1 = new Sausage(pizza1);

                Pizza pizza2 = pizzaStore2.makePizza(p);
                pizza2 = new Bacon(pizza2);

                Pizza pizza3 = pizzaStore3.makePizza(p);
                pizza3 = new Mushrooms(pizza3);

                Console.WriteLine(pizza1.describe());
                Console.WriteLine(pizza2.describe());
                Console.WriteLine(pizza3.describe() + "\n");
            }
            Console.ReadLine();
        }
    }
}
