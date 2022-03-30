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

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?: ");
            int yourNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What are your hours worked this week?: ");
            int yourNumber1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?: ");
            int yourNumber2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What are your hours worked this week?: ");
            int yourNumber3 = Convert.ToInt32(Console.ReadLine());
            
            int product = yourNumber * yourNumber1 * 52;
            Console.WriteLine("Annual Salary of Person 1 is: $ " + product);
            
            Console.WriteLine(product);
            int product1 = yourNumber2 * yourNumber3 * 52;
            Console.ReadLine();
            Console.WriteLine("Annual Salary of Person 2 is: $ " + product1);
            bool isSalary = product > product1;
            Console.WriteLine("Does Person 1 make more than Person2 ?");
            Console.WriteLine(isSalary);
            Console.ReadLine();





            // Console.WriteLine("What is your favorite number?");
            //string yourNumberString = Console.ReadLine();
            //int yourNumberInt = Convert.ToInt32(yourNumberString);
            //Console.WriteLine("Let's multiply your favorite number by 50");
            //int product = yourNumberInt * 50;
            //Console.WriteLine(product);
            //Console.ReadLine();


            Console.ReadLine();

           
        }
    }
}
