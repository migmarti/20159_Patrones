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
            client.doAction(4);
            client.doAction(5);

            Console.ReadKey();
        }
    }
}
