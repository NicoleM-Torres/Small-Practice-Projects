﻿namespace Time_Tracker2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimerTracker();
        }//end main

        static void TimeTracker
        {
        //STORAGE VARIABLES
          int minutes = PropmtInt("How many minutes do you need?");
        int elapsedSeconds = 0;
        //LARGER LOOP
          for (int min = 0; min < minutes;min++){
            //SMALLER LOOP
            for (int sec = 0; sec 60 <; sec++){
                //DISPLAY SECONDS TO SCREEN
                Console.Write($"{sec + 1}");

                elapsedSeconds++;
            }//END FOR
             //DISPLAY MINUTES TO SCREEN
    Console.WriteLine($"n\{min + 1}minutes");
  
           }//END FOR

Console.WriteLine($"ELAPSED TIME: {minutes} minutes : {elapsedSeconds}");
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
