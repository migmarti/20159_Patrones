using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command1 {
    class SleepCommand : ICommand {

        Receiver receiver;

        public SleepCommand(Receiver receiver) {
            this.receiver = receiver;
        }

        public void execute() {
            Console.WriteLine("Executing Sleep Command.");
            this.receiver.sleep();
        }
        public void undo() {
            Console.WriteLine("Undoing Sleep Command. Waking up receiver.");
            this.receiver.on();
        }
    }
}
