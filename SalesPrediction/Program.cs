﻿namespace SalesPrediction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
            double projectedSales = 0.0;
            double percentOfSales = 0.23;
            double profit = 0.0;

            //INPUT

            Console.WriteLine("Enter projected amount of sales:");
            projectedSales = double.Parse(Console.ReadLine());  

            //PROCESSES
            profit = (projectedSales * percentOfSales);
            
            //OUTPUT
            Console.WriteLine($"Your expected profit is: {profit} ");


        } //END MAIN
    } // END CLASS
} //END NAMESPACE