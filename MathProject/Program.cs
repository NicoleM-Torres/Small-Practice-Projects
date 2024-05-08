namespace MathProject
{
    internal class Program
    {
        static void Main(string[] args)
        {   //VARIABLES
                double number1 = 0.0;
                double number2 = 0.0;
                double number3 = 0.0;


            //INPUT NUMBER
                Console.Write("Please enter a number: ");
                number1 = double.Parse(Console.ReadLine());

                Console.Write("Please enter a second number: ");
                number2 = double.Parse(Console.ReadLine());

                Console.Write("Please enter a third number: ");
                number3 = double.Parse(Console.ReadLine());

            //OUTPUT MESSAGE 
                Console.WriteLine($"{number1} times two is {number1 * 2}");
                Console.WriteLine($"{number2} plus one thousand six hundred and seventy five is {number2 + 1675}");
                Console.WriteLine($"{number3} divided by fifty two is {number3 % 52}");
                Console.WriteLine($"{ number1} x {number2} x {number3} = {number1 * number2 * number3}");
        } //end main
    } //end class
} // end namespace
