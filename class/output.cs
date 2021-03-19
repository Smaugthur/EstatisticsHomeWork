using System;
using STATISTICS;

namespace OUTPUT
{
    class OutputMethods
    {
        public static void printTable(StatisticsSimple Data)
        {
            foreach(int i in Data.inputData)
            {
                Console.Write(i+",");
            }
            Console.WriteLine($"\n\n|{"VALUE",-15}|{"FRECUENCY",-15}|{"CUMULUTATIVE F",-15}|{"RELATIVE F", -15}|");
            for(int i=0; i < Data.frecuencyValues.Length; i++)
            {
                Console.WriteLine($"|{Data.frecuencyValues[i],-15}|{Data.absoluteFrecuency[i],-15}|{Data.cumulativeFrecuency[i],-15}|{Data.relativeFrecuency[i], +15}|");
            }
            Console.WriteLine($"|{"TOTAL",15}|{Data.inputData.Length,15}|{"",15}|\n");
        }
        public static void printTable(StatisticsWithIntervals Data)
        {
            foreach(int i in Data.inputData)
            {
                Console.Write(i+",");
            }
            Console.WriteLine($"\n\n|{"VALUE",-15}|{"FRECUENCY",-15}|{"CUMULUTATIVE F",-15}|{"RELATIVE F", -15}|");
            for(int i=0; i < Data.frecuencyValues.GetLength(1); i++)
            {
                Console.WriteLine($"|{Data.frecuencyValues[i,0] + " - " + Data.frecuencyValues[i,1],-15}|{Data.absoluteFrecuency[i],-15}|{Data.cumulativeFrecuency[i],-15}|{Data.relativeFrecuency[i], +15}|");
            }
            Console.WriteLine($"|{"TOTAL",15}|{Data.inputData.Length,15}|{"",15}|\n");
        }
    }
}