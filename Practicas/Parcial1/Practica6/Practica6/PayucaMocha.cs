using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6 {
    class PayucaMocha : Drink {

        public PayucaMocha() {
            this.size = "Small";
        }

        public PayucaMocha(String size) {
            this.size = size;
        }

        public override string getDescription() {
            return this.size + " Payuca Mocha";
        }

        public override double cost() {
            if (this.size == "Medium") {
                return 70;
            }
            else if (this.size == "Large") {
                return 75;
            }
            else {
                return 65;
            }
        }
    }
}
