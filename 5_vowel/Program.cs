using System;
/*
 * =========================      Test #1 Winter 2016      =========================
 * 
 * Name:Shafiq-Ur-Rehman   
 * Student ID:300621334
 *
 * Question 4.
 * ?? Marks.
 *
 * Write a program that prompt the user for a single letter. 
 * If the letter is a vowel it displays the message "vowel"
 * else it displays the message "consonant". 
 * 
 * You must use a switch statement for this solution
 * 
 * [Solution: Question4a]
 */


namespace _5_vowel
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type a single character:");
            string ch = Console.ReadLine();
            string cap = ch.ToUpper();


            switch (cap)
            {
                case "A":
                case "E":
                case "I":
                case "O":
                case "U":
                    Console.WriteLine("Vowel");
                    break;

                default:
                    Console.WriteLine("Consonant");
                    break;
            }




           /* if(cap == "A" ||  cap == "E" || cap == "I" || cap == "O" || cap == "U")
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }*/



        }
    }
}
