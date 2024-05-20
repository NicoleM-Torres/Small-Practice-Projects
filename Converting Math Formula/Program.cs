namespace Converting_Math_Formula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
                double futureValue = 0.0;
                double annualInterest = 0.0;
                double years = 0.0;
                double presentValue = 0.0;
          

            //INPUT
            Console.WriteLine("Enter annual interest:");
                annualInterest = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter years in account:");
                years = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter accounts expected future value:");
                futureValue = double.Parse(Console.ReadLine());


            //PROCESSES
                presentValue = (futureValue / Math.Pow((1.0 + annualInterest), years));            


            //OUTPUT
                Console.WriteLine($"Your expected deposit today is:{presentValue}");


        } //END MAIN    
    } //END CLASS
} //END NAMESPACE
