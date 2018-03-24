using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command1 {
    class MacroCommand : ICommand {

        List<ICommand> commands;

        public MacroCommand(List<ICommand> commands) {
            this.commands = commands;
        }

        public void execute() {
            Console.WriteLine("Executing Macro Command.");
            foreach (ICommand command in this.commands) {
                command.execute();
            }
        }
        public void undo() {
            Console.WriteLine("Undoing Macro Command.");
            List<ICommand> reversedCommands = this.commands;
            reversedCommands.Reverse();
            foreach (ICommand command in reversedCommands) {
                command.undo();
            }
        }
    }
}
