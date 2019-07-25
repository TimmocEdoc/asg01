using System;

namespace test
{
    public class fibonacci
    {
        public static int fibo(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }

            if (n == 3)
            {
                return 2;
            }

            int x1 = 1, x2 = 1, x3 = 2;
            for (int i = 4; i <= n; i++)
            {
                x1 = x2;
                x2 = x3;
                x3 = x1 + x2;
            }
            return x3;
        }
        public static void Main(String[] args)
        {
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(fibo(number));
        }
    }
}