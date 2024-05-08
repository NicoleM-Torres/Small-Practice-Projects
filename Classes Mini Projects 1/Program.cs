using System.Data;
using System.Globalization;
using System.Reflection;
using System.Xml.Schema;

namespace Classes_Mini_Projects_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Animal dog1 = new Animal();
            Animal dog2 = new Animal();
            Animal snake = new Animal();

            dog1.name = "Mochi";
            dog1.sound = "Woof";

            dog2.name = "Leo";
            dog2.sound = "Arf";

            snake.name = "Nagini";
            snake.sound = "SSSSSS";


            dog1.Eat(50);
            dog2.Eat(200);

            snake.MakeNoise();
            snake.Eat(75);
            snake.Eat(30);
            snake.Defecate();

            Console.WriteLine(dog1.name);
            Console.WriteLine(dog2.name);

            dog1.MakeNoise();

            Refrigerator myFridge = new Refrigerator("Samsung");
            Refrigerator second = new Refrigerator("MotherFu**er",true);

            Console.WriteLine($"My fridge is a {myFridge.GetModel()} model.");
            myFridge.Temp();
            Console.WriteLine($"The temperature is {myFridge.Temp}");
            myFridge.Groceries("potatoes, carrosts,");
            myFridge.Groceries("sauce");
            myFridge.CheckContents();
            dog2.MakeNoise();
            */

            Refrigerator myFridge = new Refrigerator("KKDRN", true);
            myFridge.CheckContents("");

            //--------------------------------------------------------| PET PROJECT |--------------------------------------------------------\\
            
            Pet myPet = new Pet();

            Console.WriteLine("What type of pet do you have?");
            myPet._type = Console.ReadLine();

            //pet1._name = "";
            Console.WriteLine("Enter your pets name:");
            myPet._name = Console.ReadLine();


            //pet1._type = "";
            Console.WriteLine("Enter your pets age:");
            myPet._age = Convert.ToInt32(Console.ReadLine());

            //pet1._age = 1;
            Console.Clear();

            Console.WriteLine($"Your pet is a {myPet._type}, their name is {myPet._name} and they are {myPet._age} years old.");

            //--------------------------------------------------------| CAR PROJECT |--------------------------------------------------------\\

          Console.Clear();

            Car myCar = new Car();

            Console.WriteLine("What is the car model you have?");
            myCar._make = Console.ReadLine();

            Console.WriteLine("What year?");
            myCar._year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your have a {myCar._make}, from the year {myCar._year}.");

            Console.WriteLine($"Enter your {myCar._make}'s speed:");
            myCar._speed = Convert.ToInt32(Console.ReadLine());

            //Console.Clear();

            Console.WriteLine($"Your {myCar._make}'s speed after accelerating is: {myCar.GetSpeedAcc}");
            Console.WriteLine($"Your {myCar._make}'s speed after breaking is: {myCar.GetSpeedBreak} ");

            Console.Clear();

            //--------------------------------------------------------| BOOK PROJECT |--------------------------------------------------------\\


            double realNum = 3.568875;
            Animal ham = new Animal();

            string text = realNum.ToString();
            string animalInfo = ham.ToString();

        }//END MAIN

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
    }//END CLASS

    #region Animals Project
    public class Animal
    {
        public string name = "";
        public string sound = "";
        public int age = 0;
        public int stomachCapacity = 100;
        public int currentFulness = 0;

        public void Eat(int amountOfFood)
        {
            if (currentFulness + amountOfFood <= stomachCapacity)
            {

                currentFulness += amountOfFood;
                Console.WriteLine($"{name} is {currentFulness}% full");

            }//END IF
            else
            {
                Console.WriteLine($"{name} cannot eat that much. They are currently {currentFulness}% full.");
            }
        } //END EAT FUNCTION

        public void Defecate()
        {
            if (currentFulness > 0)
            {
                currentFulness /= 2;
                Console.WriteLine($"{name} pooped {currentFulness} units of poo.");
            }
            else
            {
                Console.WriteLine("No shit");
            }
        }

        public void MakeNoise()
        {
            Console.WriteLine(sound);
        }//END MAKE NOISE FUNCTION



    }//END ANIMAL CLASS

    #endregion

    #region Refrigetor Project  
    public class Refrigerator
    {
        //VARIABLES
        double _temp = 35; //TEMPERATURE
        string _model = "";//MODEL NAME
        bool _hasFreezer = true;//hasFREEZER
        string _contents = "";

        #region CONSTRUCTORS
        public Refrigerator(string modelName)
        {
            _model = modelName;
            _temp = 35;

        }//END CONTRUCTOR

        public Refrigerator(string modelName, bool withFreezer)
        {
            _model = modelName;
            _hasFreezer = withFreezer;
            _temp = 35;

        }//END CONSTRUCTOR

        #endregion

        //METHODS

        public override string ToString()
        {
            return $"Temp: {_temp}, Model: {_model}, Contents: {_contents}, HasFreezer: {_hasFreezer}";
        }
        //RUN REFRIGERATOR (decrease temp by 2 deg)
        public void Temp()
        {
            _temp -= 2;
        }//COOL FUNCTION
         //ADDITEM

        //MUTATOR METHOD SETS A NEW VALUE TO A FIELD
        public void RefModel(string modelName)
        {           
            _model = modelName;
        }//SET MODEL FUNCTION
        public void Groceries(string items)
        {
            _contents += items + " ";
        }//ADD ITEM FUNCTION

        //ACCESOR METHOD GETS THE VALUE OF THE FIELD
        public string GetModel()
        {
            return _model;
        } //END GET MODEL FUNCTION
        
        //CHECK CONTENTS
        public void CheckContents()
        {
            Console.WriteLine($"The items in your refrigerator are: {_contents}");

        }//CHECK CONTENTS FUNCTION

    } //END REFRIGERATOR CLASS
    #endregion


    //--------------------------------------------------------| MINI PROJECTS |--------------------------------------------------------\\

    #region 0 Pet Class
    public class Pet
    {
            public string _name;
            public string _type;
            public int _age;

        public Pet()
        {

        }

        public Pet(string name, string type, int age)
            {
                _name = name;
                _type = type;
                _age = age;
            }

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public string Type
            {
                get { return _type; }
                set { _type = value; }
            }

            public int Age
            {
                get { return _age; }
                set { _age = value; }
            }
        }

    #endregion

    #region 1 Car Class
    class Car
    {
        // Fields

        public int _year;
        public string _make;
        public int _speed;

        // Constructor, initalizies values
        public Car()
        {
            _year = 0;
            _make = "";
            _speed = 0;
        }

        // Year Method/Property
        // The value parameter is automatically created by the compiler.
        // It also sets itself as the same data type that the method/property are.
        // Since the compiler automatically creates the "value" parameter
        // we do not need to declare/initalize it. 

       
        public int GetYear
        {
            set { _year = value; }
            get { return _year; }
        }

        // Make Method/Property
        public string GetMake
        {
            set { _make = value; }
            get { return _make; }
        }

        // Speed Method/Property
        // Always initalized to 0
        // The "value" and therefore the "_speed" property are always initalized 0 when the accelerate button is hit
        // As that is what was initalized above and thus never changes. 
        // However at the end of the calculations from Accelerate "GetSpeed" and it's "_speed" property are equal to the reault
        // of said calculations. But are then re initalized to 0 after the accelerate button is hit again. 
        public int GetSpeedAcc
        {
            set { _speed = value; }
            get { return _speed; }
        }

        public int GetSpeedBreak
        {
            set { _speed = value; }
            get { return _speed; }
        }

        public int Accelerate(int spdResult)
        {
            // Every iteration of the loop "GetSpeed" is always equal to 0
            // For example:
            // GetSpeed = 0 + 5 + 0 = 0
            // GetSpeed = 0 + 5 + 5 = 10
            // GetSpeed = 0 + 5 + 10 = 15
            // And so on. 
            GetSpeedAcc = GetSpeedAcc + 5 + spdResult;
            return GetSpeedAcc;
        }

        public int Break(int spdResult)
        {
            //GetSpeed = GetSpeed - 5 + spdResult;
            GetSpeedBreak = spdResult - 7 + GetSpeedBreak;
            return GetSpeedBreak;

        }

    }//END CLASS

    //DISPLAY CURRENT SPEED OF CAR



    #endregion

    #region 2 Book Class

    public class Books
    {




    }//END BOOK CLASS




    #endregion


}//end namespace