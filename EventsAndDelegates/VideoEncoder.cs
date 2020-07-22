using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoding; 
        
        public void Encode(Video video)
        {
            Console.WriteLine($"Encoding Video {video.Title}");
            OnVideoEncoding(video);
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs(){ Video = video });
            }
        }

        protected virtual void OnVideoEncoding(Video video)
        {
            if (VideoEncoding != null)
            {
                VideoEncoding(this, new VideoEventArgs(){ Video = video });
            }
        }
        
    }

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}