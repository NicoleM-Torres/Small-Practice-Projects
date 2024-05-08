namespace Tip__Tax___Total
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
            double foodAmount = 0.0;
            double tip = 15;
            double tipAmount = 0.0;
            double salesTax = 0.07;
            double totalTax = 0.0;
            double total = 0.0;

            //INPUT
            Console.WriteLine("How much did you spend on your meal?");
            foodAmount = double.Parse(Console.ReadLine());

         
          //PROCESSES
          tipAmount = (foodAmount/tip);
          totalTax = (foodAmount*salesTax);
          total = (foodAmount+totalTax+tipAmount);

            //OUTPUT
            Console.WriteLine($"Your total tip due is {tipAmount}.");
            Console.WriteLine($"Your total tax due is {totalTax}.");
            Console.WriteLine($"Your total due is {total}.");









        } //END MAIN
    }//END CLASS
} //END NAMESPACE
