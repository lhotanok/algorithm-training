namespace AlgoTraining
{
    public class EuclideanAlgorithm
    {
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
