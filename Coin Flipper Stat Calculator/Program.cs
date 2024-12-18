﻿namespace Coin_Flipper_Stat_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoinFlipping();

        }//end main
            static void CoinFlipping()
        {
            //DECLARE VARIABLES
                int heads = 0;
                int tails = 0;
                double avg = 0.0;
                double percentageHeads = 0.0;
                int flipCount = PromptInt("How many times do you want to flip the coin? ");
                Random coin = new Random();

            //CREATE LOOPS THAT FLIPS COIN
                for (int flip  = 0; flip < flipCount; flip++) { 
            //FLIP THE COIN
                int outcome = coin.Next(2);

            //STORE OUTCOME OF COIN FLIP ( 0 - Heads ; 1- Tails)
                if (outcome == 0)
                {
                    heads += 1;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Heads");
                } else
                {
                    tails += 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Tails");
                } //END IF
            
            } //END FOR
                Console.ResetColor();
            
            //CALCULATE % OF COIN FLIPS
                percentageHeads = (double)heads / (double)flipCount;
            //OUTPUT ALL RELEVANT DATA 
            Console.WriteLine($"\nPercentage of Heads = {percentageHeads}");
        } //END FUNCTION






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

            //REQUEST AND RECEIVE BACK USER RESPONSE AND STORE INTO VARIABLE
            userResponse = int.Parse(Prompt(dataRequest));

            //RETURN THE REQUESTED DATA BACK TO THE CALLING CODE-BLOCK
            return userResponse;
        }//end function

        static double PromptDouble(string dataRequest)
        {
            //CREATE VARIABLE TO STORE THE USER RESPONSE
            double userResponse = 0;

            //REQUEST AND RECEIVE BACK USER RESPONSE AND STORE INTO VARIABLE
            userResponse = double.Parse(Prompt(dataRequest));

            //RETURN THE REQUESTED DATA BACK TO THE CALLING CODE-BLOCK
            return userResponse;
        }//end function

        #endregion
    }//end class
}//end namespace
