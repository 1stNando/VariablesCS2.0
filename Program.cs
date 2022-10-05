using System;
using System.Collections.Generic;
using System.Linq;

namespace VariablesCS2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Welcome to C#");
            Console.WriteLine("\n");

            var todayDate = DateTime.Now.ToString();
            var nando = ("Fernando J. V. Aguilar");

            Console.Write($"My name is {nando}");
            Console.Write("\nCould you please share your name with me? ");
            var userName = Console.ReadLine();
            Console.Write("How many cups of coffee do you drink every day? ");
            var numberOfCupsOfCoffee = Console.ReadLine();

            string respondToUser = $"Hello {userName}, I like that you drink {numberOfCupsOfCoffee} cups of coffee in one day. Not too shabby.\nBy the way today's date is {todayDate} ";
            Console.WriteLine(respondToUser);

            //Next:Getting input from user for basic math
            //string, firstNumberAsString, secondNumberAsString
            Console.WriteLine("Allow me to demonstrate my abilities. Please think of two whole numbers between 0 and 1000.");
            Console.Write("What is the first number you thought of?");
            string firstNumberAsString = Console.ReadLine();
            Console.WriteLine("Great, now give me a second number. ");
            string secondNumberAsString = Console.ReadLine();
            //then Convert string input into number using double.Parse.
            double firstOperand = double.Parse(firstNumberAsString);
            double secondOperand = double.Parse(secondNumberAsString);
            //Save the first value in a variable called firstOperand and second as secondOperand!

            //Part where we demonstrate basic math using the parsed variables above.
            var sum = firstOperand + secondOperand;
            var difference = firstOperand + secondOperand;
            var product = firstOperand * secondOperand;
            var quotient = firstOperand / secondOperand;
            var remainder = firstOperand % secondOperand;



            //Next section will use Console.Write(""); to visually present the math created above in the terminal side.
            Console.WriteLine($"The sum of {firstOperand}, and {secondOperand}, is {sum} ");
            Console.WriteLine($"The difference of {firstOperand}, and {secondOperand}, is {difference}");
            Console.WriteLine($"When I multiply {firstOperand} and {secondOperand} we get {product} ");
            Console.WriteLine($"The division of {firstOperand} by {secondOperand} is {quotient} ");
            Console.WriteLine($"And finally, to find the remainder our division we get {remainder} ");

            Console.Write("Thank you for your time, and have a nice day!\n\tTHE END. ");









        }
    }
}