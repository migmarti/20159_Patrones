using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command1 {
    class Receiver {

        public Receiver() {

        }

        public void on() {
            Console.WriteLine("Receiver is now on.");
        }

        public void off() {
            Console.WriteLine("Receiver is now off.");
        }

        public void sleep() {
            Console.WriteLine("Receiver is now on sleep mode.");
        }

        public void reset() {
            Console.WriteLine("Receiver has been reset.");
        }
    }
}
