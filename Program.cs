using System;

namespace FortuneTellerMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare global variables

            string fName ="";
            string lName = "";
            int age=0;
            int bMonth= 0;
            string favColor = "";



            //call the methods

           FirstName(fName);
           LastName(lName);
           Greet(fName, lName);
           Age(age);
           FavColor(favColor);
            

        }
        //Methods

        

        public static string FirstName(string fName)
        {
            Console.WriteLine("Please enter your first name");
            fName = Console.ReadLine().ToLower();
            return fName;
        }

        public static string LastName(string lName)
        {
            Console.WriteLine("Please enter your last name");
            lName = Console.ReadLine().ToLower();
            return lName;
        }

        public static void Greet(string fName, string lName)
        {
            
            Console.WriteLine("Greetings, " + fName + " " + lName + "I will tell you your fortune!");
        }

        public static int Age(int age)
        {
            Console.WriteLine("Please enter your age");
            age = int.Parse(Console.ReadLine());
            return age;
        }

        public static int BMonth(int bMonth)
        {
            Console.WriteLine("Please enter the month you were born in from 1= January through 12 = December");
            bMonth = int.Parse(Console.ReadLine());
            return bMonth;
        }

        public static string FavColor(string favColor)
        {
            Console.WriteLine("Please tell me your favorite color of the rainbow from the choices ROYGBIV. If you don't understand the question, please type Help");
            favColor = Console.ReadLine().ToLower();

            if (favColor == "help")
            {
                Console.WriteLine("roygbiv is an acronym for the colors of the rainbow. r=red, o=orange, y=yellow, g=green, b=blue, i=indigo, v=violet.");
                Console.WriteLine();
                Console.WriteLine("Now, please enter your favorite color");
                favColor = Console.ReadLine().ToLower();
                return favColor;
            }
            else if (favColor != "help")
            {
                return favColor;
            }
            else return favColor;
        }



    }
}
