using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "A");
            myDictionary.Add(2, "B");
            myDictionary.Add(2, "C");

            for (int i = 0; i < myDictionary.TKeyLength; i++)
            {
                Console.WriteLine(myDictionary.TKeys[i] + "  " + myDictionary.TValues[i]);
            }
        }
    }

    public class MyDictionary<TKey, TValue>
    {
        private TKey[] _tKey;
        private TValue[] _tValue;

        public MyDictionary()
        {
            _tKey = new TKey[0];
            _tValue = new TValue[0];
        }

        public void Add(TKey tKey, TValue tValue)
        {
            TKey[] _tempKey = _tKey;
            TValue[] _tempValue = _tValue;


            AddKey(_tempKey, tKey);

            AlraadyExistKey(tKey, _tempKey);

            AddValue(_tempValue, tValue);
        }

        private void AddValue(TValue[] tempValue, TValue tValue)
        {
            _tValue = new TValue[_tValue.Length + 1];

            for (int i = 0; i < tempValue.Length; i++)
            {
                _tValue[i] = tempValue[i];
            }

            _tValue[_tValue.Length - 1] = tValue;
        }

        private void AddKey(TKey[] tempKey, TKey tKey)
        {
            _tKey = new TKey[_tKey.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                _tKey[i] = tempKey[i];
            }

            _tKey[_tKey.Length - 1] = tKey;
        }

        private void AlraadyExistKey(TKey tKey, TKey[] _tempKey)
        {
            for (int i = 0; i < _tempKey.Length; i++)
            {
                if (Equals(tKey, _tKey[i]))
                {
                    throw new Exception("Benzer key Girilemez!.");
                }
            }
        }

        public TKey[] TKeys
        {
            get { return _tKey; }
        }

        public TValue[] TValues
        {
            get { return _tValue; }
        }

        public int TKeyLength
        {
            get { return _tKey.Length; }
        }

        public int TValueLength
        {
            get { return _tValue.Length; }
        }
    }

    //class MyDictionary<TKey, TValue>
    //{
    //    private TKey[] _tKey;
    //    private TValue[] _tValue;

    //    public MyDictionary()
    //    {
    //        _tKey = new TKey[0];
    //        _tValue = new TValue[0];
    //    }

    //    public void Add(TKey tKey, TValue tValue)
    //    {
    //        TKey[] _tempKey = _tKey;
    //        TValue[] _tempValue = _tValue;

    //        _tKey = new TKey[_tKey.Length + 1];
    //        _tValue = new TValue[_tValue.Length + 1];

    //        for (int i = 0; i < _tempKey.Length; i++)
    //        {
    //            _tKey[i] = _tempKey[i];
    //        }

    //        _tKey[_tKey.Length - 1] = tKey;

    //        AlraadyExistKey(tKey, _tempKey);

    //        for (int i = 0; i < _tempValue.Length; i++)
    //        {
    //            _tValue[i] = _tempValue[i];
    //        }

    //        _tValue[_tValue.Length - 1] = tValue;
    //    }

    //    public TKey[] TKeys
    //    {
    //        get { return _tKey; }
    //    }

    //    public TValue[] TValues
    //    {
    //        get { return _tValue; }
    //    }

    //    public int TKeyLength
    //    {
    //        get { return _tKey.Length; }
    //    }

    //    public int TKeyValue
    //    {
    //        get { return _tValue.Length; }
    //    }

    //    public void AlraadyExistKey(TKey tKey, TKey[] _tempKey)
    //    {
    //        for (int i = 0; i < _tempKey.Length; i++)
    //        {
    //            if (Equals(tKey, _tKey[i]))
    //            {
    //                throw new Exception("Benzer key Girilemez!.");
    //            }
    //        }
    //    }
    //}
}
