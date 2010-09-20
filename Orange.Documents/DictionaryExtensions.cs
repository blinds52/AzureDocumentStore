﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orange.Documents
{
    static class DictionaryExtensions
    {
        public static TValue GetOrAdd<TKey,TValue>(this IDictionary<TKey,TValue> dictionary, TKey key)
            where TValue : new()
        {
            TValue value;

            if (!dictionary.TryGetValue(key, out value))
            {
                value = new TValue();
                dictionary.Add(key, value);
            }

            return value;
        }
    }
}
