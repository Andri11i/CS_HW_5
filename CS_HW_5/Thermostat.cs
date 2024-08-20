using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_5
{
    public delegate void TemperatureChangedEventHandler(double newTemperature);

    public class Thermostat
    {
        private double _temperature;
        public event TemperatureChangedEventHandler TemperatureChanged;

        public double Temperature
        {
            get { return _temperature; }
            set
            {
                if (_temperature != value)
                {
                    _temperature = value;
                    OnTemperatureChanged(value);
                }
            }
        }

        protected virtual void OnTemperatureChanged(double newTemperature)
        {
            TemperatureChanged?.Invoke(newTemperature);
        }
    }
}
