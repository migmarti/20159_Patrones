using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6 {
    class ChaiPay : Drink {

        public ChaiPay() {
            this.size = "Small";
        }

        public ChaiPay(String size) {
            this.size = size;
        }

        public override string getDescription() {
            return this.size + " Chai Pay";
        }

        public override double cost() {

            if (this.size == "Medium") {
                return 50;
            }
            else if (this.size == "Large") {
                return 60;
            }
            else {
                return 40;
            }
        }
    }
}
