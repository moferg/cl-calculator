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
            int userChoice;
            Console.WriteLine("Welcome to the Command Line Calculator!");

            do
            {          
                Console.WriteLine("Please enter two numbers to either add, subtract, multiply, or divide.");
                string num1String = Console.ReadLine();
                float num1 = Convert.ToSingle(num1String);
                string num2String = Console.ReadLine();
                float num2 = Convert.ToSingle(num2String);

                Console.WriteLine("Would you like to add, subtract, multiply, or divide?");
                Console.WriteLine("1) Add 2) Subtract 3) Multiply 4) Divide 5) Quit");
                userChoice = Convert.ToInt32(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        // add two numbers and return sum
                        float sum = num1 + num2;
                        Console.WriteLine($"{num1String} + {num2String} = {sum}");
                        break;
                    case 2:
                        // subtract 2nd # from 1st and return difference
                        float diff = num1 - num2;
                        Console.WriteLine($"{num1String} - {num2String} = {diff}");
                        break;
                    case 3:
                        // multiply two numbers and return product
                        float product = num1 * num2;
                        Console.WriteLine($"{num1String} * {num2String} = {product}");
                        break;
                    case 4:
                        // divide 1st # by 2nd and return quotient
                        float quotient = num1 / num2;
                        Console.WriteLine($"{num1String} / {num2String} = {quotient}");
                        break;
                }
            } while (userChoice != 5);
        }
    }
}
