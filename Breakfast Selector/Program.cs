﻿using System.Linq.Expressions;

namespace Breakfast_Selector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TERNERY OPERATOR / STATEMENTS

            //INPUT
            string breakfast;
            Console.WriteLine("Enter an food");
            string food = Convert.ToChar(Console.ReadLine());

            //SWITCH STATEMENTS / CASES
            string food;
           
            switch (food)
            {
                case 'egg':
                    Console.WriteLine("omelette");
                    break;
                case 'flour':
                    Console.WriteLine("pancake");
                    break;
                case 'strawberry':
                    Console.WriteLine("smoothie");
                    break;
                case 'milk':
                    Console.WriteLine("shake");
                    break;
                case 'bread':
                    Console.WriteLine("sandwich");
                    break;
                case 'oats':
                    Console.WriteLine("oatmeal");
                    break;
            } //END SWITCH


            } //END MAIN









    } //END CLASS
} //END NAMESPACE