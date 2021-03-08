using System;

namespace INPUT
{
    class InputMethods
    {
        public static float[] inputArray()
        {
            string[] StringInput= Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            float[] input = Array.ConvertAll(StringInput, s => float.Parse(s));
            Array.Sort(input);
            Console.Clear();
            return input;
        }
    }
}