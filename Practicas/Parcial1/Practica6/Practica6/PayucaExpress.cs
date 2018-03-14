using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6 {
    class PayucaExpress : Drink {

        public PayucaExpress() {
            this.size = "Small";
        }

        public PayucaExpress(String size) {
            this.size = size;
        }

        public override string getDescription() {
            return this.size + " Payuca Express";
        }

        public override double cost() {
            if (this.size == "Medium") {
                return 80;
            }
            else if (this.size == "Large") {
                return 90;
            }
            else {
                return 70;
            }
        }
    }
}
