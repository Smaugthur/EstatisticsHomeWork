using System;
using System.Collections.Generic;

namespace ESTATISTICS
{
    class FrecuencyMethods
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
        public static int[] cumulativeFrecuency(int[] absoluteFrecuency)
        {
            int[] cumulativeFrecuencies = new int[absoluteFrecuency.Length];
            for(int i=0;i<absoluteFrecuency.Length;i++)
            {
                for(int e=0;e<=i;e++)
                {
                    cumulativeFrecuencies[i]+=absoluteFrecuency[e];
                }
            }
            return cumulativeFrecuencies;
        }
    }
}