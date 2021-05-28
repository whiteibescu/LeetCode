using System;
using System.Collections.Generic;

namespace _13_RomantoInteger
{

    class Program
    {
        static void Main(string[] args)
        {
            Solution();
        }

        public static void Solution()
        {
            Console.WriteLine("Input Roman numberals : ");
            string numerals = Console.ReadLine().ToUpper();
            int sum = RomanToInt(numerals);
            Console.WriteLine(sum);
        }

        public static int RomanToInt(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int result = 0;
            int previous = 0;
            for (int i = s.Length - 1; i >= 0; i--) // III i = 3-1; i>= 0; ==i
            {
                int current = dict[s[i]];   //1.Get the index of the string
                                            //2.If you get the key of a dictionary
                                            //you would get the value of the key                                       
                result += previous > current ? -current : current;
                
                //if the current is smaller than the
                //previous subtract and if bigger add
                //ex) IV V is bigger than I than subtract I
                //ex) VI I is bigger than V so add I.
                previous = current;
            }

            return result;
        }
    }
}
