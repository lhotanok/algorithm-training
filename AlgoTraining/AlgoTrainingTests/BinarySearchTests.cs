using AlgoTraining;

namespace TestAlgoTraining
{
    public class BinarySearchTests
    {
        private static readonly List<int> sortedNumbers = new() {
            1, 2, 3, 3, 4, 5, 6, 12, 13, 13, 15, 23, 24, 25, 28, 32, 44, 44, 45, 50
        };

        private static readonly int[] sortedNumbersInArray = {
            5, 6, 7, 8, 354, 386, 391, 402, 409, 500, 1000, 7500, 7501, 7502, 7503, 7600
        };

        [Test]
        public void TestFindPresentValue()
        {
            for (int i = 0; i < sortedNumbers.Count; i++)
            {
                int searchedValue = sortedNumbers[i];
                int valueFoundAtIndex = BinarySearch.Find(sortedNumbers, searchedValue);

                Assert.That(searchedValue, Is.EqualTo(sortedNumbers[valueFoundAtIndex]));
            }
        }

        [Test]
        public void TestFindPresentValueInArray()
        {
            for (int i = 0; i < sortedNumbersInArray.Length; i++)
            {
                int searchedValue = sortedNumbersInArray[i];
                int valueFoundAtIndex = BinarySearch.Find(sortedNumbersInArray, searchedValue);

                Assert.That(searchedValue, Is.EqualTo(sortedNumbersInArray[valueFoundAtIndex]));
            }
        }

        [Test]
        public void TestFindAbsentMaxValue()
        {
            int maxValue = sortedNumbers[sortedNumbers.Count - 1];
            int valueFoundAtIndex = BinarySearch.Find(sortedNumbers, maxValue + 1);

            Assert.That(valueFoundAtIndex, Is.EqualTo(-1));
        }

        [Test]
        public void TestFindAbsentMinValue()
        {
            int minValue = sortedNumbers[0];
            int valueFoundAtIndex = BinarySearch.Find(sortedNumbers, minValue - 1);

            Assert.That(valueFoundAtIndex, Is.EqualTo(-1));
        }

        [Test]
        public void TestFindAbsentCenterValue()
        {
            int valueFoundAtIndex = BinarySearch.Find(sortedNumbers, 26);

            Assert.That(valueFoundAtIndex, Is.EqualTo(-1));
        }

        [Test]
        public void TestPresentValueInArrayOfSizeOne()
        {
            int[] values = { 5 };

            int searchedValue = values[0];
            int valueFoundAtIndex = BinarySearch.Find(values, searchedValue);

            Assert.That(searchedValue, Is.EqualTo(values[valueFoundAtIndex]));
        }

        [Test]
        public void TestGreaterAbsentValueInArrayOfSizeOne()
        {
            int[] values = { 5 };

            int searchedValue = 7;
            int valueFoundAtIndex = BinarySearch.Find(values, searchedValue);

            Assert.That(valueFoundAtIndex, Is.EqualTo(-1));
        }

        [Test]
        public void TestSmallerAbsentValueInArrayOfSizeOne()
        {
            int[] values = { 5 };

            int searchedValue = 4;
            int valueFoundAtIndex = BinarySearch.Find(values, searchedValue);

            Assert.That(valueFoundAtIndex, Is.EqualTo(-1));
        }
    }
}