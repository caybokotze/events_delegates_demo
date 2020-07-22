namespace EventsAndDelegates
{
    public interface IVideoEventHandlers
    {
        void OnVideoEncoded(object source, VideoEventArgs args);
        void OnVideoEncoding(object source, VideoEventArgs args);
    }
}