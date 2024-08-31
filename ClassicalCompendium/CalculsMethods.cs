namespace ClassicalCompendium
{
    public class CalculsMethods
    {
        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static int SumToN(int N)
        {
            int S = ((N * (N + 1)) / 2);
            return S;
        }

        public static int SubtractToN(int N)
        {
            int S = ((N * (N + 1)) / 2);
            return -S;
        }

        public static int FactorialN(int N)
        {
            if (N <= 0)
            {
                return 0;
            }
            else
            {
                int S = 1;
                int i = 1;

                while (i <= N)
                {
                    S *= i;
                    i++;
                }
                return S;
            }
        }

        public static int NegFactorialN(int N)
        {
            if (N <= 0)
            {
                return 0;
            }
            else
            {
                int S = 1;
                int i = 1;

                while (i <= N)
                {
                    S *= i;
                    i++;
                }

                if (IsEven(N))
                {
                    return S;
                }
                else
                {
                    return -S;
                }
            }
        }
    }
}
