using System;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            // INPUT VALUES
            int[] input = new int[]{1,1,5,5,5}; // <---- WRITE YOUR LIST OF VALUES HERE
            Array.Sort(input);
            int[] values = Estatistics.frecuencyValues(input); 
            int[] frecuency = Estatistics.absoluteFrecuency(values,input);

            // OUTPUT VALUES
            Console.WriteLine($"|{"VALUE",-15}|{"FRECUENCY",-15}|");
            for(int i=0; i<values.Length; i++)
            {
                Console.WriteLine($"|{values[i],-15}|{frecuency[i],-15}|");
            }
        }
    }

    class Estatistics
    {
        public static int[] frecuencyValues(int[] input)
        {
            List<int> values=new List<int>{input[0]};
            bool isNotOnTheList;
            foreach(int i in input)
            {
                isNotOnTheList=true;
                foreach(int e in values)
                {
                    if(i==e)
                    {
                        isNotOnTheList=false;
                        break;
                    }
                }
                if(isNotOnTheList) values.Add(i);
            }
            return values.ToArray();
        }
        public static int[] absoluteFrecuency(int[] values, int[] data)
        {
            int[] absoluteFrecuencyValues= new int[values.Length];
            for(int i=0; i<values.Length;i++)
            {
                foreach(int e in data)
                {
                    if(values[i]==e)
                    {
                        absoluteFrecuencyValues[i]++;
                    }
                }
            }
            return absoluteFrecuencyValues;
        }
    }
}
