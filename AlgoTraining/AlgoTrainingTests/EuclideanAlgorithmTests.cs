using AlgoTraining;

namespace TestAlgoTraining
{
    public class EuclideanAlgorithmTests
    {
        // first value, second value, correct result
        private static readonly (int, int, int)[] testData =
        {
            (2, 2, 2),
            (10, 5, 5),
            (15, 10, 5),
            (21, 14, 7),
            (28, 14, 14),
            (36, 48, 12),
            (48, 18, 6),
            (63, 56, 7),
            (100, 75, 25),
            (120, 90, 30),
            (126, 36, 18),
            (240, 160, 80),
            (336, 224, 112),
            (500, 300, 100),
            (720, 360, 360),
            (1000, 250, 250),
            (1500, 900, 300),
            (2000, 1600, 400),
            (2520, 1260, 1260),
            (5000, 2500, 2500),
            (873, 189, 9),
            (2345, 123, 1),
            (7896, 256, 8),
            (45678, 789, 3),
            (90210, 420, 30),
            (123456, 654321, 3),
            (987654, 123456, 6),
            (3333333, 1111111, 1111111),
            (88888888, 22222222, 22222222),
            (999999999, 111111111, 111111111),
        };

        [TestCaseSource(nameof(testData))]
        public void TestGetGreatestCommonDivisor((int, int, int) inputAndExpected)
        {
            (int a, int b, int expected) = inputAndExpected;

            int result = EuclideanAlgorithm.GetGreatestCommonDivisor(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}