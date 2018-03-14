using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_09_Factory1 {
    class PizzaMexican : Pizza {

        public PizzaMexican() : base() {

        }

        override public String describe() {
            return "Mexican pizza";
        }
    }
}
