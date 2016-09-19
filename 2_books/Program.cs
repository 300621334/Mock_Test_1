using System;
/*
 * =========================      Test #1 Winter 2016      =========================
 * 
 * Name: Shafiq-Ur-Rehman
 * Student ID: 300621334
 *
 * Question 1.
 * ?? Marks.
 *
 * Write a program that prompts the user for the name of a book 
 * and the number of books and then displays the following: 
 * "4 copies Introduction to Programming will cost $479.96"
 * [Assuming the inputs are "Introduction to Programming" and 4]
 * 
 * The cost of a book is $119.99 and it must be declared as a named constant
 * [Solution: Question1c]
 */

namespace _2_books
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is the title of the book?");
            string bookName = Console.ReadLine();

            Console.WriteLine("How many books do you like?");
            double books = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0} copies of {1} will cost {2:c}", books, bookName, books*119.99);


        }
    }
}
