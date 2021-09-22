using MMALSharp;
using MMALSharp.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlightComputer.lib.Camera
{
    class Camera
    {
        public async Task TakeVideo()
        {
            // Singleton initialized lazily. Reference once in your application.
            MMALCamera cam = MMALCamera.Instance;
            
            using (var vidCaptureHandler = new VideoStreamCaptureHandler("/home/plane/videos/", "avi"))
            {
                var cts = new CancellationTokenSource(TimeSpan.FromMinutes(3));

                await cam.TakeVideo(vidCaptureHandler, cts.Token);
            }

            // Cleanup disposes all unmanaged resources and unloads Broadcom library. To be called when no more processing is to be done
            // on the camera.
            cam.Cleanup();
        }
    }
}
