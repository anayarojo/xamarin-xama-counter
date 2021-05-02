using System;
using System.Threading.Tasks;
using Matcha.BackgroundService;
using XamaCounter.Cache;

namespace XamaCounter.Services
{
    public class CounterService : IPeriodicTask
    {
        public TimeSpan Interval { get; }

        public CounterService(int seconds)
        {
            Interval = TimeSpan.FromSeconds(seconds);
        }

        public Task<bool> StartJob()
        {
            var newData = CacheManager.Data;
            newData.BackgroundCounter += 1;
            CacheManager.Update(newData);

            return Task.FromResult(true);
        }
    }
}