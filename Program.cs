using System;

namespace Largest_Small_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
              Find the Largest Number (using loops)
             The process of finding the maximum value (i.e., the largest of a group of values) is used frequently in computer applications. For example, 
             an app that determines the winner of a sales contest would input the number of units sold by each salesperson. The salesperson who sells the most units wins the contest. 
             Write pseudocode, then a C# app that inputs a series of 10 integers, then determines and displays the largest integer. Your app should use at least the following three variables:
           a) counter: A counter to count to 10 (i.e., to keep track of how many numbers have been input and to determine when all 10 numbers have been processed).
           b) number: The integer most recently input by the user.
           c) largest: The largest number found so far.
             */
            int counter = 0;
            int number = 0;
            int largest = 0;

            for (counter = 0; counter < 10; counter++)
            {
                Console.WriteLine("Please enter an integer number");
                number = Convert.ToInt32(Console.ReadLine());

                if (counter == 0)
                    largest = number;
                else
                    if (number > largest)
                    largest = number;
            }
            Console.Write("The largest number entered is: {0:N}", largest);
        }
    }
}
