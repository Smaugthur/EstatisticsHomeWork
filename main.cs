using System;
using System.Collections.Generic;
using INPUT;
using OUTPUT;
using STATISTICS;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            do{
                // INPUT VALUES
                Console.Clear();
                Console.WriteLine("\nEnter your values' list separated with spaces.\nEx:1 3 4 3 3\n\nINSERT YOUR VALUES:");
                float[] inputData = InputMethods.inputArray();

                // CALCULATING STATISTICS
                Statistics Data = new Statistics(inputData);

                // OUTPUT VALUES
                Console.WriteLine("Your data would look like:");
                OutputMethods.printTable(Data);
                Console.Write("Press <Enter> to make another table...\nPress any other key to exit...");
            }while(Console.ReadKey().Key == ConsoleKey.Enter);
        }
    }
}
