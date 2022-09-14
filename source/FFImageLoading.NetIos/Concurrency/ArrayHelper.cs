using System.Collections.Generic;

namespace FFImageLoading.Concurrency
{
    internal static class ArrayHelper
    {
        public static KeyValuePair<TKey, TValue>[] Empty<TKey, TValue>()
        {
            return Array.Empty<KeyValuePair<TKey, TValue>>();
        }
    }
}

