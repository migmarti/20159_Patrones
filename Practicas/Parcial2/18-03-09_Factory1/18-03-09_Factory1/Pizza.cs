using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_09_Factory1 {
    abstract class Pizza {

        public String style { get; set; }

        public Pizza() {

        }

        abstract public String describe();
        public void cut() {

        }
        public void bake() {

        }
        public void box() {

        }
    }
}
