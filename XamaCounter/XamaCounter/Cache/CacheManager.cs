using System.Collections.Generic;
using System.Linq;

namespace XamaCounter.Cache
{
    public static class CacheManager
    {
        private static List<ICacheSubscriber> _subscribers;
        private static (int BackgroundCounter, int TimerCounter) _data;

        static CacheManager()
        {
            _subscribers = new List<ICacheSubscriber>();
            _data = (BackgroundCounter: 0, TimerCounter: 0);
        }

        public static (int BackgroundCounter, int TimerCounter) Data
        {
            get => _data;
            private set => _data = value;
        }

        public static void Subscribe(ICacheSubscriber subscriber)
        {
            if (!_subscribers.Any(x => x.Equals(subscriber)))
            {
                _subscribers.Add(subscriber);
            }
        }

        public static void Unsubscribe(ICacheSubscriber subscriber)
        {
            if (_subscribers.Any(x => x.Equals(subscriber)))
            {
                _subscribers.Remove(subscriber);
            }
        }

        public static void Update((int BackgroundCounter, int TimerCounter) data)
        {
            _data = data;

            foreach (var subscriber in _subscribers)
            {
                subscriber.OnUpdateCacheData(_data);
            }
        }

        public static void Clear()
        {
            _data.BackgroundCounter = 0;
            _data.TimerCounter = 0;
            _subscribers.Clear();
        }
    }
}