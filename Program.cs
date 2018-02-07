using System;

namespace FortuneTellerMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables  why aren't these global?

            string fName = "";
            string lName = "";
            int age = 0;
            int bMonth = 0;
            string favColor = "";
            int numSibs = 0;
            string evenOrOdd = "";
            int yearsToRetire = 0;
            string vacHome = "";
            string transportation = "";
            string bankAccount = "";

            //Take user input

            Console.WriteLine("Please enter your first name");
            fName = Console.ReadLine().ToLower();

            Console.WriteLine("Please enter your last name");
            lName = Console.ReadLine().ToLower();

            Greet(fName, lName);

            //Console.WriteLine("Please enter your age");
            //age = int.Parse(Console.ReadLine());

            Retire(age);


            FavColor(favColor);

            Console.WriteLine("Now please tell me how many siblings do you have");
            numSibs = int.Parse(Console.ReadLine());

            VacHome(numSibs);



        }





        static void Greet(string fName, string lName)
        {

            Console.WriteLine("Greetings, " + fName + " " + lName + " I will tell you your fortune!");
        }

        //static int Age(int age)
        //{
        //    Console.WriteLine("Please enter your age");
        //    age = int.Parse(Console.ReadLine());
        //    return age;
        //}

        static int BMonth(int bMonth)
        {
            Console.WriteLine("Please enter the month you were born in from 1= January through 12 = December");
            bMonth = int.Parse(Console.ReadLine());
            return bMonth;
        }

        static string FavColor(string favColor)
        {
            Console.WriteLine("Please tell me your favorite color of the rainbow from the choices ROYGBIV. If you don't understand the question, please type Help");
            favColor = Console.ReadLine().ToLower();

            if (favColor == "help")
            {
                Console.WriteLine("roygbiv is an acronym for the colors of the rainbow. r=red, o=orange, y=yellow, g=green, b=blue, i=indigo, v=violet.");
                Console.WriteLine();
                Console.WriteLine("Now, please enter your favorite color");
                favColor = Console.ReadLine().ToLower();
                Console.WriteLine("Thanks!");
                return favColor;
            }
            else if (favColor != "help")
            {
                Console.WriteLine("That's a good choice.");
                return favColor;
            }
            else return favColor;
        }

        static int Retire(int yearsToRetire)
        {
            string evenOrOdd = "";
            int age;
            Console.WriteLine("Please enter your age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine(age);
            if (age % 2 == 0)
            {
                evenOrOdd = "even";
                yearsToRetire = 20;
                Console.WriteLine("You can retire in " + yearsToRetire + " years.");
                return yearsToRetire;

            }
            else
            {
                evenOrOdd = "odd";
                yearsToRetire = 25;
                Console.WriteLine("You can retire in " + yearsToRetire + " years.");
                return yearsToRetire;

            }
        }
        static void VacHome(int loc)
        {
            
            string vacAt = "";
            int numSibs = loc;
            switch (loc)

            {
                case 0:
                    vacAt = "Brown's stadium";
                    Console.WriteLine("You'll be vacationing at " + vacAt);
                    break;


                case 1:
                    vacAt = "Sandusky";
                    Console.WriteLine("You'll be vacationing at " + vacAt);
                    break;

                case 2:
                    vacAt = "Miami Beach";
                    Console.WriteLine("You'll be vacationing at " + vacAt);
                    break;

                case 3:
                    vacAt = "Disney Land";
                    Console.WriteLine("You'll be vacationing at " + vacAt);
                    break;

                default:
                    
                    
                    Console.WriteLine(numSibs);
                    if (numSibs < 0)
                    {
                        vacAt = "rest room at Denny's";
                        
                    }
                    else if (numSibs > 3)
                    {
                        vacAt = "Hilton Head";
                        
                    }

                    Console.WriteLine("You'll be vacationing at " + vacAt);
                    break;
            }




        }


    }
}
