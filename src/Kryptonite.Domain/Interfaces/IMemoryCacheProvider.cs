﻿namespace Kryptonite.Domain.Interfaces {
    public interface IMemoryCacheProvider {
        T GetFromCache<T>(string key) where T : class;
        void SetCache<T>(string key, T value) where T : class;
        void SetCache<T>(string key, T value, DateTimeOffset duration) where T : class;
        void ClearCache(string key);
    }
}
