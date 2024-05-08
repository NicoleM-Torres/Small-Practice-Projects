namespace Miles_per_Gallon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
            double numberOfMilesDriven = 0.0;
            double gallonsOfGasUsed = 0.0;
            double milesPerGallon = 0.0;

            //INPUT
            Console.WriteLine("Enter amount of miles driven:");
            numberOfMilesDriven = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter amount of gas used in gallons:");
            gallonsOfGasUsed = double.Parse(Console.ReadLine());

            //PROCESSES
            milesPerGallon = (numberOfMilesDriven / gallonsOfGasUsed);

            //OUTPUT
            Console.WriteLine($"Your total miles-per-gallon is {milesPerGallon}");

        } //END MAIN
    } //END CLASS
} //END NAMESPACE
