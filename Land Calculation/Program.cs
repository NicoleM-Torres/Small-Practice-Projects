﻿namespace Land_Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
                double acre = 43560;
                double totalSquareFeet = 0.0;
                double numberOfAcresInTract = 0.0;

            //INPUT
                Console.WriteLine("Enter the total square feet in the tract of land: ");
                numberOfAcresInTract = double.Parse(Console.ReadLine());    


            //PROCESSES
                totalSquareFeet = (numberOfAcresInTract / acre);

            //OUTPUT
            Console.WriteLine($"Your total numbers of acres in your land tracts is: {totalSquareFeet}");


        } //END MAIN
    } //END CLASS
} // NAMESPACE