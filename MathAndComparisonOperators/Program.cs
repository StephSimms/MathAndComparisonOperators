using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //int num1 = 200 / 3;
            //Console.WriteLine(num1);
            //Console.ReadLine();

            //bool trueorfalse = 12 < 5;
            //Console.WriteLine(trueorfalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 70;

            //bool isWarm = currentTemperature >= roomTemperature;
            //bool isWarm = currentTemperature != roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string yourNumberString = Console.ReadLine();
            //int yourNumberInt = Convert.ToInt32(yourNumberString);
            //Console.WriteLine("Let's multiply your favorite number by 50");
            //int product = yourNumberInt * 50;
            //Console.WriteLine(product);
            //Console.ReadLine();



            //Console.WriteLine("Type a number and we will add 25 to it.");
            //string yourNumberString = Console.ReadLine();
            //int yourNumberInt = Convert.ToInt32(yourNumberString);
            //Console.WriteLine("Your number plus 25 is: ");
            //int total = yourNumberInt + 25;
            //Console.WriteLine(total);
            //Console.ReadLine();

            //Console.WriteLine("Type a number and we will divide it by 12.5");
            //string yourNumberString = Console.ReadLine();
            //int yourNumberInt = Convert.ToInt32(yourNumberString);
            //Console.WriteLine("Your number divided by 12.5 is: ");
            //int quotient = (int)(yourNumberInt / 12.5);
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //Console.WriteLine("Type a number and we will tell you if it's greater than 50");
            //string yourNumberInt = Console.ReadLine();
            //bool trueorfalse = string yourNumberInt > 50;
            //Console.WriteLine(trueorfalse.ToString());
            //Console.ReadLine();

            //Console.WriteLine("Type a number and we will divide it by 7 and print the remainder");
            //string yourNumberString = Console.ReadLine();
            //int yourNumberInt = Convert.ToInt32(yourNumberString);
            //Console.WriteLine("The remainder is: ");
            //int remainder = (int)(yourNumberInt % 7);
            //Console.WriteLine(remainder);
            //Console.ReadLine();


            //Income Comparison Assignment

            //Console.WriteLine("Anonymous Income Comparison Program");
            //Console.WriteLine("Person 1");
            //Console.WriteLine("What is your hourly rate?: ");
            //int yourNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("What are your hours worked this week?: ");
            //int yourNumber1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Person 2");
            //Console.WriteLine("What is your hourly rate?: ");
            //int yourNumber2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("What are your hours worked this week?: ");
            //int yourNumber3 = Convert.ToInt32(Console.ReadLine());

            //int product = yourNumber * yourNumber1 * 52;
            //Console.WriteLine("Annual Salary of Person 1 is: $ " + product);

            //Console.WriteLine(product);
            //int product1 = yourNumber2 * yourNumber3 * 52;
            //Console.ReadLine();
            //Console.WriteLine("Annual Salary of Person 2 is: $ " + product1);
            //bool isSalary = product > product1;
            //Console.WriteLine("Does Person 1 make more than Person2 ?");
            //Console.WriteLine(isSalary);
            //Console.ReadLine();





            // Console.WriteLine("What is your favorite number?");
            //string yourNumberString = Console.ReadLine();
            //int yourNumberInt = Convert.ToInt32(yourNumberString);
            //Console.WriteLine("Let's multiply your favorite number by 50");
            //int product = yourNumberInt * 50;
            //Console.WriteLine(product);
            //Console.ReadLine();


            //Console.ReadLine();


            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);

            //Console.WriteLine(true == true);
            //Console.WriteLine(true == false);
            //Console.WriteLine(false == false);

            //Console.WriteLine(true != true);
            //Console.WriteLine(true != false);
            //Console.WriteLine(false != false);

            //Console.WriteLine(true ^ true);
            //Console.WriteLine(true ^ false);
            //Console.WriteLine(false ^ false);


            Console.WriteLine("What is your age?: ");
            string yourNumberString = Console.ReadLine();
            int yourNumberint = Convert.ToInt32(yourNumberString);
            bool trueorfalse = false;
            if(yourNumberint > 15)
            {
               trueorfalse = true;
            }
            Console.WriteLine(trueorfalse.ToString());
            Console.ReadLine();


            Console.WriteLine("Have you ever had a DUI?: Please enter True or False. ");
            bool yourDUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?: ");
            int yourTickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");

            if (yourNumberint > 15 && yourDUI == false && yourTickets <= 3)
            {
                bool TrueorFalse = true;
                Console.WriteLine("You are Qualified!");
            }

            else if (yourNumberint < 15 && yourDUI == true && yourTickets > 3)
            {
                bool TrueorFalse = false;
                Console.WriteLine("You are NOT Qualified!");
            }
            Console.ReadLine();

            //                
            //            Console.WriteLine(trueorfalse.ToString());
            //            Console.ReadLine();

            //    if (1 == 1)
            //{
            //    Console.WriteLine("1 equals 1!");
            //}
            //else
            //{
            //    Console.WriteLine("1 does not equal 1!");

            //}

            //    Console.ReadLine();

            //string name = "Brett";
            //if (name == "Jesse")
            //{
            //    Console.WriteLine("Your name is Jesse");
            //}
            //else
            //{
            //    Console.WriteLine("Your name is not Jesse");
            //}
            //Console.ReadLine();

            //string name = "Erik";
            //if (name == "Jesse")
            //{
            //    Console.WriteLine("Your name is Jesse");
            //}
            //else if (name == "Brett")
            //{
            //    Console.WriteLine("Your name is not Jesse");
            //}
            //else if (name == "Adam")
            //{
            //    Console.WriteLine("Your name is Adam");
            //}
            //Console.ReadLine();

            //if (1 != 1)
            //{
            //    Console.WriteLine("All is right in the universe.");
            //}
            //else
            //{
            //    Console.WriteLine("We live in a bizarro world.");
            //}

            //Console.ReadLine();

            //int num1 = 19;
            //int num2 = 12;
            //if (num1 > num2)
            //{
            //    Console.WriteLine("The first number is larger.");
            //}
            //else
            //{
            //    Console.WriteLine("The second number is larger.");
            //}
            //Console.ReadLine();

            //int age = 10;
            //if (age <= 25)
            //{
            //    Console.WriteLine("No you may not purchase that bottle of wine.");
            //}
            //else
            //{
            //    Console.WriteLine("There you go!");
            //}
            //Console.ReadLine();

            //int num1 = 12;
            //int num2 = 7;

            //string result = num1 > num2 ? "num1 is greater than num2" : "num1 is not greater than num2";
            //Console.WriteLine(result);
            //Console.ReadLine();





        }
    }
}
        //Console.WriteLine("Type a number and we will tell you if it's greater than 50");
        //string yourNumberInt = Console.ReadLine();
        //bool trueorfalse = string yourNumberInt > 50;
        //Console.WriteLine(trueorfalse.ToString());
        //Console.ReadLine();


        //if (1 == 1)
        //{
        //    Console.WriteLine("1 equals 1!");
        //}
        //else
        //{
        //    Console.WriteLine("1 does not equal 1!");
        //}


        //string name = "Adam";
        //if (name == "Jesse")
        //{
        //    Console.WriteLine("Your name is Jesse");
        //}
        //else if (name == "Brett") ;
        //{
        //    Console.WriteLine("Your name is not Jesse");
        //}
        //else
        //{
        //    Console.WriteLine("Your name is not Jesse. Your name is not Brett");
        //}


        //if (1 == 1)
        //{
        //    Console.WriteLine("1 equals 1!");
        //}
        //else
        //{
        //    Console.WriteLine("1 does not equal 1!");
        //}
        //{

        //    if (1 == 1)
        //    {
        //        Console.WriteLine("1 equals 1!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("1 does not equal 1!");
        //    }
        //}

