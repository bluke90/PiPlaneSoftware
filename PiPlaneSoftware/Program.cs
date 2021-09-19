using PiPlaneSoftware.Resources;
using System;

namespace PiPlaneSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            var stick = new Stick();

            while(true)
            {
                stick.GetAxis();
            }
        }
    }
}
