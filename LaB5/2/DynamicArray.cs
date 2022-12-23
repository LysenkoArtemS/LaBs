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
    public class DynamicArray<T> : IEnumerable<T>, IDisposable, ICollection
    {
        private const int defaultCapacity = 8;

        private int _arrLength = 0;
        private T[] _arr;

        public delegate void DynamicArrayHandler(Object sender, EventDynamicArray e);
        public event DynamicArrayHandler Notify;
        //
        private int GetLengthCollection(IEnumerable<Type> collection)
        {
            int length = 0;

            foreach (var item in collection)
            {
                length++;
            }

            return length;
        }

        public void CopyTo(Array array, int index)
        {
            foreach (T item in array)
            {
                _arr[index] = item;
                index++;
            }
        }
        public int Count => Length;

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();
        //
        public DynamicArray()
        {
            _arr = new T[defaultCapacity];
        }
        public DynamicArray(int arrCapaity)
        {
            if (arrCapaity >= 0)
            {
                _arr = new T[arrCapaity];
            }
            else
            {
                throw new ArgumentException();
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
        public bool Remove(T unit, Func<T, T, bool> p = null)
        {
            bool checK = false;
            if (p == null)
            {
                for (var i = 0; i < Length; i++)
                {
                    if (_arr[i].Equals(unit))
                    {
                        checK = true;
                        DeleteElement(i);
                    }
                }
            }
            else
            {
                for (int i = 0; i < Length - 1; i++)
                {
                    if (p(_arr[i],unit))
                    {
                        checK = true;
                        DeleteElement(i);
                    }
                }
            }
            return checK;
        }
        public void Insert(int pos, T unit)
        {
            if (!CheckIndex(pos)) throw new ArgumentOutOfRangeException(); 
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
            return new IEnumeratorDynamicArray<T>(_arr, _arrLength);
        }
        public T this[int index]
        {
            get
            {
                if (CheckIndex(index))
                {
                    return _arr[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
                
            }
            set
            {
                if (CheckIndex(index))
                {
                    _arr[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }              
            }
        }
        private bool CheckIndex(int index)
        {
            if (index >= Length || index < 0)
            {

                return false;
            }
            return true;
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


        public bool _disposed = false;

        public void Dispose()
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
                Array.Resize(ref _arr, 0);
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

        private void DeleteElement(int ind)
        {
            for (int i = ind; i + 1 < Length; i++)
            {
                _arr[i] = _arr[i + 1];
            }

            _arr[Length - 1] = default;
            Length--;
        }

    }
}
