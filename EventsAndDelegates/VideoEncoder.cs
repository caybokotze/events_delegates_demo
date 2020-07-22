using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        //Longer Way
        public delegate void VideoEncryptedEventHandler(object source, VideoEventArgs args);
        public event VideoEncryptedEventHandler VideoEncrypted;

        //Short Way
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoding; 
        
        public void Encode(Video video)
        {
            Console.WriteLine($"Encoding Video {video.Title}");
            OnVideoEncoding(video);
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }

        public void Encrypt(Video video)
        {
            Console.WriteLine("Encrypting Video...");
            Thread.Sleep(3000);
            OnVideoEncrypted(video);
        }

        protected virtual void OnVideoEncrypted(Video video)
        {
            if (VideoEncrypted != null)
            {
                VideoEncrypted(this, new VideoEventArgs(){ Video = video });
            }
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