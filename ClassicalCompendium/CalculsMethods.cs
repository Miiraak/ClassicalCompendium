namespace ClassicalCompendium
{
    public class CalculsMethods
    {
        /// <summary>
        /// This method verifies if the number is odd.
        /// </summary>
        /// <param name="number">The integer to check.</param>
        /// <returns>true if the number is odd, false otherwise.</returns>
        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        /// <summary>
        /// This method verifies if the number is even  
        /// </summary>
        /// <param name="number">The integer to check.</param>
        /// <returns>true if the number is even, false otherwise.</returns>
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        /// <summary>
        /// This method adds consecutive integers from 1 to N.
        /// </summary>
        /// <param name="N">The maximum number to sum.</param>
        /// <returns>The sum of the first N integers.</returns>
        public static int SumToN(int N)
        {
            int S = ((N * (N + 1)) / 2);
            return S;
        }

        /// <summary>
        /// This method  consecutive integers from 1 to N. N is .
        /// </summary>
        /// <param name="N">The maximum number to subtract</param>
        /// <returns>The subtract of the first N integers.</returns>
        public static int SubtractToN(int N)
        {
            int S = ((N * (N + 1)) / 2);
            return -S;
        }

        /// <summary>
        /// This method multiplies consecutive integers from 1 to N.
        /// </summary>
        /// <param name="N">The maximum number to multiplies.</param>
        /// <returns>The factorial of N.</returns>
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

        /// <summary>
        /// This method multiplies consecutive negatives integers from 1 to N. 
        /// </summary>
        /// <param name="N">The maximum negative number to multiplies.</param>
        /// <returns>The negative factorial of N.</returns>
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
