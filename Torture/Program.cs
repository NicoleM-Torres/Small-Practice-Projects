namespace Torture
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = PromptTryInt("Please enter a number");
            Console.WriteLine(number);



        }//end main
        #region FUNCTIONS
        //DataRequestExample
        static int PromptTryInt(string dataRequest)
                {
                    //VARIABLE
                    int userInput = 0;
                    bool isValid = false;

                    //INPUT VALIDATION LOOP
                    do
                    {
                        Console.WriteLine(dataRequest);
                        isValid = int.TryParse(Console.ReadLine(), out userInput);
                    } while (isValid == false);

                    return userInput;

                } //END FUNCTION

        //PromptIntDouble Example

        static double PropmptTryInt (string dataRequest)
        {
            //VARIABLES
            int userInput = 0;
            bool isValid = false;

            //USER VALIDATION LOOP
            do
            {
                Console.WriteLine(dataRequest);
                isValid = int.TryParse (Console.ReadLine(), out userInput);
            } while (isValid != false);

            return userInput;


        } //END FUNCTION
        #endregion

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
