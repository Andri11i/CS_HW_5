using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_5
{
    public delegate void MeasurementUpdatedEventHandler(double averageMeasurement);

    public class Sensor
    {
        private List<double> measurements = new List<double>();
        public event MeasurementUpdatedEventHandler MeasurementUpdated;

        public void AddMeasurement(double measurement)
        {
            if (measurement > 0)
            {
                measurements.Add(measurement);
                double average = measurements.ToArray().Average();
                OnMeasurementUpdated(average);
            }
        }

        protected virtual void OnMeasurementUpdated(double averageMeasurement)
        {
            MeasurementUpdated?.Invoke(averageMeasurement);
        }
    }
}
