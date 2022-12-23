using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    public class EventDynamicArray : EventArgs
    {
        public int OldCapacity { get; }
        public int NewCapacity { get; }
        public EventDynamicArray(int oldCapacity, int newCapacity)
        {
            OldCapacity = oldCapacity;
            NewCapacity = newCapacity;
        }

    }
}
