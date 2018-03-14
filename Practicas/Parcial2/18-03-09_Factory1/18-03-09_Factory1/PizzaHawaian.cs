using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_09_Factory1 {
    class PizzaHawaian : Pizza {

        public PizzaHawaian() : base() {

        }

        override public String describe() {
            return "Hawaian pizza";
        }
    }
}
