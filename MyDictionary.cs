using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
  public  class MyDictionary<TKey, TValue>
    {
        TKey[] _keyArray;
        TKey[] _tempKey;
        TValue[] _valueArray;
        TValue[] _tempValue;

        public MyDictionary()
        {
            _keyArray = new TKey[0];
            _valueArray = new TValue[0];

        }
        public void Add(TKey key,TValue value)
        {
            _tempKey = _keyArray;
            _keyArray = new TKey[_keyArray.Length + 1];

            _tempValue = _valueArray;
            _valueArray = new TValue[_valueArray.Length + 1];
            for (int i = 0; i < _tempKey.Length; i++)
            {
                _keyArray[i] = _tempKey[i];
                _valueArray[i] = _tempValue[i];

            }
            _keyArray[_keyArray.Length - 1] = key;
            _valueArray[_valueArray.Length - 1] = value;

            Console.WriteLine("Plaka: " + key + " " + "Şehir: " + value);
        }
    
        public TKey[] Keys
        {
            get { return _keyArray; }
        }
        public TValue[] Values
        {
            get { return _valueArray; }
        }

    }
}
