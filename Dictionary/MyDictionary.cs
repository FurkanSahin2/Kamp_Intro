using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    internal class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey tKey, TValue tValue)
        {
            TKey[] keyTempArray = new TKey[0];
            TValue[] valueTempArray = new TValue[0];

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < keyTempArray.Length; i++)
            {
                keys[i] = keyTempArray[i];
            }
            keys[keys.Length - 1] = tKey;

            for (int i = 0; i < valueTempArray.Length; i++)
            {
                values[i] = valueTempArray[i];
            }
            values[values.Length - 1] = tValue;

            Console.WriteLine(tKey + ". " + tValue);
        }

        public int Length
        {
            get { return keys.Length; }
        }
        public TValue[] Values
        {
            get { return values; }
        }
        public TKey[] Keys
        {
            get { return keys; }
        }
    }
}
