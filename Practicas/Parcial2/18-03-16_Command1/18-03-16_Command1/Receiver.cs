using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command1 {
    class Receiver {

        public String state = "Off";

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

        public void turnOnLights() {
            Console.WriteLine("Turned on lights.");
        }

        public void playMusic() {
            Console.WriteLine("Playing music.");
        }

        public void rollCamera() {
            Console.WriteLine("Rolling camera.");
        }

        public String toggle() {

            switch (state) {
                case "Off":
                    state = "Slow";
                    break;
                case "Slow":
                    state = "Medium";
                    break;
                case "Medium":
                    state = "High";
                    break;
                case "High":
                    state = "Off";
                    break;
            }
            Console.WriteLine("Receiver toggle: State is now " + state);
            return state;
        }
    }
}
