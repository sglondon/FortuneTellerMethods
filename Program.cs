using System;

namespace FortuneTellerMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables  

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
            int bankAccount = 0;
            string vacAt = "";
            string mode = "";

            //Take user input

            Console.WriteLine("Please enter your first name");
            fName = Console.ReadLine().ToLower();

            Console.WriteLine("Please enter your last name");
            lName = Console.ReadLine().ToLower();

            Greet(fName, lName);

            Console.WriteLine("Please enter your age");
            age = int.Parse(Console.ReadLine());

            Retire(age);

            Console.WriteLine("Please tell me your favorite color of the rainbow from the choices ROYGBIV. If you don't understand the question, please type Help");
            favColor = Console.ReadLine().ToLower();
            FavColor(favColor);

            Console.WriteLine("Now please tell me how many siblings do you have");
            numSibs = int.Parse(Console.ReadLine());

            VacHome(numSibs);

            Console.WriteLine("Please enter the month you were born in from 1= January through 12 = December");
            bMonth = int.Parse(Console.ReadLine());
            //    Console.WriteLine(bMonth);
            BankAcct(bMonth);
            //
        //    Console.WriteLine(bankAccount);

            Console.WriteLine();
            Console.WriteLine("{0} {1} will retire in {2} years with ${3} in the bank, a vacation home in {4} and a {5}.", fName, lName, Retire(age), BankAcct(bMonth), VacHome(numSibs), Transport(favColor));

            

            MessageOne();


            //     Console.WriteLine("You will be traveling by" + Transport(favColor));

        }





        static void Greet(string fName, string lName)
        {

            Console.WriteLine("Greetings, " + fName + " " + lName + " I will tell you your fortune!");
        }

        //static int Age(int age)
        //{
        //   // Console.WriteLine("Please enter your age");
        //    //age = int.Parse(Console.ReadLine());
        //    return age;
        //}

        //static int BMonth(int bMonth)
        //{
        //    Console.WriteLine("Please enter the month you were born in from 1= January through 12 = December");
        //    bMonth = int.Parse(Console.ReadLine());
        //    return bMonth;
        //}

        static string FavColor(string favColor)
        {


            if (favColor == "help")
            {
                Console.WriteLine("roygbiv is an acronym for the colors of the rainbow. r=red, o=orange, y=yellow, g=green, b=blue, i=indigo, v=violet.");
                Console.WriteLine();
                Console.WriteLine("Now, please enter your favorite color");
                favColor = Console.ReadLine().ToLower();
                Console.WriteLine("Thanks!");
                Console.WriteLine(favColor);
                return favColor;
                

            }
            else if (favColor != "help")
            {
         //       Console.WriteLine("That's a good choice.");
                return favColor;
            }
            else return favColor;
        }

        static int Retire(int yearsToRetire)
        {
            int age = yearsToRetire;
            string evenOrOdd = "";
            
        //    Console.WriteLine("Please enter your age");
        //    age = int.Parse(Console.ReadLine());
            //  Console.WriteLine(age);
            if (age % 2 == 0)
            {
                evenOrOdd = "even";
                yearsToRetire = 20;
            //    Console.WriteLine("You can retire in " + yearsToRetire + " years.");
                return yearsToRetire;

            }
            else
            {
                evenOrOdd = "odd";
                yearsToRetire = 25;
            //    Console.WriteLine("You can retire in " + yearsToRetire + " years.");
                return yearsToRetire;

            }
        }


        static string VacHome(int loc)
        {

            string vacAt = "";
            int numSibs = loc;
            switch (loc)

            {
                case 0:
                    vacAt = "Brown's stadium";
                    // Console.WriteLine("You'll be vacationing at " + vacAt);
                    return vacAt;
                    break;


                case 1:
                    vacAt = "Sandusky";
                    //    Console.WriteLine("You'll be vacationing at " + vacAt);
                    return vacAt;
                    break;

                case 2:
                    vacAt = "Miami Beach";
                    //      Console.WriteLine("You'll be vacationing at " + vacAt);
                    return vacAt;
                    break;

                case 3:
                    vacAt = "Disney Land";
                    //     Console.WriteLine("You'll be vacationing at " + vacAt);
                    return vacAt;
                    break;

                default:


            //        Console.WriteLine(numSibs);
                    if (numSibs < 0)
                    {
                        vacAt = "rest room at Denny's";
                        return vacAt;

                    }
                    else if (numSibs > 3)
                    {
                        vacAt = "Hilton Head";
                        return vacAt;

                    }

              //      Console.WriteLine("You'll be vacationing at " + vacAt);
                    return vacAt;
            }
        }


        static string Transport(string favColor) //passing in favColor and switching on it, then returning the value assigned to mode to the method call
        {
            string mode = "";
         //   Console.WriteLine(favColor);
            switch (favColor)

            {

                case "red":
                    mode = "Bus";
             //       Console.WriteLine("You'll be traveling by " + mode);

                    return mode;






                case "orange":
                    mode = "Yugo";
                    return mode;




                case "yellow":
                    mode = "Honda Fit";
                    return mode;



                case "green":
                    mode = "Row Boat";
                    return mode;



                case "blue":
                    mode = "Rolls Royce";
                    return mode;



                case "indigo":
                    mode = "Airplane";
                    return mode;



                case "violet":
                    mode = "Horse Drawn Wagon";
                    return mode;



                default:  //if the user entered help more than once or left favorite color blank or entered a non roygbiv color, e.g. black
                    mode = "Squeaky shopping cart";
                    return mode;
            }

        }


            static int BankAcct(int bMonth)
        {

            int bankAccount;


            if ((bMonth > 0) && (bMonth <= 4))
            {
                bankAccount = 100000;
            //        Console.WriteLine(bankAccount);
                return bankAccount;
            }
            else if ((bMonth >= 5) && (bMonth <= 8))
            {
                bankAccount = 50000;
            //      Console.WriteLine(bankAccount);
                return bankAccount;
            }
            else if ((bMonth >= 9) && (bMonth <= 12))
            {
                bankAccount = 20000;
            //       Console.WriteLine(bankAccount);
                return bankAccount;
            }
            else 
            {
                bankAccount = 0;
            //        Console.WriteLine(bankAccount);
                return bankAccount;
            }
            //else
            //{
            //    return 0;
            //}


        }


        static void MessageOne()
        {
            Console.WriteLine("Your fortune is great!");
        }



    }
}
