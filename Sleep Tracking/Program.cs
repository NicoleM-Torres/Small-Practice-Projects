namespace Sleep_Tracking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
            double average = 0.0;
            int total = 0;
            int days = 7;
            
            //DO-WHILE LOOP
            do
            {//INPUT
                
            Console.WriteLine("How many hours did you sleep last night?");
                total += Convert.ToInt32(Console.ReadLine());
    
                    days--;
            }
            while (days > 0);

            //OUTPUT
            Console.WriteLine($"Average hours of sleep a week is {average*7}");
            Console.WriteLine($"Your total hours of sleep this week is {total}");

        } //END MAIN
    } //END CLASS
} //END NAMESPACE
