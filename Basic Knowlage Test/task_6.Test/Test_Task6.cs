using NUnit.Framework;
using System;

namespace Task_6.Test
{
    internal class Task6_Tests
    {

        [Test]

        public void Test() 
        {
            int actual = 2071;
            int expected = 2017;
            int result = Task_6.Pool.NextPermutation(expected);
            Assert.That(result, Is.EqualTo(actual));
            
        }



        [TestCase(12, 21)]
        [TestCase(513, 531)]
        [TestCase(2017, 2071)]
        
        public void NextBigger_IsPossible_ReturnsNextBigger(int num, int expectedResult)
        {
            var result = Task_6.Pool.NextPermutation(num);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(9)]
        [TestCase(1)]
        [TestCase(111)]
        
        public void NextBigger_SomeNumberWhithoutBiger_ReturnsNegativeOne(int num)
        {
            var result = Task_6.Pool.NextPermutation(num);
            Assert.That(result, Is.EqualTo(-1));
        }
    }
}