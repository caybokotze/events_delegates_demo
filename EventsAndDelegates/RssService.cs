using System;

namespace EventsAndDelegates
{
    public class RssService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("This is a RSS feed message to let you know that the video has completed the encoding process.");
        }

        public void OnVideoEncoding(object source, VideoEventArgs args)
        {
            throw new System.NotImplementedException();
        }
    }
}