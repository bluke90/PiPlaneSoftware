using FlightComputer.lib.Network;
using FlightComputer.lib.Serial;
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
        private readonly SerialComms _serial;

        public Control(NetworkModel network, SerialComms serial) { _serial = serial; _network = network; }

        public void StartControlThread()
        {
            Thread thread = new Thread(ControlThread); thread.Start();
        }
        private Task CheckControlInput()
        {
            float throttle;
            var check = _network.DataQueue.Peek();
            var checksplit = check.Split("||");

            if (checksplit[0] == "control")
            {
                _network.DataQueue.Dequeue();
                RollInput = Convert.ToInt32(checksplit[1]);
                PitchInput = Convert.ToInt32(checksplit[2]);
                YawInput = Convert.ToInt32(checksplit[3]);
                throttle = Convert.ToInt32(checksplit[4]);
            }
            return Task.CompletedTask;
        }

        private void ControlThread()
        {
            float LastRoll, LastPitch, LastYaw, LastThrottle;
            LastRoll = RollInput;
            LastPitch = PitchInput;
            LastYaw = YawInput;
            while(true)
            {
                Thread.Sleep(200);
                var inputCheck = CheckControlInput();
                inputCheck.Wait();
                if(!WithinMargin(RollInput, LastRoll))
                {
                    
                }
                if(!WithinMargin(PitchInput, LastPitch))
                {
                    _serial.Send($"control||pitch||{PitchInput}");
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
