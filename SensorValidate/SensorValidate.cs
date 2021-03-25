using System;
using System.Collections.Generic;

namespace SensorValidate
{ 
    public class SensorValidator
    {
        public static bool ValidateSensorMeasureReadings(List<Double> values, double maxDelta)
        {
            if (!IsSensorReadingsListEmpty(values))
            {
                int lastButOneIndex = values.Count - 1;
                for (int i = 0; i < lastButOneIndex; i++)
                {
                    if (!IsValidSensorMeasureReading(values[i], values[i + 1], maxDelta))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        public static bool IsValidSensorMeasureReading(double value, double nextValue, double maxDelta)
        {
            return (nextValue - value > maxDelta) ? false : true;
        }
        public static bool IsSensorReadingsListEmpty(List<Double> values)
        {
            return (values == null) ? true : false;
        }
    }
}
