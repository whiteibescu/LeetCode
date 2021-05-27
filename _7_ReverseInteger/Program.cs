using System;

/*Given a signed 32-bit integer x, return x with its digits reversed. If
 * reversing x causes the value to go outside the signed 32-bit integer range
 * [-2power31, 2power31 -1], then return 0.
 */




namespace _7_ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution();
        }

        public static void Solution()
        {
            Console.WriteLine("Input Integers");
            int num = int.Parse(Console.ReadLine());
            int answer = Reverse(num);
            Console.WriteLine(answer);
        }

        public static int Reverse(int x)
        {
            int result = 0;
            int prev = 0;
            int cur = 0;
            while (x != 0)
            {
                cur = x % 10; 
                x /= 10;      

                result = result * 10 + cur;

                if ((result - cur) /10  != prev)
                {
                    return 0;
                }
                prev = result;
            }
            return result;
        }
    }
}