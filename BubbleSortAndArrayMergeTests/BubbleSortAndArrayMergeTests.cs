using BubbleSortAndArrayMergeLab;

namespace BubbleSortAndArrayMergeTests
{
    public class BubbleSortAndArrayMergeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenTwoNonEmptyArrays_ArrayMergeReturnsSortedCombinedArray()
        {
            int[] arrOne = new int[] { 1, 3, 5, 9 };
            int[] arrTwo = new int[] { 2, 5, 8, 9 };
            var result = Program.ArrayMerge(arrOne, arrTwo);
            var expResult = new int[] { 1, 2, 3, 5, 5, 8, 9, 9 };
            Assert.That(result, Is.EqualTo(expResult).AsCollection);
        }

        /*
        private static Object[] ArrayCases = 
        { 
            new int[] { 1, 3, 5, 9 },
            new int[] { 2, 5, 8, 9 }
        };
        */
    }
}