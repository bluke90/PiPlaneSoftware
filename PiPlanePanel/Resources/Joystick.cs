using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Windows.Gaming.Input;


namespace PiPlanePanel.Resources
{
    class Joystick
    {
        public FlightStick Stick { get; set; }
        public RawGameController rawStick { get; set; }
        public double Roll { get; set; }
        public double Pitch { get; set; }
        public double Yaw { get; set; }
        public double Throttle { get; set; }
        private Thread Thread { get; set; }

        public Joystick()
        {
            rawStick = RawGameController.RawGameControllers.First();
            Stick = FlightStick.FromGameController(rawStick);
        }

        public void StartUpdateThread()
        {
            Thread = new Thread(UpdateThread);
            Thread.Start();
        }

        private void UpdateThread()
        {
            while(true)
            {
                GetAxis();
                Thread.Sleep(100);
            }
        }

        public (double, double) GetAxis()
        {
            double[] axiss = new double[5];
            bool[] buttons = new bool[10];
            GameControllerSwitchPosition[] switchPosition = new GameControllerSwitchPosition[2];

            var state = rawStick.GetCurrentReading(buttons, switchPosition, axiss);

            Roll = Math.Round(axiss[0], 10);
            Pitch = Math.Round(axiss[1], 10);
            Yaw = Math.Round(axiss[2], 10);
            Throttle = Math.Round(axiss[3], 10);

            return (Roll, Pitch);
        }



    }
}
