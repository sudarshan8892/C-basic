using System;
using System.ComponentModel;

namespace ArrayAnd_List
{
    public class Prgogram
    {
        public static void Main(string[] arg)
        {
            int[] ints = { 1, 2, };
            int[] ints1 = ints;
            ints1[0] = 5;
            Console.WriteLine("array1: {0} array2: {1}", string.Join(",", ints), string.Join(",", ints1));
            Console.WriteLine("array1:" + ints[0] + "," + ints[1] + "array2:" + ints1[0] + "," + ints1[1]);

            Console.WriteLine("-------------------------------------------------------------------------------");
            //find the minimum element of an array
            int[] aray = { 1, 20, 5, 4, 56, 44 };
            Array.Sort(aray);
            Console.WriteLine(string.Join(",", aray));
            Console.WriteLine(aray.Min());
            Console.WriteLine(aray.Max());
            Console.WriteLine("-------------------------------------------------------------------------------");
            //reverse an array in C# 
            int[] arrayrevers = { 1, 2, 5, 6, 71, 2, 3, };
            Array.Reverse(arrayrevers);
            Console.WriteLine(string.Join(",", arrayrevers));
            Console.WriteLine("-------------------------------------------------------------------------------");

            string[] stringArray = { "sudarshan shetty" };
            Array.Sort(stringArray);
            Console.WriteLine(string.Join("", stringArray));
            if (stringArray[0].Length > 6)
            {
                char[] charArray = stringArray[0].ToCharArray();
                charArray[6] = 'a';
                Console.WriteLine(charArray);

            }
            Console.WriteLine("-------------------------------------------------------------------------------");


            int[] arr = { 1, 4, 4, 3, 10,12, 5 };
            int targetSum = 33;

            int[] subarray = SubarraySum(arr, targetSum);
            Console.WriteLine(string.Join("," ,subarray));
            static int[] SubarraySum(int[] arr, int sum)
            {
                Dictionary<int, int> map = new Dictionary<int, int>();
                int currSum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    currSum += arr[i];
                    if (currSum == sum)
                    {
                        return new int[] { 0, i };
                    }
                    if (map.ContainsKey(currSum - sum))
                    {
                        return new int[] { map[currSum - sum] + 1, i };
                    }
                    map[currSum] = i;
                }
                return new int[] { };
            }
        }


    }
}