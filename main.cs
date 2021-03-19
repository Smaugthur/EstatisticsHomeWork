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
                Console.WriteLine("Would you use intervals? Yes(y) No(n): ");
                bool useIntervals = Console.ReadLine() == "y" ? true : false;

                // CALCULATING STATISTICS
                switch(useIntervals)
                {
                    case true:
                        Console.WriteLine("How long your interval will be? ");
                        int intervalsLength = int.Parse(Console.ReadLine());
                        Console.Clear();
                        StatisticsWithIntervals Data1 = new StatisticsWithIntervals(inputData, intervalsLength);
                        Console.WriteLine("Your data would look like:");
                        OutputMethods.printTable(Data1);
                        break;
                    case false:
                        StatisticsSimple Data2 = new StatisticsSimple(inputData); 
                        Console.WriteLine("Your data would look like:");
                        OutputMethods.printTable(Data2);
                        break;
                }

                // OUTPUT VALUES
                Console.Write("Press <Enter> to make another table...\nPress any other key to exit...");
            }while(Console.ReadKey().Key == ConsoleKey.Enter);
        }
    }
}
