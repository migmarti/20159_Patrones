using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6 {
    abstract class Drink {
        public String size { get; set; }
        public abstract double cost();
        public abstract String getDescription();
    }
}
