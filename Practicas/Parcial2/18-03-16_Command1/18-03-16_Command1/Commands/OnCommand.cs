using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command1 {
    class OnCommand : ICommand {

        Receiver receiver;

        public OnCommand(Receiver receiver) {
            this.receiver = receiver;
        }

        public void execute() {
            Console.WriteLine("Executing On Command.");
            this.receiver.on();
        }
        public void undo() {
            Console.WriteLine("Undoing On Command. Turning off receiver.");
            this.receiver.off();
        }
    }
}
