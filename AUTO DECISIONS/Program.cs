using System.Transactions;

namespace AUTO_DECISIONS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
            double hoursWorked = 0.0;
            double payRate = 0.0;
            double grossPay = 0.0;
            double overtimePay = 0.0;



            //INPUT
            Console.WriteLine("Enter your hourly pay rate: ");
            payRate = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter hours worked: ");
            hoursWorked = double.Parse(Console.ReadLine());

          





            if (hoursWorked > 40)
            {
                overtimePay = (hoursWorked - 40) * payRate * 1.5;
                grossPay = (payRate * 40) + overtimePay;
            }
            else if (hoursWorked < 40)
            {
                grossPay = (payRate * hoursWorked);

            }

  //OUTPUT
            Console.WriteLine($"Your gross pay is {grossPay}");

















        } //END MAIN
    } //END CLASS
} // END NAMESPACE
