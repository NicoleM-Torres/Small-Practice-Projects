using System.Reflection.Metadata;
using System.Xml;

namespace Function_Prompt_Project_mar3
{
    internal class Program
    {
        static void Main(string[] args)
        {




        } //END MAIN

        static string Prompt (string message)
        {
            //VARIABLES
                string userInput = "";


            //REQUEST
                Console.WriteLine(message);


            //RECIEVE USER RESPONSE
                userInput = Console.ReadLine();

            //OUTPUT
                return userInput;



        } //END FUNCTION

        static int PromptInt (string text)
        {
            //VARIABLE
            int userInput = 0;

            //REQUEST
            Console.Write(text);

            //RECIEVE USER RESPONSE
            userInput = int.Parse(Console.ReadLine());

            //OUTPUT (EXPORT RESPONSE BACK TO PROGRAM)
            return userInput;   

        } //END FUNCTIONS TWO

        static double PromptDouble (string dataRequest) {
            //VARIABLE  
            double userInput = 0.0;

            //REQUEST AND RECIEVE INPUT
            userInput = double.Parse(Prompt(dataRequest));

            //OUTPUT 

            return userInput;
        
        } //END FUNCTION THREE
    } //END CLASS
} //END NAMESPACE
