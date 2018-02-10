using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4 {
    class Observable {
        bool changed = false;
        List<IObserver> observers;

        public Observable() {
            this.observers = new List<IObserver>();
        }

        public void add(IObserver observer) {
            this.observers.Add(observer);
        }
        public void remove(IObserver observer) {
            this.observers.Remove(observer);
        }
        public void notify(Object o) {
            foreach (IObserver observer in observers) {
                observer.update(this, o);
            }
        }
        public void setChanged(bool b) {
            this.changed = b;
        }
    }
}
