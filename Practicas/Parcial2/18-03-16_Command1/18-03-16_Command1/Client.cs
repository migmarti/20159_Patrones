using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command1 {
    class Client {

        private Invoker invoker;
        private Receiver receiver;

        public Client() {
            this.invoker = new Invoker(5);
            this.receiver = new Receiver();
            setCommands();
        }

        private void setCommands() {
            this.invoker.setCommand(new OnCommand(this.receiver), 0);
            this.invoker.setCommand(new OffCommand(this.receiver), 1);
            this.invoker.setCommand(new ResetCommand(this.receiver), 2);
            this.invoker.setCommand(new SleepCommand(this.receiver), 3);
        }
        public void doAction(int index) {
            Console.WriteLine("\nClient invoking command in index " + index);
            this.invoker.invoke(index);
        }
    }
}
