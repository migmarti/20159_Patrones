using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7 {
    class Uppercaser : TextReader {

        StreamReader sr;
        public Uppercaser(StreamReader sr) {
            this.sr = sr;
        }

        public override string ReadLine() {
            string line = sr.ReadLine();
            if (line != null) {
                line = line.ToUpper();
            }
            return line;
        }

        public void print() {
            String line;
            while ((line = ReadLine()) != null) {
                Console.WriteLine(line);
            }
            sr.Close();
        }
    }
}
