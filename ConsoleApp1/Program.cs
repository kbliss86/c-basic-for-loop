using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Basic For Loops Lab

            Description:
            Create a program that prompts the user to enter a number. The program will then use a for-loop to calculate the sum of all numbers from 1 up to the number entered by the user.
            */

            /*
            Task:
            1. Prompt the user to enter a number.
            2. Use a for-loop to calculate the sum of all numbers from 1 to the number entered by the user.
            3. After displaying the result, ask the user if they would like to continue. If yes, repeat the process. If no, exit the program and display "Goodbye!".
            */

            /*
            Build Specifications:
            - Implement a for-loop to calculate the sum of integers from 1 to the user’s input.
            - Ensure proper user input handling and output formatting.
            - Continue looping until the user decides to exit the program.
            */

            /*
            Hints:
            Remember that a for-loop can handle this problem efficiently. Make sure to sum each number properly within the loop.
            */

            /*
            Example:

            >> Enter a number: << 100
            >> 5050
            Would you like to continue (y/n)? << y
            >> Enter a number: << 20
            >> 210
            Would you like to continue (y/n)? << n
            << Goodbye!
            */
            //Variables
            int userInput;
            bool validInput;
            int runningSumedInput = 0;
            
            //do while to ensure user input is correct
            do
            {
                //User Prompt
                Console.WriteLine("Enter a numer so we can do a running sum of that number!");
                //Collect Input as a string
                string input = Console.ReadLine();
                //Try Parse to ensure valid input type
                validInput = int.TryParse(input, out userInput);

                //Conditional to verify valid input
                if (!validInput)
                {
                    //Tell the user to do better
                    Console.WriteLine("Please enter a valid number");
                }

            }
            while (!validInput);//While Condition
            //For loop to calculate the running sum
            for (int i = 1; i < userInput + 1; i++)
            {
                //takes the initial value, adds the initial value plus the iteration value
                runningSumedInput = runningSumedInput + i;
                //Displays sum back to user as it is compiling
                Console.WriteLine($"Running Sum {runningSumedInput}");
            }
            //Display Running Sum Total
            Console.WriteLine($"Running Sum Total: {runningSumedInput}");
            Console.ReadLine();
        }//End Main
    }//End Class
}//End Namespace
