using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command1 {
    class MusicCommand : ICommand {

        Receiver receiver;

        public MusicCommand(Receiver receiver) {
            this.receiver = receiver;
        }

        public void execute() {
            Console.WriteLine("Executing Music Command.");
            this.receiver.playMusic();
        }
        public void undo() {
            Console.WriteLine("Undoing Music Command. Turning off music.");
        }
    }
}
