using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Command Line Calculator!");
            Console.WriteLine("Please enter two numbers to either add, subtract, multiply, or divide.");
            string num1String = Console.ReadLine();
            float num1 = Convert.ToSingle(num1String);
            string num2String = Console.ReadLine();
            float num2 = Convert.ToSingle(num2String);
           
            Console.WriteLine("Would you like to add, subtract, multiply, or divide?");
            Console.WriteLine("Please enter +, -, *, or / for your choice.");
            string userChoice = Console.ReadLine();
            // Menu: Please enter q to quit

            switch(userChoice)
            {
                case "+":
                    // add two numbers and return sum
                    float sum = num1 + num2;
                    Console.WriteLine($"{num1String} + {num2String} = {sum}");
                    break;
                case "-":
                    // subtract 2nd # from 1st and return difference
                    float diff = num1 - num2;
                    Console.WriteLine($"{num1String} - {num2String} = {diff}");
                    break;
                case "*":
                    // multiply two numbers and return product
                    float product = num1 * num2;
                    Console.WriteLine($"{num1String} * {num2String} = {product}");
                    break;
                case "/":
                    // divide 1st # by 2nd and return quotient
                    float quotient = num1 / num2;
                    Console.WriteLine($"{num1String} / {num2String} = {quotient}");
                    break;
                // case q
                    // exit program
            }

            Console.WriteLine("Press any key to exit.");
            // ReadKey() is needed or console will close before user can see output
            Console.ReadKey();
        }
    }
}
