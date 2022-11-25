using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Animations;
using Microsoft.Maui.Devices.Sensors;

namespace LapTimer.Data
{
    public class AccelerometerWrapper
    {
        public AccelerometerData AccelerometerValue { get; set; }

        public AccelerometerWrapper()
        {
            SensorStop();
        }

        public void SensorStart() 
        {
            if (IsUnMonitoring())
            {
                Accelerometer.Default.ReadingChanged += Accelerometer_ReadingChanged;
                Accelerometer.Default.Start(SensorSpeed.UI);
            }
        }

        public void SensorStop()
        {
            if (IsMonitoring())
            {
                Accelerometer.Default.Stop();
                Accelerometer.Default.ReadingChanged -= Accelerometer_ReadingChanged;
            }
        }


        private void Accelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
        {
            AccelerometerValue = e.Reading;
        }

        private bool IsMonitoring()
        {
            return Accelerometer.IsSupported && Accelerometer.IsMonitoring;
        }

        private bool IsUnMonitoring()
        {
            return Accelerometer.IsSupported && !Accelerometer.IsMonitoring;
        }
    }
}
