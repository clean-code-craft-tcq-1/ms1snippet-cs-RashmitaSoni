using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xunit;

namespace SensorValidate.Tests
{
    public static class SensorValidatorTest
    {
        static double socmaxdelta = 0.05;
        static double currentmaxdelta = 0.1;
        [Fact]
        public static void ReportsErrorWhenSOCJumps()
        {
            Assert.False(SensorValidator.ValidateSensorMeasureReadings(
                new List<double> { 0.0, 0.01, 0.5, 0.51 }, socmaxdelta
            ));
        }
        [Fact]
        public static void ReportsErrorWhenCurrentJumps()
        {
            Assert.False(SensorValidator.ValidateSensorMeasureReadings(
                new List<double> { 0.03, 0.03, 0.03, 0.33 }, currentmaxdelta
            ));
        }
        [Fact]
        public static void ReportsErrorWhenSOCEmpty()
        {
            Assert.True(SensorValidator.ValidateSensorMeasureReadings(
                new List<double> { }, socmaxdelta
            ));
        }
        [Fact]
        public static void ReportsErrorWhenCurrentEmpty()
        {
            Assert.True(SensorValidator.ValidateSensorMeasureReadings(
                new List<double> { }, currentmaxdelta
            ));
        }
    } 
}
