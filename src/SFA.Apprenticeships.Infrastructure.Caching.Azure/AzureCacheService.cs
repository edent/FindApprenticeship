﻿namespace SFA.Apprenticeships.Infrastructure.Caching.Azure
{
    using System;
    using Microsoft.ApplicationServer.Caching;
    using Domain.Interfaces.Caching;
    using NLog;

    public class AzureCacheService : ICacheService
    {
        private const string GettingItemFromCacheFormat = "Getting item with key: {0} from cache";
        private const string ItemReturnedFromCacheFormat = "Item with key: {0} returned from cache";
        private const string ItemNotInCacheFormat = "Item with key: {0} not in cache";

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private readonly DataCache _cache;

        public AzureCacheService()
        {
            var cacheFactory = new DataCacheFactory();
            _cache = cacheFactory.GetDefaultCache();
        }

        private void Store(string key, object value, CacheDuration cacheDuration)
        {
            Logger.Debug("Storing item with key: {0} in cache with duration: {1}", key, cacheDuration);

            if (value == null)
            {
                return;
            }

            TimeSpan cacheTimeSpan;

            if (cacheDuration == CacheDuration.Midnight)
            {
                var midnight = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
                cacheTimeSpan = new TimeSpan(midnight.Ticks - DateTime.Now.Ticks);
            }
            else
            {
                cacheTimeSpan = TimeSpan.FromMinutes((int)cacheDuration);    
            }

            _cache.Add(key, value, cacheTimeSpan);

            Logger.Debug("Stored item with key: {0} in cache with timespan: {1}", key, cacheTimeSpan);
        }

        public T Get<T>(string key) where T : class
        {
            Logger.Debug(GettingItemFromCacheFormat, key);

            var result = _cache[key] as T;

            if (result == null)
            {
                Logger.Debug(ItemNotInCacheFormat, key);
            }

            return result;
        }

        private void Remove(string key)
        {
            Logger.Debug("Removing item with key: {0} from cache", key);

            _cache.Remove(key);
        }

        public void FlushAll()
        {
            Logger.Debug("Flushing cache");

            _cache.Clear();

            Logger.Debug("Flushed cache");
        }

        #region Get

        public TResult Get<TCacheKey, TResult>(TCacheKey cacheEntry, Func<TResult> dataFunc)
            where TCacheKey : BaseCacheKey
            where TResult : class
        {
            var cacheKey = cacheEntry.Key();

            Logger.Debug(GettingItemFromCacheFormat, cacheKey);

            var result = _cache[cacheKey] as TResult;
            if (result == null || result.Equals(default(TResult)))
            {
                Logger.Debug(ItemNotInCacheFormat, cacheKey);

                result = dataFunc();
                Store(cacheKey, result, cacheEntry.Duration);
                return result;
            }

            Logger.Debug(ItemReturnedFromCacheFormat, cacheKey);

            return result;
        }

        public TResult Get<TCacheKey, TFuncParam1, TResult>(TCacheKey cacheEntry, Func<TFuncParam1, TResult> dataFunc, TFuncParam1 funcParam1)
                        where TCacheKey : BaseCacheKey
            where TResult : class
        {
            var cacheKey = cacheEntry.Key(funcParam1);

            Logger.Debug(GettingItemFromCacheFormat, cacheKey);

            var result = _cache[cacheKey] as TResult;
            if (result == null || result.Equals(default(TResult)))
            {
                Logger.Debug(ItemNotInCacheFormat, cacheKey);

                result = dataFunc(funcParam1);
                Store(cacheKey, result, cacheEntry.Duration);
                return result;
            }

            Logger.Debug(ItemReturnedFromCacheFormat, cacheKey);

            return result;
        }

        public TResult Get<TCacheKey, TFuncParam1, TFuncParam2, TResult>(TCacheKey cacheEntry, Func<TFuncParam1, TFuncParam2, TResult> dataFunc, TFuncParam1 funcParam1, TFuncParam2 funcParam2)
            where TCacheKey : BaseCacheKey
            where TResult : class
        {
            var cacheKey = cacheEntry.Key(funcParam1, funcParam2);

            Logger.Debug(GettingItemFromCacheFormat, cacheKey);

            var result = _cache[cacheKey] as TResult;
            if (result == null || result.Equals(default(TResult)))
            {
                Logger.Debug(ItemNotInCacheFormat, cacheKey);

                result = dataFunc(funcParam1, funcParam2);
                Store(cacheKey, result, cacheEntry.Duration);
                return result;
            }

            Logger.Debug(ItemReturnedFromCacheFormat, cacheKey);

            return result;
        }

        public TResult Get<TCacheKey, TFuncParam1, TFuncParam2, TFuncParam3, TResult>(TCacheKey cacheEntry, Func<TFuncParam1, TFuncParam2, TFuncParam3, TResult> dataFunc, TFuncParam1 funcParam1, TFuncParam2 funcParam2, TFuncParam3 funcParam3)
            where TCacheKey : BaseCacheKey
            where TResult : class
        {
            var cacheKey = cacheEntry.Key(funcParam1, funcParam2, funcParam3);

            Logger.Debug(GettingItemFromCacheFormat, cacheKey);

            var result = _cache[cacheKey] as TResult;
            if (result == null || result.Equals(default(TResult)))
            {
                Logger.Debug(ItemNotInCacheFormat, cacheKey);

                result = dataFunc(funcParam1, funcParam2, funcParam3);
                Store(cacheKey, result, cacheEntry.Duration);
                return result;
            }

            Logger.Debug(ItemReturnedFromCacheFormat, cacheKey);

            return result;
        }

        public TResult Get<TCacheKey, TFuncParam1, TFuncParam2, TFuncParam3, TFuncParam4, TResult>(TCacheKey cacheEntry, Func<TFuncParam1, TFuncParam2, TFuncParam3, TFuncParam4, TResult> dataFunc, TFuncParam1 funcParam1, TFuncParam2 funcParam2, TFuncParam3 funcParam3, TFuncParam4 funcParam4)
            where TCacheKey : BaseCacheKey
            where TResult : class
        {
            var cacheKey = cacheEntry.Key(funcParam1, funcParam2, funcParam3, funcParam4);
            
            Logger.Debug(GettingItemFromCacheFormat, cacheKey);

            var result = _cache[cacheKey] as TResult;
            if (result == null || result.Equals(default(TResult)))
            {
                Logger.Debug(ItemNotInCacheFormat, cacheKey);

                result = dataFunc(funcParam1, funcParam2, funcParam3, funcParam4);
                Store(cacheKey, result, cacheEntry.Duration);
                return result;
            }

            Logger.Debug(ItemReturnedFromCacheFormat, cacheKey);

            return result;
        }

        public TResult Get<TCacheKey, TFuncParam1, TFuncParam2, TFuncParam3, TFuncParam4, TFuncParam5, TResult>(TCacheKey cacheEntry, Func<TFuncParam1, TFuncParam2, TFuncParam3, TFuncParam4, TFuncParam5, TResult> dataFunc, TFuncParam1 funcParam1, TFuncParam2 funcParam2, TFuncParam3 funcParam3, TFuncParam4 funcParam4, TFuncParam5 funcParam5)
            where TCacheKey : BaseCacheKey
            where TResult : class
        {
            var cacheKey = cacheEntry.Key(funcParam1, funcParam2, funcParam3, funcParam4, funcParam5);

            Logger.Debug(GettingItemFromCacheFormat, cacheKey);

            var result = _cache[cacheKey] as TResult;
            if (result == null || result.Equals(default(TResult)))
            {
                Logger.Debug(ItemNotInCacheFormat, cacheKey);

                result = dataFunc(funcParam1, funcParam2, funcParam3, funcParam4, funcParam5);
                Store(cacheKey, result, cacheEntry.Duration);
                return result;
            }

            Logger.Debug(ItemReturnedFromCacheFormat, cacheKey);

            return result;
        }

        public TResult Get<TCacheKey, TFuncParam1, TFuncParam2, TFuncParam3, TFuncParam4, TFuncParam5, TFuncParam6, TResult>(TCacheKey cacheEntry, Func<TFuncParam1, TFuncParam2, TFuncParam3, TFuncParam4, TFuncParam5, TFuncParam6, TResult> dataFunc, TFuncParam1 funcParam1, TFuncParam2 funcParam2, TFuncParam3 funcParam3, TFuncParam4 funcParam4, TFuncParam5 funcParam5, TFuncParam6 funcParam6)
            where TCacheKey : BaseCacheKey
            where TResult : class
        {
            var cacheKey = cacheEntry.Key(funcParam1, funcParam2, funcParam3, funcParam4, funcParam5, funcParam6);

            Logger.Debug(GettingItemFromCacheFormat, cacheKey);

            var result = _cache[cacheKey] as TResult;
            if (result == null || result.Equals(default(TResult)))
            {
                Logger.Debug(ItemNotInCacheFormat, cacheKey);

                result = dataFunc(funcParam1, funcParam2, funcParam3, funcParam4, funcParam5, funcParam6);
                Store(cacheKey, result, cacheEntry.Duration);
                return result;
            }

            Logger.Debug(ItemReturnedFromCacheFormat, cacheKey);

            return result;
        }

        #endregion

        #region Put

        public void Put<TCacheKey, TResult, TFuncParam1>(TCacheKey cacheEntry, TResult result, TFuncParam1 funcParam1)
            where TCacheKey : BaseCacheKey
            where TResult : class
        {
            var cacheKey = cacheEntry.Key(funcParam1);
            Store(cacheKey, result, cacheEntry.Duration);
        }

        public void Put<TCacheKey, TResult, TFuncParam1, TFuncParam2>(TCacheKey cacheEntry, TResult result, TFuncParam1 funcParam1, TFuncParam2 funcParam2)
            where TCacheKey : BaseCacheKey
            where TResult : class
        {
            var cacheKey = cacheEntry.Key(funcParam1, funcParam2);
            Store(cacheKey, result, cacheEntry.Duration);
        }

        public void Put<TCacheKey, TResult, TFuncParam1, TFuncParam2, TFuncParam3>(TCacheKey cacheEntry, TResult result, TFuncParam1 funcParam1, TFuncParam2 funcParam2, TFuncParam3 funcParam3)
            where TCacheKey : BaseCacheKey
            where TResult : class
        {
            var cacheKey = cacheEntry.Key(funcParam1, funcParam2, funcParam3);
            Store(cacheKey, result, cacheEntry.Duration);
        }

        public void Put<TCacheKey, TResult, TFuncParam1, TFuncParam2, TFuncParam3, TFuncParam4>(TCacheKey cacheEntry, TResult result, TFuncParam1 funcParam1, TFuncParam2 funcParam2, TFuncParam3 funcParam3, TFuncParam4 funcParam4)
            where TCacheKey : BaseCacheKey
            where TResult : class
        {
            var cacheKey = cacheEntry.Key(funcParam1, funcParam2, funcParam3, funcParam4);
            Store(cacheKey, result, cacheEntry.Duration);
        }

        public void Put<TCacheKey, TResult, TFuncParam1, TFuncParam2, TFuncParam3, TFuncParam4, TFuncParam5>(TCacheKey cacheEntry, TResult result, TFuncParam1 funcParam1, TFuncParam2 funcParam2, TFuncParam3 funcParam3, TFuncParam4 funcParam4, TFuncParam5 funcParam5)
            where TCacheKey : BaseCacheKey
            where TResult : class
        {
            var cacheKey = cacheEntry.Key(funcParam1, funcParam2, funcParam3, funcParam4, funcParam5);
            Store(cacheKey, result, cacheEntry.Duration);
        }

        public void Put<TCacheKey, TResult, TFuncParam1, TFuncParam2, TFuncParam3, TFuncParam4, TFuncParam5, TFuncParam6>(TCacheKey cacheEntry, TResult result, TFuncParam1 funcParam1, TFuncParam2 funcParam2, TFuncParam3 funcParam3, TFuncParam4 funcParam4, TFuncParam5 funcParam5, TFuncParam6 funcParam6)
            where TCacheKey : BaseCacheKey
            where TResult : class
        {
            var cacheKey = cacheEntry.Key(funcParam1, funcParam2, funcParam3, funcParam4, funcParam5, funcParam6);
            Store(cacheKey, result, cacheEntry.Duration);
        }

        #endregion

        #region Remove

        public void Remove<TCacheKey, TFuncParam1>(TCacheKey cacheEntry, TFuncParam1 funcParam1) where TCacheKey : BaseCacheKey
        {
            Remove(cacheEntry.Key(funcParam1));
        }

        public void Remove<TCacheKey, TFuncParam1, TFuncParam2>(TCacheKey cacheEntry, TFuncParam1 funcParam1, TFuncParam2 funcParam2) where TCacheKey : BaseCacheKey
        {
            Remove(cacheEntry.Key(funcParam1, funcParam2));
        }

        public void Remove<TCacheKey, TFuncParam1, TFuncParam2, TFuncParam3>(TCacheKey cacheEntry, TFuncParam1 funcParam1, TFuncParam2 funcParam2, TFuncParam3 funcParam3) where TCacheKey : BaseCacheKey
        {
            Remove(cacheEntry.Key(funcParam1, funcParam2, funcParam3));
        }

        public void Remove<TCacheKey, TFuncParam1, TFuncParam2, TFuncParam3, TFuncParam4>(TCacheKey cacheEntry, TFuncParam1 funcParam1, TFuncParam2 funcParam2, TFuncParam3 funcParam3, TFuncParam4 funcParam4) where TCacheKey : BaseCacheKey
        {
            Remove(cacheEntry.Key(funcParam1, funcParam2, funcParam3, funcParam4));
        }

        public void Remove<TCacheKey, TFuncParam1, TFuncParam2, TFuncParam3, TFuncParam4, TFuncParam5>(TCacheKey cacheEntry, TFuncParam1 funcParam1, TFuncParam2 funcParam2, TFuncParam3 funcParam3, TFuncParam4 funcParam4, TFuncParam5 funcParam5) where TCacheKey : BaseCacheKey
        {
            Remove(cacheEntry.Key(funcParam1, funcParam2, funcParam3, funcParam4, funcParam5));
        }

        public void Remove<TCacheKey, TFuncParam1, TFuncParam2, TFuncParam3, TFuncParam4, TFuncParam5, TFuncParam6>(TCacheKey cacheEntry, TFuncParam1 funcParam1, TFuncParam2 funcParam2, TFuncParam3 funcParam3, TFuncParam4 funcParam4, TFuncParam5 funcParam5, TFuncParam6 funcParam6) where TCacheKey : BaseCacheKey
        {
            Remove(cacheEntry.Key(funcParam1, funcParam2, funcParam3, funcParam4, funcParam5, funcParam6));
        }

        #endregion
    }
}
