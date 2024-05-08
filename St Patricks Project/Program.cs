namespace St_Patricks_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
            double drinkPrice = 0.0;
            double tip = 0.0;
            double subtotal = 0.0;
            double tax = 0.05;
            double total = 0.0;


            //INPUT
            Console.WriteLine("How much does the drink cost?");
            drinkPrice = double.Parse(Console.ReadLine());

            //LOOP
            
            bool finished = false;
            

            while (finished !=false)
            {
                string answer="";

                answer = Prompt($"Are you finished?");
                answer = answer.ToLower();

                Console.WriteLine($"Are you finished?{drinkPrice}");
                {
                    if (Console.ReadKey(false).KeyChar == 'n')
                    finished = false;
                    
                    
                }
                finished = Console.ReadKey(false).KeyChar == 'n';
            }
            
            //INPUT
            Console.WriteLine("Enter tip amount: ");
            tip = double.Parse(Console.ReadLine());

            //PROCESSES
            total = (subtotal * tax) + tip;

            //OUTPUT
            Console.WriteLine($"SUBTOTAL -- {subtotal}");
            Console.WriteLine($"TIP -- {tip}");
            Console.WriteLine($"TAX -- {subtotal * tax}");
            Console.WriteLine($"TOTAL -- {total}");

        } //END MAIN
    } // END CLASS
} //END NAMESPACE
