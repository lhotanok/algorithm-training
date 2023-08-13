namespace AlgoTraining
{
    public class EuclideanAlgorithm
    {
        /// <summary>
        /// Calculates the greatest common divisor of two numbers
        /// using the Euclidean algorithm.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>GCD</returns>
        public static int GetGreatestCommonDivisor(int a, int b)
        {
            while(true)
            {
                if (a < b)
                {
                    (b, a) = (a, b);
                }

                if (b == 0)
                {
                    break;
                }

                a %= b;
            }

            return a;
        }
    }
}
