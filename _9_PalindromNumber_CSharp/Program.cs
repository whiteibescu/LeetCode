using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _9_PalindromNumber_CSharp
{
    /*    public class Solution
        {
            public bool IsPalindrome(int x)
            {
                return false;
            }
        }*/
    class Program
    {

        static void Main(string[] args)
        {
            Solution();
        }

        public static void Solution()
        {
            Console.WriteLine("Input the palindrome : ");
            int num = int.Parse(Console.ReadLine());
            if (IsPalindrome(num))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        public static bool IsPalindrome(int x)
        {
            string num = x.ToString();
            char[] split = num.ToCharArray();
            List<int> splitlist = new List<int>();
            List<int> reverselist = new List<int>();

            for (int i = 0; i < split.Length; i++)
            {
                splitlist.Add(split[i]);
                reverselist.Add(split[i]);
                Console.WriteLine(split[i]);
            }
            
            reverselist.Reverse();

            bool isTrue = Enumerable.SequenceEqual(splitlist, reverselist);

            if (isTrue)
            {
                return true;
            }
            return false;
        }
    }
}
