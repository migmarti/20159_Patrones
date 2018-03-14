using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6 {
    class PayeLatte : Drink {

        public PayeLatte() {
            this.size = "Small";
        }

        public PayeLatte(String size) {
            this.size = size;
        }

        public override string getDescription() {
            return this.size + " Paye Latte";
        }

        public override double cost() {
            if (this.size == "Medium") {
                return 65.5;
            }
            else if (this.size == "Large") {
                return 75.5;
            }
            else {
                return 55.5;
            }
        }
    }
}
