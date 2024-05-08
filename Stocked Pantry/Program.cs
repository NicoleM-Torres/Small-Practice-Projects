namespace Stocked_Pantry
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //VARIABLES
            string pantry = "";
            string stock = "";

            

            

            //DO-WHILE LOOP
            do
                {   
                    Console.WriteLine("Is the pantry full?");
                    pantry = double.Parse(Console.ReadLine());
                    
                }
                while (pantry == "no");
            {
                Console.WriteLine("Bags added to pantry:");
                stock += Convert.ToInt32(Console.ReadLine());
            }
            //OUTPUT
                Console.WriteLine($"Your pantry is full. There are {stock} in stock.");

            
            















        } //END MAIN
    } //END CLASS
} //END NAMESPACE 
