using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5 {
    class ClientB : IObserver {

        public ClientB() { }

        public void update(Observable obs, Object o) {
            String message = o.ToString();
            display(message);
        }
        public void display(String message) {
            Console.WriteLine("Client B received: " + message);
        }
    }
}
