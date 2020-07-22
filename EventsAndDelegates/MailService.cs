using System;

namespace EventsAndDelegates
{
    public class MailService : IVideoEventHandlers
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"MailService: Sending an email for: {e.Video.Title}");
        }

        public void OnVideoEncoding(object source, VideoEventArgs args)
        {
            Console.WriteLine("The video has begun encoding process. hang tight. ;)");
        }

        public void OnVideoEncrypted(object source, VideoEventArgs e)
        {
            Console.WriteLine("The email was sent that the video was encrypted.");
        }
    }
}