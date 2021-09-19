
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Windows.Gaming.Input;

namespace PiPlaneSoftware.Resources
{
    public class Stick
    {
        public FlightStick Joystick { get; set; }
        public double AxisX { get; set; }
        public double AxisY { get; set; }


        public Stick()
        {
            FlightStick.FlightStickAdded += FlightStick_FlightStickAdded;
            FlightStick.FlightStickRemoved += FlightStick_FlightStickRemoved;

            if (FlightStick.FlightSticks.Count > 0)
            {
                Joystick = FlightStick.FlightSticks.First();
            }
        }

        private void FlightStick_FlightStickRemoved(object sender, FlightStick e)
        {
            throw new NotImplementedException();
        }

        private void FlightStick_FlightStickAdded(object sender, FlightStick e)
        {
            throw new NotImplementedException();
        }

        public void GetAxis()
        {
            var state = Joystick.GetCurrentReading();
            AxisX = state.Pitch;
            AxisY = state.Roll;

            Console.WriteLine($"Axis-X: {AxisX} | Axis-Y: {AxisY}");
        }
    }



    public static class JoystickRes
    {  
    }
}
