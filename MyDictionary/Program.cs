using System;

internal class Program
{
    private static void Main(string[] args)
    {
        MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
        myDictionary.Add("Kerem", 35);
        myDictionary.Add("Zeliha", 36);
        myDictionary.Add("Derin", 7);
        myDictionary.Add("Ada", 1);

        string[] keys = myDictionary.Keys;
        int[] values = myDictionary.Values;

        for (int i = 0; i < keys.Length; i++)
        {
            Console.WriteLine("İsim: " + keys[i] + " " + "Yaş: " + values[i]);
        }

    }

    public class MyDictionary<Key, Value>
    {
        Key[] _key;
        Value[] _value;

        public MyDictionary() { 
        
        _key = new Key[0];
        _value = new Value[0];

        }

        public void Add(Key key, Value value)
        {
            Key[] tempKey = _key;
            _key = new Key[_key.Length + 1];

            Value[] tempValue = _value;
            _value = new Value[_value.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                _key[i] = tempKey[i];
            }

            for (int i = 0; i < tempValue.Length; i++)
            {
                _value[i] = tempValue[i];
            }

            _key[_key.Length-1] = key;
            _value[_value.Length-1] = value;

        }

        public Key[] Keys 
        { 
            get { return _key; } 
        }

        public Value[] Values 
        { 
            get { return _value; } 
        }
    }


}