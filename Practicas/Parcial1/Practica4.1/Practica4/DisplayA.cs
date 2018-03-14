using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4 {
    class DisplayA : IObserver, IDisplayable {

        public DisplayA() { }

        public void update(Observable obs, Object o) {
            WeatherData wd = (WeatherData)o;
            double temp = wd.getTemperature();
        }
        public void display() {

        }
    }
}
