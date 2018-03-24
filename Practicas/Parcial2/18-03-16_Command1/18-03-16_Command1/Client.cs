using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command1 {
    class Client {

        private Invoker invoker;
        private Receiver receiver;
        private Stack<ICommand> commandStack;

        public Client() {
            this.invoker = new Invoker(6);
            this.receiver = new Receiver();
            this.commandStack = new Stack<ICommand>();
            setCommands();
        }

        private void setCommands() {
            this.invoker.setCommand(new OnCommand(this.receiver), 0);
            this.invoker.setCommand(new OffCommand(this.receiver), 1);
            this.invoker.setCommand(new ResetCommand(this.receiver), 2);
            this.invoker.setCommand(new SleepCommand(this.receiver), 3);
            this.invoker.setCommand(new ToggleCommand(this.receiver), 4);
            List<ICommand> partyCommands = new List<ICommand>(){ 
                new LightsCommand(new Receiver()),
                new MusicCommand(new Receiver()),
                new CameraCommand(new Receiver())
            };
            this.invoker.setCommand(new MacroCommand(partyCommands), 5);
        }

        public void doAction(int index) {
            Console.WriteLine("\nClient invoking command in index " + index);
            ICommand command = this.invoker.invoke(index);
            if (command != null) {
                this.commandStack.Push(command);
            }
        }

        public void undoAction() {
            if (commandStack.Count > 0) {
                Console.WriteLine("\nClient undoing last command.");
                ICommand command = this.commandStack.Pop();
                command.undo();
            }
        }
    }
}
