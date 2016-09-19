using System;
/*
 * =========================      Test #1 Winter 2016      =========================
 * 
 * Name:Shafiq-Ur-Rehman
 * Student ID:300621334
 *
 * Question 3.
 * ?? Marks.
 *
 * Write a program that prompt the user for a single integer. 
 * The program will display if the number is a multiple of
 * 2 or 3 or both or neither 2 nor 3. Use the modulus (%) to check
 * for divisibility
 * 
 * You must use an if statement for this solution
 * 
 * [Solution: Question3b]
 */
namespace _4_modulus
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number:");
            int a = Convert.ToInt32(Console.ReadLine());

            int remainder = a % 2;
            int remainder2 = a % 3;


            if (remainder == 0 && remainder2 == 0)
            {
                Console.WriteLine("{0} is divisible by both 2 & 3", a);

            }

            /*else if (remainder != 0 && remainder2 != 0)
            {Console.WriteLine("{0} is neither divisible 2 nor by 3", a);}
             this is negative logic & is not needed because if first "if" is true then opposite cannot be true & vice versa. So just put an "else" at the end. See below.*/

            else if (remainder == 0)
            {
                Console.WriteLine("{0} is divisible only by 2", a);

            }

            else if (remainder2 == 0)
            {
                Console.WriteLine("{0} is divisible only by 3", a);

            }

            else 
            {
                Console.WriteLine("{0} is neither divisible 2 nor by 3", a);
            }



        }
    }
}
