using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5 {
    class Program {
        static void Main(string[] args) {
            DHL dhl = new DHL();
            Fedex fedex = new Fedex();
            CorreosDeMexico cmex = new CorreosDeMexico();

            ClientA ca = new ClientA();
            ClientB cb = new ClientB();
            ClientC cc = new ClientC();

            dhl.add(ca);
            dhl.add(cb);
            dhl.add(cc);
            fedex.add(cb);
            fedex.add(cc);
            cmex.add(ca);

            Console.ReadLine();
        }
    }
}
