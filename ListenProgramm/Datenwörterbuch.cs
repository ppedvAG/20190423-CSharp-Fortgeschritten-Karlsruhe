using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListenProgramm
{
    //https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters
    class Datenwörterbuch<T>: IEnumerable<InternalArrayType<T>> where T: struct
    {
        public T[] Keys
        {
            get
            {
                var keyArray = new T[_internalArray.Length];
                for (int i = 0; i < _internalArray.Length; i++)
                {
                    keyArray[i] = _internalArray[i].key;
                }
                    return keyArray;
            }
        }
        public string[] Values
        {
            get
            {
                var valueArray = new string[_internalArray.Length];
                for (int i = 0; i < _internalArray.Length; i++)
                {
                    valueArray[i] = _internalArray[i].value;
                }
                return valueArray;
            }
        }

        //public string[] Values {get; private set;}
        private InternalArrayType<T>[] _internalArray;

        public void Add(T key, string value)
        {
            if (_internalArray == null)
            {
                _internalArray = new InternalArrayType<T>[1];
                _internalArray[0].key = key;
                _internalArray[0].value = value;
            } else
            {
                var _internalArrayCopy = new InternalArrayType<T>[_internalArray.Length + 1];
                // Ohne Kopierkonstruktor
                for (int i = 0; i < _internalArray.Length; i++)
                {
                    _internalArrayCopy[i].key = _internalArray[i].key;
                    _internalArrayCopy[i].value = _internalArray[i].value;
                }
                _internalArrayCopy[_internalArray.Length].key = key;
                _internalArrayCopy[_internalArray.Length].value= value;
                _internalArray = _internalArrayCopy;
            }
        }
        public void Remove(T key)
        {
            var _internalArrayCopy = new InternalArrayType<T>[_internalArray.Length - 1];
            int j = 0;
            for(int i = 0; i < _internalArray.Length; i++)
            {
                if(_internalArray[i].key.Equals(key))
                {
                    continue;
                }
                _internalArrayCopy[j++] = _internalArray[i];
            }
            _internalArray = _internalArrayCopy;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<InternalArrayType<T>> GetEnumerator()
        {
            foreach(var item in _internalArray)
            {
                yield return item;
            }
        }
    }
    public struct InternalArrayType<T>
    {
        public T key;
        public string value;
    }
}
