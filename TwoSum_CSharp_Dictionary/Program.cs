using System;
using System.Collections.Generic;

namespace TwoSum_CSharp_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 7, 12, 18 };
            int target = 15;
            Console.WriteLine("실행전");
            int[] answer = TwoSum(array, target);
            Console.WriteLine("실행후");

            foreach (int i in answer)
            {
                Console.WriteLine(i);
            }
        }

        public static int[] TwoSum(int[] array, int target)
        {
            Dictionary<int, int> preNumbers = new Dictionary<int, int>();

            Console.WriteLine("넘어왔다");
            for (int i = 0; i < array.Length; i++)
            {
                int complement = target - array[i];

                if (preNumbers.ContainsKey(complement))
                {
                    return new int[] {preNumbers[complement], i};
                }

                preNumbers.Add(array[i], i);

            }
            return null;
        }
    }
}
