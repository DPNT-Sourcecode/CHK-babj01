using System.Collections.Generic;

namespace BeFaster.App.Solutions.CHK
{
    public static class DictionaryExtensions
    {
        public static TValue GetValueOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key)
        {
            if (!dictionary.TryGetValue(key, out var value))
            {
                value = default;
            }

            return value;
        }
    }
}
