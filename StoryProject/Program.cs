using System.Numerics;

namespace StoryProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIABLE
                string animal = "";
                string verb = "";
                string place = "";

            //OUTPUT MESSAGE
                Console.WriteLine("");
                Console.WriteLine("");

            //INPUT ANIMAL
                Console.Write("Enter an animal:");
                animal = Console.ReadLine();
            //INPUT VERB
                Console.Write("Enter a verb:");
        
                verb = Console.ReadLine();

            //INPUT PLACE
                Console.Write("Enter a place :");
                place = Console.ReadLine();

            //OUTPUT MESSAGE
            Console.WriteLine($"{animal} was excited! Today was his friends, Matt the grumpy lion\'s birthday at the {place}. {animal} was {verb} towards {place} as fast as he could, since he was running late.{animal} was ready to share his gift and eat cake.");
        
        } // end main
    } //end class
} //end namespace
