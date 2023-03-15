using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPT_exercise
{
    internal class VideoPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Video player is playing");
        }
        public void Pause()
        {
            Console.WriteLine("Video player is paused");
        }
        public void Stop()
        {
            Console.WriteLine("Video player is stopped");
        }
    }
}
