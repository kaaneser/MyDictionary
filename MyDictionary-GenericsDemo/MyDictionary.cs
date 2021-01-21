using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary_GenericsDemo
{
    class MyDictionary<TKey, TVal>
    {
        TKey[] keys;
        TVal[] values;
        public TVal _exVal;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TVal[0];
        }

        public void Add(TKey key, TVal value)
        {
            foreach (var i in keys)
            {
                if (i.Equals(key))
                {
                    Console.WriteLine("Key zaten kullanımda");
                    return;
                }
            }

            TKey[] tempKey = keys;
            TVal[] tempVal = values;
            keys = new TKey[keys.Length + 1];
            values = new TVal[values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempVal[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public TVal Yazdir(TKey key)
        {
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i].Equals(key))
                {
                    return values[i];
                }
            }
            return _exVal;
        }

        public int Length
        {
            get { return keys.Length; }
        }
    }
}
