using System;
/*
 * =========================      Test #1 Winter 2016      =========================
 * 
 * Name: Shafiq-Ur-Rehman
 * Student ID:300621334
 *
 * Question 2.
 * ?? Marks.
 *
 * Write a program that prompt the user for two numbers and a letter. 
 * If the letter is a "+" then it display the message 
 * "The sum of 5 and 2 is 7" otherwise it displays the 
 * message "The difference between 5 and 2 is 3"
 * 
 * [Solution: Question2a]
 */

namespace _3_sum
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Enter the first number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("enter a letter for the operation:");
            string op = Console.ReadLine();

            int sum = a + b;
            int diff = a - b;


            if (op == "+")
            {
                Console.WriteLine("The sum of {0} and {1} is {2}", a, b, sum);

            }
            else
            {
                Console.WriteLine("The difference of {0} and {1} is {2}", a, b, diff);

            }









        }
    }
}
