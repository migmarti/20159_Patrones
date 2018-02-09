using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4 {
    class WeatherData : ISubject {
        List<IObserver> observers;
        double temperature, pressure, humidity;

        public WeatherData() { }

        double getTemperature() {
            return this.temperature; 
        }
        double getPressure() {
            return this.pressure; 
        }
        double getHumidity() {
            return this.humidity; 
        }
        void measurementsChanged() {
            notify();
        }
        void setMeasurements(double temp, double pres, double hum) {
            this.temperature = temp;
            this.pressure = pres;
            this.humidity = hum;
            measurementsChanged();
        }

        public void add(IObserver observer) {
            this.observers.Add(observer);
        }
        public void remove(IObserver observer) {
            this.observers.Remove(observer);
        }
        public void notify() {
            foreach (IObserver observer in observers) {
                observer.update(this.temperature, this.pressure, this.humidity);
            }
        }
    }
}
