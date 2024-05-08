namespace Sales_Tax_Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TITLE

            //VARIABLES
            double purchaseAmount = 0.0;
            double stateTax = 0.004;
            double countyTax = 0.002;
            double totalPurchase = 0.0;
            double totalCountyTax = 0.0;
            double totalStateTax = 0.0;
            double totalTaxes = 0.0;

            //INPUT
            Console.WriteLine("Enter purchase amout here:");
            purchaseAmount = double.Parse(Console.ReadLine());

            //PROCESSES
            totalCountyTax = (purchaseAmount * countyTax);
            totalStateTax= (purchaseAmount * stateTax);
            totalTaxes = (totalStateTax + totalCountyTax);
            totalPurchase = (purchaseAmount + totalStateTax + totalCountyTax);

            //OUTPUT
            Console.WriteLine($"Your total county tax is:{totalCountyTax}");
            Console.WriteLine($"Your total state tax is:{totalStateTax}");
            Console.WriteLine($"Your total in taxes is:{totalTaxes}");
            Console.WriteLine($"Your total including taxes is: {totalPurchase}");
            



        } //END MAIN
    } //END CLASS
} //END NAMESPACE
