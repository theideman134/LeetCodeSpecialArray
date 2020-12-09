using LeetCodeSpecialArray;
using NUnit.Framework;

namespace SpecialArrayTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void TestNull()
        {
            var solution = new Solution();
            var result = solution.SpecialArray(null);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void TestEmpty()
        {
            var numArray = new int[] { };
            var solution = new Solution();
            var result = solution.SpecialArray(numArray);
            Assert.AreEqual(-1, result);
        }

        /*
         Input: nums = [3,5]
         Output: 2
         Explanation: There are 2 values (3 and 5) that are greater than or equal to 2.
         */

        [Test]
        public void Test1()
        {
            var numArray = new int[] { };
            var solution = new Solution();
            var result = solution.SpecialArray(numArray);
            Assert.AreEqual(2, result);
        }
        /*
         Input: nums = [0,0]
Output: -1
Explanation: No numbers fit the criteria for x.
If x = 0, there should be 0 numbers >= x, but there are 2.
If x = 1, there should be 1 number >= x, but there are 0.
If x = 2, there should be 2 numbers >= x, but there are 0.
x cannot be greater since there are only 2 numbers in nums
        */
        [Test]
        public void Test2()
        {
            var numArray = new int[] { };
            var solution = new Solution();
            var result = solution.SpecialArray(numArray);
            Assert.AreEqual(-1, result);
        }

        /*
         Input: nums = [0,4,3,0,4]
Output: 3
Explanation: There are 3 values that are greater than or equal to 3.
        */
        [Test]
        public void Test3()
        {
            var numArray = new int[] { };
            var solution = new Solution();
            var result = solution.SpecialArray(numArray);
            Assert.AreEqual(3, result);
        }

        /*
        Input: nums = [3,6,7,7,0]
        Output: -1
        */
        [Test]
        public void Test4()
        {
            var numArray = new int[] { };
            var solution = new Solution();
            var result = solution.SpecialArray(numArray);
            Assert.AreEqual(-1, result);
        }
    }
}