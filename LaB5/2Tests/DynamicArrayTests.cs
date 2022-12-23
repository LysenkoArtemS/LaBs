using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Tests
{
    public class TestDisposable : IDisposable
    {
        protected bool _disposed = false;

        public void Dispose()
        {
            _disposed = true;
        }
    }

    [TestClass]
    public class DynamicArrayTests
    {
        private DynamicArray<int> obj;

        [TestInitialize]
        public void Initialize()
        {
            obj = new DynamicArray<int>();
        }

        [TestMethod]
        public void ConstructorNoParam_SetValidValues_CapacityAndLength_Tests()
        {
            int length = 0;

            obj = new DynamicArray<int>();

            Assert.AreEqual(8, obj.Capacity);
            Assert.AreEqual(length, obj.Length);
        }

        [DataTestMethod]
        [DataRow(1)]
        [DataRow(10)]
        public void Constructor_SetValidValues_CapacityAndLength_Tests(int capacity)
        {
            int length = 0;

            obj = new DynamicArray<int>(capacity);

            Assert.AreEqual(capacity, obj.Capacity);
            Assert.AreEqual(length, obj.Length);
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(-10)]
        public void Constructor_SetInvalidValues_ThrowsException_Tests(int capacity)
        {
            Assert.ThrowsException<ArgumentException>(() => obj = new DynamicArray<int>(capacity));
        }

        [DataTestMethod]
        [DataRow(new int[] { 1 })]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void Constructor_SetArray_Tests(int[] array)
        {
            obj = new DynamicArray<int>(array);

            CollectionAssert.AreEqual(array, obj);
            Assert.AreEqual(array.Length, obj.Capacity);
        }

        [DataTestMethod]
        [DataRow(new int[] { 1 })]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void Constructor_SetObject_Tests(int[] array)
        {
            DynamicArray<int> temp = new DynamicArray<int>(array);

            DynamicArray<int> obj = new DynamicArray<int>(array);

            CollectionAssert.AreEqual(temp, obj);//Icollect
        }

        [DataTestMethod]
        [DataRow(new int[] { 1 }, 8)]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 16)]
        public void Method_Add_CapacityAndLength_Tests(int[] array, int capacity)
        {

            for (int i = 0; i < array.Length; i++)
            {
                obj.Add(array[i]);
            }

            CollectionAssert.AreEqual(array, obj);
            Assert.AreEqual(array.Length, obj.Length);
            Assert.AreEqual(capacity, obj.Capacity);
        }

        [DataTestMethod]
        [DataRow(new int[] { 1 })]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void Method_AddRange_SetArray_Tests(int[] array)
        {
            obj.AddRange(array);

            CollectionAssert.AreEqual(array, obj);
            Assert.AreEqual(array.Length, obj.Length);
        }

        [DataTestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        public void Method_AddRange_SetObject_Tests(int[] array)
        {
            DynamicArray<int> obj = new DynamicArray<int>();
            DynamicArray<int> temp = new DynamicArray<int>(array);

            obj.AddRange(temp);

            CollectionAssert.AreEqual(temp, obj);
        }

        [TestMethod]
        public void Method_Remove_4_Number_Test()
        {
            int[] target = { 1, 3, 5, 7, 8 };
            int[] original = { 1, 3, 4, 5, 7, 4, 8, 4 };

            DynamicArray<int> obj = new DynamicArray<int>(original);
            obj.Remove(4);

            CollectionAssert.AreEqual(target, obj);
            Assert.AreEqual(5, obj.Length);
            Assert.AreEqual(8, obj.Capacity);
        }

        [TestMethod]
        public void Method_Remove_0_Number_Test()
        {
            int[] target = { 1, 3, 3, 7, 9 };

            obj = new DynamicArray<int>(target);
            obj.Remove(5);

            CollectionAssert.AreEqual(target, obj);
            Assert.AreEqual(5, obj.Length);
            Assert.AreEqual(5, obj.Capacity);
        }

        [TestMethod]
        public void Method_Insert_To_1_Index_Test()
        {
            int[] target = { 1, 5, 3, 5, 7, 8 };
            int[] original = { 1, 3, 5, 7, 8 };

            obj = new DynamicArray<int>(original);
            obj.Insert(1, 5);

            CollectionAssert.AreEqual(target, obj);
        }


        [TestMethod]
        public void Method_Insert_To_InvalidIndex_ThrowsException_Test()
        {
            int[] original = { 1, 3, 5, 7, 8 };

            obj = new DynamicArray<int>(original);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => obj.Insert(5, 10));
        }

        [TestMethod]
        public void Ienumerable_ForEach_Object_Test()
        {
            int[] target = { 1, 2, 3, 4, 5, 6 };
            int[] result = new int[6];
            int i = 0;

            DynamicArray<int> obj = new DynamicArray<int>(target);

            foreach (int item in obj)
            {
                result[i] = item;
                i++;
            }

            CollectionAssert.AreEqual(target, result);
        }

        [DataTestMethod]
        [DataRow(new int[] { 1 }, -1)]
        [DataRow(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 100)]
        public void Indexator_SetInvalidValues_ThrowsException_Tests(int[] array, int index)
        {
            DynamicArray<int> obj = new DynamicArray<int>(array);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => obj[index] = 0);
        }

        [DataTestMethod]
        [DataRow(new int[] { 1 }, -1)]
        [DataRow(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 100)]
        public void Indexator_GetInvalidValues_ThrowsException_Tests(int[] array, int index)
        {
            int pos = 0;
            obj = new DynamicArray<int>(array);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => pos = obj[index]);

        }

        [TestMethod]
        public void Indexator_SetValidValue_Test()
        {
            int[] target = { 1, 2, 5, 4, 5 };
            int[] original = { 1, 2, 3, 4, 5 };

            obj = new DynamicArray<int>(original);
            obj[2] = 5;

            CollectionAssert.AreEqual(target, obj);
            Assert.AreEqual(5, obj[2]);
        }

        [TestMethod]
        public void Indexator_GetValidValue_Test()
        {
            int[] original = { 1, 2, 3, 4, 5 };
            obj = new DynamicArray<int>(original);

            Assert.AreEqual(obj[2], 3);
        }

        [DataTestMethod]
        [DataRow(new int[] { 1 })]
        [DataRow(new int[] { 1, 2, 3, 4, 5 })]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void Method_Equals_ValidObjects_Tests(int[] array)
        {
            DynamicArray<int> obj = new DynamicArray<int>(array);
            DynamicArray<int> temp = new DynamicArray<int>(array);

            Assert.IsTrue(obj.Equals(temp));
        }

        [DataTestMethod]
        [DataRow(new int[] { })]
        [DataRow(new int[] { 1, 2, 3, 4, 5 })]
        public void Method_Equals_InvalidObjects_Tests(int[] array)
        {
            obj = new DynamicArray<int>();
            DynamicArray<int> temp = new DynamicArray<int>(array);
            Assert.IsFalse(obj.Equals(temp));
        }

        [TestMethod]
        public void Method_DisposeObject_Test()
        {
            DynamicArray<TestDisposable> temp = new DynamicArray<TestDisposable>();
            TestDisposable temp1 = new TestDisposable();
            temp.Add(temp1);
            temp.Dispose();

            Assert.AreEqual(0, temp.Capacity);//_disp protect
            Assert.AreEqual(0, temp.Length);
        }

        [TestMethod]
        public void EventTriggered_OnCapacityChange_Test()
        {
            DynamicArray<int> obj = new DynamicArray<int>(1);
          
            bool eventTriggered = false;

            obj.Notify += (sender, args) =>
            {
                eventTriggered = true;
                Assert.AreEqual(1, args.OldCapacity);
                Assert.AreEqual(2, args.NewCapacity);
            };

            obj.Add(1);
            obj.Add(2);

            Assert.IsTrue(eventTriggered);
        }
        [DataTestMethod]
    
        public void Operators_ReturnValidValues_Tests()
        {
            int[] arr = { };
            int[] arr1 = { 1, 2, 3, 4 };
            obj =null;
            DynamicArray<int> target = new DynamicArray<int>(arr);
            Assert.IsTrue(obj == target);
            obj = new DynamicArray<int>(arr1);
            Assert.IsTrue(obj != target);
        }//

        [DataTestMethod]
        [DataRow(new int[] { })]
        [DataRow(new int[] { 1, 2, 3, 4, 5 })]
        public void Operator_Implict_ReturnValidValues_Tests(int[] array)
        {
            obj = new DynamicArray<int>(array);
            DynamicArray<int> target = obj;
            CollectionAssert.AreEqual(obj, target);
        }


        [DataTestMethod]
        [DataRow(new int[] { })]
        [DataRow(new int[] { 1, 2, 3, 4, 5 })]
        public void Operator_Explict_ReturnValidValues_Tests(int[] array)
        {
            obj = new DynamicArray<int>(array);
            DynamicArray<int> target = (DynamicArray<int>)obj;
            CollectionAssert.AreEqual(obj, target);
        }
        //from array
    }
}