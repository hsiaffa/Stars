// Grading ID: 1566
// Course: 199-75
// Due Date: March 29, 2020
// Lab 7
// This application  allows the user to enter a positive integer representing the number of stars per side desired.
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numstars; // Declearing the variable 
            do
            { 
                bool validEntry; // declearing the variable
                string userInput; // Declearing the variable 
                Write("User input: "); // user input
                userInput = ReadLine();// Reading the user Input through the ReadLine Method
                validEntry = int.TryParse(userInput, out numstars); // Reading the user Input through the TryParse method 
            }
            while (numstars <= 0); // loop
            
            ShowSquareOfStars(numstars); // method that output numstar
        }
        private static void ShowSquareOfStars(int numstars) // method 
        {

            for (int i = 0; i < numstars; i++) // for loop for the stars vertically
            {
                WriteLine(); // output

                for (int x = 0; x < numstars; x++) // // for loop for the stars horizontally
                {
                    Write("*"); // output for *
                }
                
            }
        }
    }
}