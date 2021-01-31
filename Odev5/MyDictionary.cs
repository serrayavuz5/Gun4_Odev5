using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        //tepmArray = geçici dizi
        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeys = keys;
            TValue[] tempValue = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            for (int i = 0; i < tempValue.Length; i++)
            {
                values[i] = tempValue[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public TKey[] Keys
        {
            get { return keys; }
        }
        public TValue[] Values
        {
            get { return values; }
        }
    }
}
