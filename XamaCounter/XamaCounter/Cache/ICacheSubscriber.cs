namespace XamaCounter.Cache
{
    public interface ICacheSubscriber
    {
        void OnUpdateCacheData((int BackgroundCounter, int TimerCounter) data);
    }
}