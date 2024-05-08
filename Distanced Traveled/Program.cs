namespace Distanced_Traveled
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
            double distance = 0.0;
            double speed = 60.00;
            double fiveHours = 5;
            double eightHours = 8;
            double twelveHours = 12;
            double traveledDistanceFiveHours = 0.0;
            double traveledDistanceEightHours = 0.0;
            double traveledDistanceTwelveHours = 0.0;

            //INPUT
            Console.WriteLine("Enter the distance you plan on traveling:");
            distance =double.Parse(Console.ReadLine());

        //PROCESSES
            traveledDistanceFiveHours = (speed * fiveHours) * distance;
            traveledDistanceEightHours = (speed * eightHours) * distance;
            traveledDistanceTwelveHours = (speed * twelveHours) * distance;


            //OUTPUT
            Console.WriteLine($"Your total distance traveled in 5 hours is {traveledDistanceFiveHours} mph.");
            Console.WriteLine($"Your total distance traveled in 8 hours is {traveledDistanceEightHours}mph.");
            Console.WriteLine($"Your total distance traveled in 12 hours is {traveledDistanceTwelveHours} mph.");


        } //END MAIN
    } //END CLASS
} //END NAMESPACE
