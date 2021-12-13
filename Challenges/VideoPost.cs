using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Challenges
{
    public class VideoPost
    {
        private Timer timer;
        private static int tickSpan = 1000;
        public VideoPost() { }
        public void Start()
        {
            SetTimer();
        }
        public void Stop()
        {
            timer.Stop();
            timer.Dispose();
        }
        private void SetTimer ()
        {
            timer = new Timer(tickSpan);
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            TimeSpan elapsed = DateTime.Now.Subtract(e.SignalTime);
            Console.WriteLine("{0:ss} seconds elapsed", elapsed);
        }
    }
}
