using System;

namespace INPUT
{
    class InputMethods
    {
        public static int[] inputArray()
        {
            string[] StringInput= Console.ReadLine().Split(',');
            int[] input = Array.ConvertAll(StringInput, s => int.Parse(s));
            Console.Clear();
            return input;
        }
    }
}