using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;

namespace Array_Mini_Projects_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /*           
            RainfallStats();
            ChipsAndSalsa();
            MakingCopies();
            RainfallStats(); 
            LotteryGenerator();
            RandomDiceRoller();
            TotalSales();
            */
        }//end main


        #region RandomDiceRoller
        static void RandomDiceRoller()
        {
            //DECLARE VARIABLES --- REQUEST DICE SIDES AND # OF ROLLS
            Random rdmnum = new Random(); //creates random #'s
            int sides = PromptInt("How many sides does your dice has?"); //userinput for sides
            int rolls = PromptInt($"How many times should we roll the d{sides}?"); //userinput for rolls
            int[] results = new int[rolls]; //array to store user inputs


            //ROLL ALL OF THE DICE
            /*(int i = 0)index is set to 0 , (i < results.Length) for loop will run as long as index is less than variable 'rolls'
            (i++) will increase index by 1 everytime loop runs until index = 'rolls*/
            for (int i = 0; i < results.Length; i++) {
                results[i] = rdmnum.Next(1, sides + 1); //max num is excluded with .Next so '+1' is added.
            } //END FOR

            //DISPLAY ALL DICE ROLLS
            Console.WriteLine("YOUR DICE OUTCOMES\n-------------------"); //Banner
            /*(int i = 0)index is set to 0 , (i < results.Length) for loop will run as long as index is less than variable 'results' lenght
            (i++) will increase index by 1 everytime loop runs until index = 'rolls*/
            for (int i = 0; i < results.Length; i++)
            {
                Console.Write(results[i] + "  "); //displays results with spacing between each other
            }//END FOR  

        }
        #endregion

        #region TotalSales
        static void TotalSales()
        {
            //DECLARE VARIABLES -- USER INPUT
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };//DAYS OF THE WEEK STORE SALES                  
            double[] dailySales = new double[days.Length];//TOTAL WEEK SALES

            //loop runs the amount of days and prompts user to enter sales amt
            for (int i = 0; i < days.Length; i++) {

                dailySales[i] = PromptDouble($"Enter cash amount of sales for {days[i]}:");//STORE SALES
                if (dailySales[i] < 0)
                {
                    Console.WriteLine("Please enter a number greater than 0");
                    i--;
                }
            }//END FOR LOOP             
            double sum = dailySales.Sum(); //variable sum = addition of daily sales var       
            Console.WriteLine($"Your total sales this week is {sum}");


        } //END FUNCTIONS
        #endregion

        #region Lottery Num Generator
        static void LotteryGenerator()
        {
            //VARIABLES
            Random rnd = new Random();
            int num = rnd.Next();//creates random #'s
            int[] lotteryNum = { 0, 1, 2, 3, 4, 5, 6 }; //saves 7 spaces for the lottery #

            //DISPLAY OF RND #'s
            Console.WriteLine("Your generated loterry number is:");
            //number generator
            for (int i = 0; i < lotteryNum.Length; i++)
            {
                Console.Write(rnd.Next(10) + "   "); //displays rnd #, with max # generated being 9
            }



        }//END FUNCTION 

        #endregion

        //can't call for lowest # in array
        #region Rainfall stats
        static void RainfallStats()
        {
            //DECLARE VARIABLES -- USER INPUT
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };//DAYS OF THE WEEK STORE SALES                  
            //double[] monthlyRainfall = new double[months.Length];//TOTAL monthly rainfall
            double[] monthlyRainfall = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            double rainfallMax = monthlyRainfall.Max();
            double rainfallMin = monthlyRainfall.Min();
            //loop runs the amount of months(12) and prompts user to enter rainfall amt
            for (int i = 0; i < months.Length; i++)
            {
                /*rainfall amount for a specific month (determined by the value of 
                 months[i]) and stores that value in the monthlyRainfall array at index i.*/
                monthlyRainfall[i] = PromptDouble($"Enter rainfall amount for {months[i]}:");//monthly rainfall user input

            }//END FOR LOOP             
            double sum = monthlyRainfall.Sum(); //variable sum = addition of monthlyRainfall var       
            Console.WriteLine($"The total yearly rainfall is {sum}");
            double avgRainfall = monthlyRainfall.Sum() * 12; //adds up all user input and multiplies it by 12
            Console.WriteLine($"The total average monthly rainfall is {avgRainfall}"); //displays yearly rainfall          
            //Console.WriteLine($"The month with the highest rainfall amount was {months.Max()} with {monthlyRainfall.Max()}%"); //dislays highest rainfall amt         
            //Console.WriteLine($"The month with the lowest rainfall amount was {months.Min()} with {monthlyRainfall.Min()}%"); //dislays lowest rainfall amt
            Console.WriteLine($"The month with the highest rainfall amount was {months.Max()} with {monthlyRainfall.Max()}%"); //dislays highest rainfall amt         
            Console.WriteLine($"The month with the lowest rainfall amount was {months.Min()} with {monthlyRainfall.Min()}%");

        } //END FUNCTIONS


        #endregion

        #region Making Copies   

        static void MakingCopies()
        {
            //VARIABLES
            int[] copies1 = { 13, 24, 37, 41, 55, 68, 97, 38, 90, 15, 12, 24, 23, 67, 100, 90, 78, 13, 19, 20, 21, 22, 56, 87, 90 };
            int[] copies2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
            int i = 0;


            //DISPLAY COPIES
            while (i < copies2.Length)
            {
                Console.WriteLine(copies1[i]);
                i++;


            } //end for

        }//END FUNCTION

        #endregion

        #region Chips&Salsa

        static void ChipsAndSalsa()
        {
            //DECLARE VARIABLES
            string[] salsas = { "mild", "medium", "sweet", "zesty", "hot" };
            int[] sold = { 0, 1, 2, 3, 4 };

            //loop runs the amount of months(12) and prompts user to enter rainfall amt
            for (int i = 0; i < salsas.Length; i++)
            {

                sold[i] = PromptInt($"Enter amount sold for {salsas[i]} salsa:");//salsas sold user input

                if (sold[i] < 0)
                {
                    Console.WriteLine("Enter a positive number.");
                    i--;
                }

            }//END FOR LOOP             
            double sum = sold.Sum(); //variable sum = addition of var sold
                                     
            Console.WriteLine($"The total of jars sold this month was {sum}");
            Console.WriteLine($"The highest selling salsa was {salsas.Max()} with {sold.Max()} jars sold."); //dislays highest jar amt sold        
            Console.WriteLine($"The lowest selling salsa was {salsas.Min()} with {sold.Min()} jars sold."); //dislays lowest jar amt sold
                                                                                                            //DISPLAY of salsa type and amt sold
            Console.WriteLine("\tMild:\tMedium:\tSweet:\tZesty:\tHot:\t");
            for (int i = 0; i < salsas.Length; i++)
            {
                //Console.WriteLine($"{sold[1]}\t{sold[2]}\t{sold[3]}\t{sold[4]}\t{sold[5]}");
                Console.Write($"\t{sold[i]}");
            }




        }//END FUNCTION

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
