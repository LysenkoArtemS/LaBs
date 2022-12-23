using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    public class IEnumeratorDynamicArray<T> : IEnumerator<T>//length svoistvo
    {
        private T[] _array;
        private int _length = -1;
        private int _position = -1;
        public IEnumeratorDynamicArray(T[] array, int length)
        {
            _array = array;
            _length = length;
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
            if (_position < _length - 1)
            {
                _position++;
                return true;
            }
            return false;
        }

        public void Reset() => _position = -1;

        private T CurrentRealization()
        {
            if (_position == -1 || _position >= _length)
            {
                throw new ArgumentOutOfRangeException("Error in Enumerator");
            }
            return _array[_position];
        }
    }
}
