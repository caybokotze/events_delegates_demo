using System;

namespace EventsAndDelegates
{
    public class MessageService : IVideoEventHandlers
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Sending a SMS to confirm.");
        }

        public void OnVideoEncoding(object source, VideoEventArgs args)
        {
            Console.WriteLine("The video encoding process has started.");
        }
    }
}