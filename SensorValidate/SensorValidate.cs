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
                return CheckSensorMeasureReadings(values,maxDelta);
            }
            return false;
        }
        public static bool CheckSensorMeasureReadings(List<Double> values, double maxDelta)
        {
            int lastButOneIndex = values.Count - 1;
            for (int i = 0; i < lastButOneIndex; i++)
            {
                if (IsDifferenceInValueGreaterThanMaxdelta(values[i], values[i + 1], maxDelta))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsDifferenceInValueGreaterThanMaxdelta(double value, double nextValue, double maxDelta)
        {
            return (nextValue - value > maxDelta) ? true : false;
        }
        public static bool IsSensorReadingsListEmpty(List<Double> values)
        {
            return (values == null) ? true : false;
        }
    }
}
