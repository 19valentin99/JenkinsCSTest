using System;

namespace FirstProject
{
    public class Program
    {
        public int mySum(int n)
        {
            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                s = s + i;
            }

            return s;
        }

        public static void Main(string[] args)
        {
            Program mainPro = new Program();
            Console.WriteLine("The sum is: " + mainPro.mySum(20));
        }
    }
}
