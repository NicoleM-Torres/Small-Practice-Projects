﻿namespace While_Loop_and_Functions_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LoopPractice
            //VARIABLES
            int thirteen = 13;

            //DO-WHILE LOOP BEGIN   
            do
            {
                //OUTPUT
                Console.WriteLine("Thirteen is a unlucky number.");
                thirteen--; //END LOOP

            }
            while (thirteen > 0);

            //END DO-WHILE LOOP

            /*
            //LOOP:
                while (thirteen > 0)
                {   //OUTPUT
                    Console.WriteLine("Thirteen is a unlucky number.");
                    thirteen--; //END LOOP

                }// END WHILE 
            */


            #endregion

            #region TestClass Average
            int number = 0;
                String name = "";
             

                while (number <= 10)
                {
                    switch (number)
                    {

                        case 1:
                            name = "One";
                            break;
                        case 2:
                            name = "Two";
                            break;
                        case 3:
                            name = "Three";
                            break;
                        case 4:
                            name = "Four";
                            break;
                        case 5:
                            name = "Five";
                            break;
                        case 6:
                            name = "Six";
                            break;
                        case 7:
                            name = "Seven";
                            break;
                        case 8:
                            name = "Eight";
                            break;
                        case 9:
                            name = "Nine";
                            break;
                    }
                    return;

            } //end loop

            //GRADE POINT AVERAGE PROJECT

            //VARIABLES
            double tests = 0;
            double score = 0.0;
            double total = 0.0;
            double average = 0.0;

            //INPUT

            Console.WriteLine("Enter amount of tests taken this semester:");
            
            //PROCESSES
            average = score / tests;

            //OUTPUT

            Console.WriteLine($"Your class average is {average}");

            do {
            
            
            
            
            } while (tests );

            #endregion





        }//end main

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
