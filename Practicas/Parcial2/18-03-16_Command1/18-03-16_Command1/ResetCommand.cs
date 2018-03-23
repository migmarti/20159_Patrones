using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command1 {
    class ResetCommand : ICommand {

        Receiver receiver;

        public ResetCommand(Receiver receiver) {
            this.receiver = receiver;
        }

        public void execute() {
            Console.WriteLine("Executing Reset Command.");
            this.receiver.reset();
        }
        public void undo() {
            Console.WriteLine("Undoing Reset Command. Turning off receiver.");
            this.receiver.off();
        }
    }
}
