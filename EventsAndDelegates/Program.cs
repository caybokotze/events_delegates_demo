using System.Net;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video()
            {
                Title = "Around the World in ..."
            };
            VideoEncoder encoder = new VideoEncoder();
            var mailservice = new MailService();
            var messageService = new MessageService();
            var rssService = new RssService();
            encoder.VideoEncoded += mailservice.OnVideoEncoded;
            encoder.VideoEncoded += messageService.OnVideoEncoded;
            encoder.VideoEncoding += messageService.OnVideoEncoding;
            encoder.VideoEncoded += rssService.OnVideoEncoded;
            encoder.Encode(video);
        }
    }
}