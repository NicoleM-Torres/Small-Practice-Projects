﻿using System.Net.Http.Headers;

namespace Cellphone_Coverage_Fees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
                double number1 = 0.0;
                double number2 = 0.35;

            //INPUT
                Console.Write("Please enter the number of excess minutes used:");
                number1=double.Parse(Console.ReadLine());

            //OUTPUT
                Console.WriteLine();
                Console.WriteLine($" Your excess fee is {number1 * number2}");


            

        } //END MAIN
    } //END CLASS
} // END NAMESPACE