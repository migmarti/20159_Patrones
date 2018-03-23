using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command1 {
    class OffCommand : ICommand {

        Receiver receiver;

        public OffCommand(Receiver receiver) {
            this.receiver = receiver;
        }

        public void execute() {
            Console.WriteLine("Executing Off Command.");
            this.receiver.off();
        }
        public void undo() {
            Console.WriteLine("Undoing Off Command. Turning on receiver.");
            this.receiver.on();
        }
    }
}
