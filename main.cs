using System;
using System.Collections.Generic;
using INPUT;
using ESTATISTICS;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            // INPUT VALUES
            Console.WriteLine("\nEnter your values' List with \",\" withouth spaces.\nEx:1,3,4,3,3\n\nINSERT YOUR VALUES: ");
            int[] input = InputMethods.inputArray();
            Array.Sort(input);
            
            // CALCULATING ESTATISTIC PARAMETERS
            int[] values = FrecuencyMethods.frecuencyValues(input); 
            int[] frecuency = FrecuencyMethods.absoluteFrecuency(values,input);
            int[] cumulativeFrecuencies = FrecuencyMethods.cumulativeFrecuency(frecuency);

            // OUTPUT VALUES
            Console.WriteLine("Your data would look like:\n");
            Console.WriteLine($"|{"VALUE",-15}|{"FRECUENCY",-15}|{"CUMULUTATIVE F",-15}|");
            for(int i=0; i<values.Length; i++)
            {
                Console.WriteLine($"|{values[i],-15}|{frecuency[i],-15}|{cumulativeFrecuencies[i],-15}|");
            }
            Console.WriteLine($"|{"TOTAL",15}|{input.Length,15}|{"",15}|\n");
        }
    }

}
