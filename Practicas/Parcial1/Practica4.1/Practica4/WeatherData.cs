using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4 {
    class WeatherData : Observable {
        double temperature, pressure, humidity;

        public WeatherData() { }

        public double getTemperature() {
            return this.temperature; 
        }
        public double getPressure() {
            return this.pressure; 
        }
        public double getHumidity() {
            return this.humidity; 
        }
        void measurementsChanged() {
            notify(this);
        }
        void setMeasurements(double temp, double pres, double hum) {
            this.temperature = temp;
            this.pressure = pres;
            this.humidity = hum;
            measurementsChanged();
        }
    }
}
