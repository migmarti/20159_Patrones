using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command1 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("--- Command Pattern Example ---\n");
            Client client = new Client();
            client.doAction(0);
            client.doAction(1);
            client.doAction(2);
            client.doAction(3);
            client.undoAction();
            Console.WriteLine("\n--- Toggle Example ---");
            client.doAction(4);
            client.doAction(4);
            client.doAction(4);
            client.doAction(4);
            client.undoAction();
            client.undoAction();
            client.doAction(4);
            Console.WriteLine("\n--- Macro Example ---");
            client.doAction(5);
            client.undoAction();

            Console.ReadKey();
        }
    }
}
