using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4 {
    interface ISubject {
        void add(IObserver observer);
        void remove(IObserver observer);
        void notify();
    }
}
