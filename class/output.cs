using System;
using STATISTICS;

namespace OUTPUT
{
    class OutputMethods
    {
        public static void printTable(Statistics Data)
        {
            foreach(int i in Data.inputData)
            {
                Console.Write(i+",");
            }
            Console.WriteLine($"\n\n|{"VALUE",-15}|{"FRECUENCY",-15}|{"CUMULUTATIVE F",-15}|");
            for(int i=0; i < Data.frecuencyValues.Length; i++)
            {
                Console.WriteLine($"|{Data.frecuencyValues[i],-15}|{Data.absoluteFrecuency[i],-15}|{Data.cumulativeFrecuency[i],-15}|");
            }
            Console.WriteLine($"|{"TOTAL",15}|{Data.inputData.Length,15}|{"",15}|\n");
        }
    }
}