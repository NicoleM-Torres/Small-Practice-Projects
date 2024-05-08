namespace Color_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ColorRainfall();

           
        }//end main

        //ARRAY OF DAYS
        static void ColorfulDays()
        {   //DECLARE VARIABLES
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            Console.Write("I hate ");
            ColorText(days[0], ConsoleColor.Blue, false);
            Console.WriteLine( "s 2 they suck.");


            Console.WriteLine("I love ");
            ColorText(days[1], ConsoleColor.Green, false);




        } //END COLORFUL DAYS FUNCTION
        static void ColorText (string message, ConsoleColor color, bool isWriteLine = true) {

            Console.ForegroundColor = color;
            if (isWriteLine) {  
                Console.WriteLine(message); 
            
            } else { 
                Console.WriteLine(message);
                Console.ResetColor();
            } //END IF-ELSE LOOP           
           
        } //END COLOR TEXT FUNCTION

                                        //RAINFALL PROJECT
        static void ColorRainfall()
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] month = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec" };
            ConsoleColor[] colors = {ConsoleColor.Red, ConsoleColor.Green,ConsoleColor.Blue, ConsoleColor.Magenta, ConsoleColor.Yellow, ConsoleColor.DarkGreen, ConsoleColor.White, ConsoleColor.Cyan, ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGray, ConsoleColor.DarkGreen, };
            double avgRainfall = 0.0;
            double totalRain = 0.0;
            int years = 0;

            years = PromptInt("How many years will we be tracking rainfall");

            for (int y = 0; y < years; y++)
            {
                for (int m =0; m < 12; m++ )
                {
                    totalRain += PromptColorDouble($"How much rain in {month[m]}?",colors[m]);
                } //END NESTED FOR
            } //MAIN FOR LOOP

            avgRainfall = totalRain / (years * 12);
            Console.WriteLine($"The avg monthly rainfall for {years} years was {avgRainfall}\nTotal Rainfall was {totalRain}");

        }//COLORRAINFALL FUNCTION
        static double PromptColorDouble(string message, ConsoleColor color)
        {
            double value = 0.0;

            Console.ForegroundColor = color;
            Console.WriteLine(message);

            Console.ResetColor();
            value = double.Parse(Console.ReadLine());
            
            return value;
        } //END PROMPT COLOR DOUBLE FUNCTION 







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
