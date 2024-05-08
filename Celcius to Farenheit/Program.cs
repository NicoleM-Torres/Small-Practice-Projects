namespace Celcius_to_Farenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
            double celciusTemp = 0.0;
            double farenheitTemp = 0.0;


            //INPUT
            Console.WriteLine("Enter the tempeture in Celcius:");
            celciusTemp = double.Parse(Console.ReadLine());

            //PROCESSES
            farenheitTemp = (celciusTemp*1.8)+32;

            //OUTPUT
            Console.WriteLine($"The tempeture in farenheit is: {farenheitTemp}");


        } //END MAIN
    } //END CLASS
}//END NAMESPACE
