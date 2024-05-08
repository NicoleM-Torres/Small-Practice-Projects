namespace Water_Freezing_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double water = 0.0;
            Console.WriteLine("Enter water tempt:");
            water = double.Parse(Console.ReadLine());

            if (water < 30)
            {
                Console.WriteLine("The water is frozen.");
            } else if (water > 32 )
            {
                Console.WriteLine("The water is fine");
            }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        } //END MAIN
    } //END CLASS
} //END NAMESPACE
