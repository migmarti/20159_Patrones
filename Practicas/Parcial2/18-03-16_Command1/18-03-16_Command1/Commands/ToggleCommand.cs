using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command1 {
    class ToggleCommand : ICommand {

        Receiver receiver;
        Stack<String> stateStrings;

        public ToggleCommand(Receiver receiver) {
            this.receiver = receiver;
            this.stateStrings = new Stack<String>();
        }

        public void execute() {
            Console.WriteLine("Executing Toggle Command.");
            this.stateStrings.Push(this.receiver.toggle());
        }
        public void undo() {
            String stateString = this.stateStrings.Pop();
            while (receiver.state == stateString) {
                stateString = this.stateStrings.Pop();
            }
            receiver.state = stateString;
            Console.WriteLine("Undoing Toggle Command. State is now " + stateString);
        }
    }
}
