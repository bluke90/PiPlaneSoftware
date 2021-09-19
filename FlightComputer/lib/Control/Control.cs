using FlightComputer.lib.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlightComputer.lib.Control
{
    public class Control
    {
        public float RollInput { get; set; }
        private float RollOutput { get; set; }
        public float PitchInput { get; set; }
        private float PitchOutput { get; set; }
        public float YawInput { get; set; }
        private float YawOutput { get; set; }

        private readonly NetworkModel _network;

        public Control(NetworkModel network) { _network = network; }

        public void StartControlThread()
        {
            Thread thread = new Thread(ControlInputThread); thread.Start();
            Thread thread2 = new Thread(ControlThread); thread2.Start();
        }
        private void ControlInputThread()
        {
            float Roll, Pitch, Yaw, throttle;

            while(true)
            {
                Thread.Sleep(200);
                var check = _network.DataQueue.Peek();
                var checksplit = check.Split("||");

                if (checksplit[0] != "control") continue;

                _network.DataQueue.Dequeue();
                Roll = Convert.ToInt32(checksplit[1]);
                Pitch = Convert.ToInt32(checksplit[2]);
                Yaw = Convert.ToInt32(checksplit[3]);
                throttle = Convert.ToInt32(checksplit[4]);    

            }
        }

        private void ControlThread()
        {
            float LastRoll, LastPitch, LastYaw, LastThrottle;
            LastRoll = RollInput;
            LastPitch = PitchInput;
            LastYaw = YawInput;
            while(true)
            {
                Thread.Sleep(150);
                if(!WithinMargin(RollInput, LastRoll))
                {

                }
                if(!WithinMargin(PitchInput, LastPitch))
                {

                }
                if(!WithinMargin(YawInput, LastYaw))
                {

                }
            }
        }

        private static bool WithinMargin(float current, float last)
        {
            if(current < last - .2 || current > last + .2)
            {
                return false;
            }
            return true;
        }
    }
}
