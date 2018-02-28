using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica7 {
    class Program {
        static void Main(string[] args) {

            StreamReader sr = new StreamReader("test.txt");
            Uppercaser file = new Uppercaser(sr);
            file.print();
  
            Console.ReadLine();  
        }
    }
}
