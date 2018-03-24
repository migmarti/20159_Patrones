using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command1 {
    class CameraCommand : ICommand {

        Receiver receiver;

        public CameraCommand(Receiver receiver) {
            this.receiver = receiver;
        }

        public void execute() {
            Console.WriteLine("Executing Camera Command.");
            this.receiver.rollCamera();
        }
        public void undo() {
            Console.WriteLine("Undoing Camera Command. Turning off camera.");
        }
    }
}
