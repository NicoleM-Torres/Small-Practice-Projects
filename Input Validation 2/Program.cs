﻿
namespace Input_Validation_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
            string password = "Jalapenos";
            string userInput = Prompt("Please enter your passowrd: ");

            //WHILE LOOP
            while (userInput != password)
            {
                userInput = Prompt("WRONG PASSOWRD IDIOT! Enter correct password.");

            } //END WHILE

            Console.WriteLine("I'm in!");

            //END USER PASSWORD INPUT PROJECT


            //ROMAN NUMERAL MINI PROJECT 
            //VARIABLES
            int preRoman = 0;
            preRoman = PromptInt("ENter a number between 1-10");

            while (preRoman < 1 || preRoman > 10)
            {
                preRoman = PromptInt("ERROR - Enter a # between 1-10.");
            } //END WHILE

            RomanNumerals(preRoman);
        }//end main

        private static void RomanNumerals(int preRoman)
        {
            throw new NotImplementedException();
        }

        #region PROMPT FUNCTIONS
        static string Prompt(string dataRequest)
        {
            //CREATE VARIABLE TO STORE THE USER RESPONSE
            string userResponse = "";

            //WRITE THE REQUEST TO THE SCREEN FOR USER TO READ
            Console.WriteLine(dataRequest);

            //RECEIVE BACK USER RESPONSE AND STORE INTO VARIABLE
            userResponse = Console.ReadLine();

            //RETURN THE REQUESTED DATA BACK TO THE CALLING CODE-BLOCK
            return userResponse;
        }//end function

        static int PromptInt(string dataRequest)
        {
            //CREATE VARIABLE TO STORE THE USER RESPONSE
            int userResponse = 0;

            //WRITE THE REQUEST TO THE SCREEN FOR USER TO READ
            Console.WriteLine(dataRequest);

            //RECEIVE BACK USER RESPONSE AND STORE INTO VARIABLE
            userResponse = int.Parse(Prompt(dataRequest));

            //RETURN THE REQUESTED DATA BACK TO THE CALLING CODE-BLOCK
            return userResponse;
        }//end function

        static double PromptDouble(string dataRequest)
        {
            //CREATE VARIABLE TO STORE THE USER RESPONSE
            double userResponse = 0;

            //WRITE THE REQUEST TO THE SCREEN FOR USER TO READ
            Console.WriteLine(dataRequest);

            //RECEIVE BACK USER RESPONSE AND STORE INTO VARIABLE
            userResponse = double.Parse(Prompt(dataRequest));

            //RETURN THE REQUESTED DATA BACK TO THE CALLING CODE-BLOCK
            return userResponse;
        }//end function

        #endregion
    }//end class
}//end namespace
