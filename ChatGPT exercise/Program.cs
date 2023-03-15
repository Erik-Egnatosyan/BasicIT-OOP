namespace ChatGPT_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AudioPlayer audioplayer = new AudioPlayer();
            VideoPlayer videoPlayer = new VideoPlayer();
            audioplayer.Play();
            audioplayer.Pause();
            audioplayer.Stop();
            videoPlayer.Play();
            videoPlayer.Stop();
            videoPlayer.Pause();
        }
    }
}