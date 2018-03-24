using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command1 {
    class NoCommand : ICommand {

        public NoCommand() {

        }

        public void execute() {
            Console.WriteLine("Command not implemented.");
        }

        public void undo() {
            Console.WriteLine("No Command -> nothing to undo.");
        }
    }
}
