using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_09_Factory1 {
    class PizzaPepperoni : Pizza {

        public PizzaPepperoni() : base() {

        }

        override public String describe() {
            return "Pepperoni pizza";
        }
    }
}
