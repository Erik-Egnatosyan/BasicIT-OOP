using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPT_exercise
{
    internal class AudioPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Audio player is playing");
        }
        public void Pause()
        {
            Console.WriteLine("Audio player is paused");
        }
        public void Stop()
        {
            Console.WriteLine("Audio player is stopped");
        }
    }
}
