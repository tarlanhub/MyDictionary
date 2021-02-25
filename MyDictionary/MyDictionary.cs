using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        List<TKey> keys;
        List<TValue> values;
        public MyDictionary()
        {
            keys = new List<TKey>();
            values = new List<TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            keys.Add(key);
            values.Add(value);
        }
        public void Control(TKey akey)
        {
            Console.WriteLine(keys.IndexOf(akey) + "Key's Value = " + values[keys.IndexOf(akey)]);
        }
    }
}
