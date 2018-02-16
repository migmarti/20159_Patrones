using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5 {
    class ClientC : IObserver {

        public ClientC() { }

        public void update(Observable obs, Object o) {
            String message = o.ToString();
            display(message);
        }
        public void display(String message) {
            Console.WriteLine("Client C received: " + message);
        }
    }
}
