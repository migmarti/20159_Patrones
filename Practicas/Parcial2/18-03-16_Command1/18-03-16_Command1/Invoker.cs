using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command1 {
    class Invoker {

        ICommand[] commands;
        int commandCount;

        public Invoker(int commandCount) {
            Console.WriteLine("Invoker initialized with " + commandCount + " commands.");
            this.commandCount = commandCount;
            this.commands = new ICommand[commandCount];
            initializeCommands();
        }

        private void initializeCommands() {
            for (int i = 0; i < this.commandCount; i++) {
                setCommand(new NoCommand(), i);
            }
        }

        public void setCommand(ICommand command, int index) {
            if (index < this.commandCount) {
                this.commands[index] = command;
            }
            else {
                Console.WriteLine("Set Command Error: Index out of range.");
            }
        }

        public ICommand invoke(int index) {
            if (index < this.commandCount) {
                commands[index].execute();
            }
            else {
                Console.WriteLine("Invoke Error: Index out of range.");
                return null;
            }
            return commands[index];
        }

        public void undo(int index) {
            if (index < this.commandCount) {
                commands[index].undo();
            }
            else {
                Console.WriteLine("Undo Error: Index out of range.");
            }
        }

    }
}
