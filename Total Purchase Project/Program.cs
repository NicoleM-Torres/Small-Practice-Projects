﻿namespace Total_Purchase_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
            double itemOne = 0.0;
            double itemTwo = 0.0;
            double itemThree = 0.0;
            double itemFour = 0.0;
            double itemFive = 0.0;
            double subtotal = 0.0;
            double salesTax = 0.06;
            double total = 0.0;

            //INPUT
            Console.WriteLine("Enter price of first item:");
            itemOne = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter price of second item:");
            itemTwo = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter price of third item:");
            itemThree = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter price of fourth item:");
            itemFour = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter price of fifth item:");
            itemFive = double.Parse(Console.ReadLine());

        //PROCESSES

            subtotal = (itemOne + itemTwo + itemThree + itemFour + itemFive);
            salesTax = (subtotal * salesTax);
            total = (subtotal + salesTax);


            //OUTPUT

            Console.WriteLine($"Your subtotal is:{subtotal}");
            Console.WriteLine($"Your tax is {salesTax}.");
            Console.WriteLine($"Your total is {total}.");


        } //END MAIN
    } //END CLASS
} //END NAMESPACE
