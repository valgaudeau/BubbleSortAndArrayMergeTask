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
        public void GivenTwoNonEmptyArraysOfSameSize_ArrayMergeReturnsSortedCombinedArray()
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

        [Test]
        public void GivenTwoNonEmptyArraysOfDifferentSize_ArrayMergeReturnsSortedCombinedArray()
        {
            int[] arrOne = new int[] { 1, 3, 5, 9, 10 };
            int[] arrTwo = new int[] { 2, 5, 8, 9 };
            var result = Program.ArrayMerge(arrOne, arrTwo);
            var expResult = new int[] { 1, 2, 3, 5, 5, 8, 9, 9, 10 };
            Assert.That(result, Is.EqualTo(expResult).AsCollection);
        }

        [Test]
        public void GivenTwoNonEmptyArraysOfSameSizeWithOneArrayContainingNegativeNumbers_ArrayMergeReturnsSortedCombinedArray()
        {
            int[] arrOne = new int[] { 1, 3, 5, 9, 10 };
            int[] arrTwo = new int[] { 2, 5, 8, 9, -1 };
            var result = Program.ArrayMerge(arrOne, arrTwo);
            var expResult = new int[] { -1, 1, 2, 3, 5, 5, 8, 9, 9, 10 };
            Assert.That(result, Is.EqualTo(expResult).AsCollection);
        }

        [Test]
        public void GivenTwoNonEmptyArraysOfSameSizeWithBothArraysContainingNegativeNumbers_ArrayMergeReturnsSortedCombinedArray()
        {
            int[] arrOne = new int[] { 1, 3, 5, 9, 10, -5 };
            int[] arrTwo = new int[] { 2, 5, 8, 9, -1, -2 };
            var result = Program.ArrayMerge(arrOne, arrTwo);
            var expResult = new int[] { -5, -2, -1, 1, 2, 3, 5, 5, 8, 9, 9, 10 };
            Assert.That(result, Is.EqualTo(expResult).AsCollection);
        }

        [Test]
        public void GivenOneEmptyArrayAndOneNonEmptyArray_ArrayMergeReturnsSortedCombinedArray()
        {
            int[] arrOne = new int[] { 1, 3, 5, 9, 10 };
            int[] arrTwo = new int[] { };
            var result = Program.ArrayMerge(arrOne, arrTwo);
            var expResult = new int[] { 1, 3, 5, 9, 10};
            Assert.That(result, Is.EqualTo(expResult).AsCollection);
        }

        [Test]
        public void GivenTwoEmptyArrays_ArrayMergeReturnsEmptyArray()
        {
            int[] arrOne = new int[] { };
            int[] arrTwo = new int[] { };
            var result = Program.ArrayMerge(arrOne, arrTwo);
            var expResult = new int[] { };
            Assert.That(result, Is.EqualTo(expResult).AsCollection);
        }

        [Test]
        public void GivenOneNullArray_ArrayMergeThrowsArgumentException()
        {
            int[] arrOne = new int[] { 1, 3, 5, 9, 10 };
            int[] arrTwo = null;
            Assert.That(() => Program.ArrayMerge(arrOne, arrTwo), Throws.TypeOf<ArgumentException>().With.Message.Contain("You passed a null array"));
        }

        [Test]
        public void GivenTwoNullArrays_ArrayMergeThrowsArgumentException()
        {
            int[] arrOne = null;
            int[] arrTwo = null;
            Assert.That(() => Program.ArrayMerge(arrOne, arrTwo), Throws.TypeOf<ArgumentException>().With.Message.Contain("You passed a null array"));
        }
    }
}