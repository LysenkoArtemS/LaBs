using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class IEnumeratorDynamicArray<T> : IEnumerator<T>
    {
        private T[] _array;
        private int _position = -1;
        public IEnumeratorDynamicArray(T[] array)
        {
            _array = array;
        }
        public T Current
        {
            get
            {
                return CurrentRealization();
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return CurrentRealization();
            }
        }

        public void Dispose() { } 

        public bool MoveNext()
        {
            if (_position < _array.Length - 1)
            {
                _position++;
                return true;
            }
            return false;
        }

        public void Reset() => _position = -1;

        private T CurrentRealization()
        {
            if (_position == -1 || _position >= _array.Length)
            {
                throw new ArgumentOutOfRangeException("Error in Enumerator");
            }
            return _array[_position];
        }
    }
}
