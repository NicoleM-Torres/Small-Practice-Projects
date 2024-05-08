using System.Net.Http.Headers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculating_Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
                double test1 = 0.0;
                double test2 = 0.0;
                double test3 = 0.0;
                double product = 0.0;

            //TITLE
                Console.WriteLine("Your Science class average");
                Console.WriteLine();


            //INPUT
                Console.Write("Please enter a test score 1: ");
                test1 = double.Parse(Console.ReadLine());

                Console.Write("Please enter a test score 2: ");
                test2 = double.Parse(Console.ReadLine());

                Console.Write("Please enter a test score 3: ");
                test3 = double.Parse(Console.ReadLine());

            //PROCESSES
                product = (test1 + test2 + test3) / 3;

            //OUTPUT
                Console.WriteLine($"Your class average is : {product}");

        } //END MAIN
    } // END CLASS
} //END NAMESPACE
