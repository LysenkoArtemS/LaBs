using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2
{
    internal class DynamicArray<T> : IEnumerable<T>, IDisposable
    {
        private const int defaultCapacity = 8;

        private int _arrLength = 0;
        private T[] _arr;

        public delegate void DynamicArrayHandler(Object sender, EventDynamicArray e);//evArgs
        public event DynamicArrayHandler Notify;
   
        public DynamicArray()
        {
            _arr = new T[defaultCapacity];
        }
        public DynamicArray(int arrCapaity)
        {
            if (arrCapaity > 0)
            {
                _arr = new T[arrCapaity];
            }
            else
            {
                throw new ArgumentException("Capacity must be > 0");
            }
        }
        public DynamicArray(IEnumerable<T> arr)
        {
            _arr = new T[arr.Count()];
            foreach (T i in arr)
            {
                _arr[Length] = i;
                Length++;
            }
        }

        public void Add(T variable)
        {
            CheckCapacity(Length + 1);
            _arr[Length] = variable;
            Length++;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            foreach (T i in collection)
            {
                CheckCapacity(Length+1);
                _arr[Length] = i;
                Length++;
            }
        }
        public bool Remove(T unit, Func<T, T, bool> p = null)//
        {
            bool checK = false;
            if (p == null)
            {//func+
                for (var i = 0; i < Length - 1; i++)
                {
                    if (_arr[i].Equals(unit))
                    {
                        checK = true;
                        for (; i < Length - 1; i++)
                        {
                            _arr[i] = _arr[i + 1];
                        }
                        Length--;
                    }
                    _arr[Length] = default;
                }
            }
            else
            {
                for (int i = 0; i < Length - 1; i++)
                {
                    if (p(_arr[i],unit))
                    {
                        checK = true;
                        for (; i < Length - 1 ; i++)
                        {
                            _arr[i] = _arr[i + 1];
                        }
                        Length--;
                        _arr[Length] = default;
                    }
                }
            }
            return checK;
        }
        public void Insert(int pos, T unit)
        {
            CheckIndex(pos);
            CheckCapacity(Length + 1);
            for (int i = Length - 1 ; i >= pos; i--)
            {
                _arr[i + 1] = _arr[i];
            }
            _arr[pos] = unit;
            Length++;
            
        }
        public int Length
        {
            get
            {
                return _arrLength;
            }
            set
            {
                _arrLength = value;
            }
        }
        public int Capacity => _arr.Length;

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new IEnumeratorDynamicArray<T>(_arr);
        }
        public T this[int index]
        {
            get
            {
                CheckIndex(index);
                return _arr[index];
            }
            set
            {
                CheckIndex(index);
                _arr[index] = value;
            }
        }
        private void CheckIndex(int index)
        {
            if (index >= Length || index < 0)
            {
                throw new ArgumentOutOfRangeException("Index out of range");
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is DynamicArray<T>)
            {
                var value = obj as DynamicArray<T>;

                if (Length != value.Length)
                {
                    return false;
                }
                for (int i = 0; i < Length; i++)
                {
                    if (!(_arr[i].Equals((value)[i])))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public static bool operator == (DynamicArray<T> firstArray, DynamicArray<T> secondArray)
        {
            return firstArray.Equals(secondArray);
        }
        public static bool operator !=(DynamicArray<T> firstArray, DynamicArray<T> secondArray)
        {
            return !firstArray.Equals(secondArray);
        }

        public static explicit operator T[](DynamicArray<T> array)
        {
            return array._arr.Clone() as T[];
        }

        public static implicit operator DynamicArray<T>(T[] array)
        {
            return new DynamicArray<T>(array);
        }


        private bool _disposed = false;

        public void Dispose()////
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }
            if (disposing)
            {
                foreach (var item in _arr)
                {
                    if (item is IDisposable)
                    {
                        ((IDisposable)item).Dispose();
                    }
                }
                Notify?.Invoke(this, new EventDynamicArray(Capacity, 0));//
                Array.Clear(_arr,0,Length-1);
                Length = 0;
            }
            _disposed = true;
        }

        ~DynamicArray()
        {
            Dispose(false);
        }
        //========================================================
        private void CheckCapacity(int cap)
        {
            int capasity = Capacity;
            if (capasity < cap)
            {
                while (capasity < cap)
                {                 
                    capasity *= 2;
                    
                }
                Notify?.Invoke(this, new EventDynamicArray(Capacity, capasity));//
                Array.Resize(ref _arr, capasity);
            }
        }
        public void PrintArr()
        {
            for (int i = 0; i < Capacity; i++)
            {
                Console.Write(" {0}", _arr[i]);
            }
            Console.WriteLine("\nCapacity {0}", Capacity);
            Console.WriteLine("Length {0}", Length);
        }
    }
}
