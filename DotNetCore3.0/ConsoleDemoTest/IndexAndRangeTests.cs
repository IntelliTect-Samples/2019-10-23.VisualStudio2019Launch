using NUnit.Framework;
using System;

namespace ConsoleDemoTest
{
    public class IndexAndRangeTests
    {
        [Test]
        public void IndexTest()
        {
            int[] arr = { 0, 1, 2, 3, 4, 5 };
            Assert.AreEqual(4, arr[^2]);
            Assert.AreEqual(5, arr[^1]);

            Index i1 = 2;
            Assert.AreEqual(2, arr[i1]);
            Index i2 = ^2;
            Assert.AreEqual(4, arr[i2]);
            Index i3 = 0;
            Assert.AreEqual(0, arr[i3]);
            Index i4 = 1;
            Assert.AreEqual(1, arr[i4]);
            Index i5 = ^0;
            Assert.Catch(typeof(IndexOutOfRangeException), () => { 
                Assert.AreEqual(5, arr[i5]);
            });


        }

        [Test]
        public void RangeTest()
        {
            int[] arr = { 0, 1, 2, 3, 4, 5 };
            // Does not include the end point, but does include the start
            Assert.AreEqual(3, arr[0..3].Length);
            Assert.AreEqual(0, arr[0..3][0]);
            Assert.AreEqual(2, arr[0..3][2]);

            // Returns an Array
            Assert.AreEqual(arr.GetType(), arr[3..^0].GetType());

            Assert.AreEqual(6, arr[0..^0].Length);
            Assert.AreEqual(2, arr[2..^2].Length);
            Assert.AreEqual(2, arr[2..^2][0]);
            Assert.AreEqual(3, arr[2..^2][1]);

            Range r1 = 0..3;
            Assert.AreEqual(3, arr[r1].Length);
            Range r2 = 1..^0;
            Assert.AreEqual(5, arr[r2].Length);
            Range r3 = 0..^2;
            Assert.AreEqual(4, arr[r3].Length);
        }
    }
}