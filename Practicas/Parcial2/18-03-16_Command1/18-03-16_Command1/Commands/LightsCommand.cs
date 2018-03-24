using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command1 {
    class LightsCommand : ICommand {

        Receiver receiver;

        public LightsCommand(Receiver receiver) {
            this.receiver = receiver;
        }

        public void execute() {
            Console.WriteLine("Executing Lights Command.");
            this.receiver.turnOnLights();
        }
        public void undo() {
            Console.WriteLine("Undoing Lights Command. Turning off lights.");
        }
    }
}
