﻿using System;

namespace ClassProject_Deliverable_2_ConditionalStatement_Grading_NamiHuyenTram
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Programmer: (Nami) Huyen Tram
            Date: 9/12/2019
            Comments: ISM 4300.001F19 - Class Project - Deliverable 2 - Conditional Statement
           */

            // declare variable
            int percentGrade;

            // try catch to make sure program will not crash if user input a string data type.
            try
            {
                // asking user to input a number
                Console.WriteLine("What percent grade do you expect to earn in the ISM 4300 class?");

                // read the user input
                percentGrade = int.Parse(Console.ReadLine());

                // call GDisplay custom method
                GDisplay();

            } // end of try

            // catch and display message when user input a string data type
            catch
            {
                Console.Write("Your input was invalid. " +
                    "Please run the program again " +
                    "and enter a number in the 100 percent grade scale only! ");
            } // end of catch

            // This custom method wil make sure the percent grade input by the user fall into the range of 0 to 100
            void GDisplay()
            {
                // if user input a number > 100, message will be displayed to ask for another input
                if (percentGrade > 100)
                {
                    Console.Write("Wait! Your percent grade cannot be " +
                        "more than 100 in this class! Please input another number from 0 to 100: ");

                    // read the new input
                    percentGrade = int.Parse(Console.ReadLine());

                    // call GDisplay custom method to check the input again
                    GDisplay();
                }

                // if input falls into 0-100 range, display the grade by calling GradeDisplay method
                else
                {
                    GradeDisplay();
                }
            }

            // This custom method will display the letter grade accordingly to the percent grade input by user
            void GradeDisplay ()
            {
                if (percentGrade >= 98 && percentGrade <= 100)
                {
                    Console.WriteLine("Wow! It seems like you are going to get an A+");
                }
                else if (percentGrade >= 92 && percentGrade <= 97)
                {
                    Console.WriteLine("Good job! It seems like you are going to get an A");
                }
                else if (percentGrade >= 90 && percentGrade <= 91)
                {
                    Console.WriteLine("Keep it up! It seems like you are going to get an A-");
                }
                else if (percentGrade >= 88 && percentGrade <= 89)
                {
                    Console.WriteLine("Great! It seems like you are going to get a B+");
                }
                else if (percentGrade >= 82 && percentGrade <= 87)
                {
                    Console.WriteLine("Not bad! It seems like you are going to get a B");
                }
                else if (percentGrade >= 80 && percentGrade <= 81)
                {
                    Console.WriteLine("You can do better! It seems like you are going to get a B-");
                }
                else if (percentGrade >= 78 && percentGrade <= 79)
                {
                    Console.WriteLine("It seems like you are going to get a C+. Will you be happy with that?");
                }
                else if (percentGrade >= 72 && percentGrade <= 77)
                {
                    Console.WriteLine("It seems like you are getting a C. Really?");
                }
                else if (percentGrade >= 70 && percentGrade <= 71)
                {
                    Console.WriteLine("It seems like you are getting a C-. Work harder!");
                }
                else if (percentGrade >= 68 && percentGrade <= 69)
                {
                    Console.WriteLine("Wake yourself up! It seems like you are getting a D+");
                }
                else if (percentGrade >= 62 && percentGrade <= 67)
                {
                    Console.WriteLine("Are you planning to not graduate this semester? It seems like you are getting a D.");
                }
                else if (percentGrade >= 60 && percentGrade <= 61)
                {
                    Console.WriteLine("Talk to your advisor now! It seems like you are getting a D-");
                }
                else if (percentGrade < 60)
                {
                    Console.WriteLine("It seems like you are getting an F. What are you doing to your life?");
                }
            }

            // Write an instruction for user
            Console.WriteLine("Now press any key to close the window.");

            // stop the program and wait for user input to close the window.
            Console.ReadKey(true);
        }
    }
}
