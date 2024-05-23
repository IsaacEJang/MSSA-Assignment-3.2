using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_3._2
{
    internal class Program
    {
        static void Introduction()
        {
            // HEADER
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Week 2 Challenge Labs");
            Console.WriteLine("Name: Isaac Jang\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------PART 1---------------\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Transition()
        {
            // TRANSITION
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPress any key to continue!\n");
            Console.ReadKey();
        }

        static void Part(int i)
        {
            // PART 2
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n---------------PART {i}---------------\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void ClosingMessage()
        {
            // CLOSING MESSAGE
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nHave a great day!");
        }

        //static void TryAgain()
        //{
        //StartPoint:
        //    while (true)
        //    {
        //        // ask user if they want to try again
        //        Console.WriteLine("\nWant to try again? (Y / N)");
        //        char answer = char.Parse(Console.ReadLine().ToUpper());

        //        // wants to continue
        //        if (answer == 'Y')
        //        {
        //            goto StartPoint;
        //        }

        //        // does not want to continue
        //        else if (answer == 'N')
        //        {
        //            break;
        //        }

        //        // invaid entry
        //        else
        //        {
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine("\nEnter valid character");
        //            Console.ForegroundColor = ConsoleColor.White;
        //            continue;
        //        }
        //    }

        //}

        static void Main(string[] args)
        {
            #region Part1

            Introduction();
            StartPoint1:
            /*
            1.. Create a 2D array to store integers and print them in matrix format with proper formatting.
            e. g:
            | 2 | 3 | 4 |
            | 1 | 4 | 6 |
            */

            Console.WriteLine("\nWe will be creating and printing a matrix:\n");

            //rows
            Console.Write("Enter # of rows: ");
            int rows = int.Parse(Console.ReadLine());

            //columns
            Console.Write("Enter # of columns: ");
            int columns = int.Parse(Console.ReadLine());

            Console.WriteLine(); // spacer
            //creating matrix and setting size to 2 x 3
            int[,] matrix2D = new int[rows, columns];

            // for loops to store values
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Element - [{i}],[{j}]: ");
                    matrix2D[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // printing matrix
            Console.WriteLine("\nThe matrix is:\n");
            Console.ForegroundColor = ConsoleColor.Yellow;

            // for loops to print matrix
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"| {matrix2D[i, j]} ");
                }
                Console.Write("|\n"); // for formatting
            }
            Console.ForegroundColor = ConsoleColor.White;

            while (true)
            {
                // ask user if they want to try again
                Console.WriteLine("\nWant to try again? (Y / N)");
                char answer = char.Parse(Console.ReadLine().ToUpper());

                // wants to continue
                if (answer == 'Y')
                {
                    goto StartPoint1;
                }

                // does not want to continue
                else if (answer == 'N')
                {
                    break;
                }

                // invaid entry
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEnter valid character");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
            }
            #endregion

            #region Part2
            Transition();
            Part(2);
            StartPoint2:

            /*
            2. Write a program in C# Sharp for addition of two Matrices of same size.

            Test Data :
            Input the size of the square matrix (less than 5): 2

            Input elements in the first matrix :
            element - [0],[0] : 1
            element - [0],[1] : 2
            element - [1],[0] : 3
            element - [1],[1] : 4

            Input elements in the second matrix :
            element - [0],[0] : 5
            element - [0],[1] : 6
            element - [1],[0] : 7
            element - [1],[1] : 8
 
            Expected Output:
            The First matrix is:
            1 2
            3 4

            The Second matrix is :
            5 6
            7 8

            The Addition of two matrix is :
            6 8
            10 12
            */

            Console.WriteLine("I can add two Matrices of teh same size.");
            Console.Write("Input the size of the square matrix (less than 5): ");
            int matrixSize = int.Parse(Console.ReadLine());

            // creating Matrices
            int[,] matrix1 = new int[matrixSize, matrixSize];
            int[,] matrix2 = new int[matrixSize, matrixSize];
            int[,] matrixSum = new int[matrixSize, matrixSize];

            //declare variables outside of for loops so it can be used multiple times
            int x, y;

            // matrix 1
            Console.WriteLine("\nInput elements in the first matrix:");
            for (x = 0; x < matrixSize; x++)
            {
                for (y = 0; y < matrixSize; y++)
                {
                    Console.Write($"Element - [{x}],[{y}]: ");
                    matrix1[x, y] = int.Parse(Console.ReadLine());
                }
            }

            // matrix 2
            Console.WriteLine("\nInput elements in the second matrix:");
            for (x = 0; x < matrixSize; x++)
            {
                for (y = 0; y < matrixSize; y++)
                {
                    Console.Write($"Element - [{x}],[{y}]: ");
                    matrix2[x, y] = int.Parse(Console.ReadLine());
                }
            }

            // matrixSum = matrix 1 + matrix 2
            for (x = 0; x < matrixSize; x++)
            {
                for (y = 0; y < matrixSize; y++)
                {
                    matrixSum[x, y] = matrix1[x, y] + matrix2[x, y];
                }
            }

            // printing matrix 1
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nThe First matrix is:");
            for (x = 0; x < matrixSize; x++)
            {
                for (y = 0; y < matrixSize; y++)
                {
                    Console.Write($"{matrix1[x, y]}\t");
                }
                Console.WriteLine();
            }

            // printing matrix 2
            Console.WriteLine("\nThe Second matrix is:");
            for (x = 0; x < matrixSize; x++)
            {
                for (y = 0; y < matrixSize; y++)
                {
                    Console.Write($"{matrix2[x, y]}\t");
                }
                Console.WriteLine();
            }

            // printing matrixSum
            Console.WriteLine("\nThe Addition of two matrix is:");
            for (x = 0; x < matrixSize; x++)
            {
                for (y = 0; y < matrixSize; y++)
                {
                    Console.Write($"{matrixSum[x, y]}\t");
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.White;


            while (true)
            {
                // ask user if they want to try again
                Console.WriteLine("\nWant to try again? (Y / N)");
                char answer = char.Parse(Console.ReadLine().ToUpper());

                // wants to continue
                if (answer == 'Y')
                {
                    goto StartPoint2;
                }

                // does not want to continue
                else if (answer == 'N')
                {
                    break;
                }

                // invaid entry
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEnter valid character");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
            }
            #endregion

            #region Part3

            Transition();
            Part(3);
            StartPoint3:
            /*
            3. Create a console application to overload “+” and “-“ operator for adding the areas 
            of 2 circles and getting their area difference respectively.
            */

            // declaring circles
            Circle c1 = new Circle();
            Circle c2 = new Circle();

            Console.WriteLine("\nI can tell you the sum and difference of the areas of 2 circles!");
            Console.Write("Enter the radius of the first circle: ");
            c1.Radius = int.Parse(Console.ReadLine());

            Console.Write("Enter the radius of the second circle: ");
            c2.Radius = int.Parse(Console.ReadLine());

            // calcualting areas of circles
            c1.CalculateArea();
            c2.CalculateArea();

            Circle c3 = c1 + c2;
            Circle c4 = c1 - c2;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nThe area of the first circle: {c1.Area}");
            Console.WriteLine($"The area of the second circle: {c2.Area}\n");

            Console.WriteLine($"\nAddition: The sum of the areas is {c3.Area} which has the a circle radius of {c3.Radius}.");
            Console.WriteLine($"Subtraction: The difference of the areas is {c4.Area} which has the a circle radius of {c4.Radius}\n");
            Console.ForegroundColor = ConsoleColor.White;

            // Try Again Loop
            while (true)
            {
                // ask user if they want to try again
                Console.WriteLine("\nWant to try again? (Y / N)");
                char answer = char.Parse(Console.ReadLine().ToUpper());

                // wants to continue
                if (answer == 'Y')
                {
                    goto StartPoint3;
                }

                // does not want to continue
                else if (answer == 'N')
                {
                    break;
                }

                // invaid entry
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEnter valid character");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
            }

            #endregion

            #region Part4
            Transition();
            Part(4);
            StartPoint4:
            /*
            4. Write a function that takes 4 numbers as input to calculate the total and average.
            (Make use of params array to pass arguments and out parameters to return both total and average to main method).
            Test Data:
            Enter the First number: 10
            Enter the Second number: 15
            Enter the third number: 20
            Enter the fourth number: 30

            Expected Output:
            The average of 10 , 15 , 20 , 30 is: 18.75
            The total is 75
            */

            Console.WriteLine("\nI can calculate the total and average!");
            Console.Write("Enter the number of integers you would like to add/multiple: ");
            int arraySize = int.Parse(Console.ReadLine());
            int[] array1 = new int[arraySize];

            Console.WriteLine(); // spacer

            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"Number {i+1}: ");
                array1[i] = int.Parse(Console.ReadLine()) ;
            }

            // Convert the array to a string with the desired format
            string arrayString = string.Join(", ", array1);

            Calculations(out double total, out double average, array1, arraySize);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nThe average of [{arrayString}] is: {average}\n" +
                $"The total is {total}.\n");
            Console.ForegroundColor = ConsoleColor.White;

            // Try Again Loop
            while (true)
            {
                // ask user if they want to try again
                Console.WriteLine("\nWant to try again? (Y / N)");
                char answer = char.Parse(Console.ReadLine().ToUpper());

                // wants to continue
                if (answer == 'Y')
                {
                    goto StartPoint4;
                }

                // does not want to continue
                else if (answer == 'N')
                {
                    break;
                }

                // invaid entry
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEnter valid character");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
            }
            #endregion

            #region Part5
            Transition();
            Part(5);
            StartPoint5:

            /*
            5. Create a function that finds the index of a given item in the array

            Examples
            Search([1, 5, 3], 5) ➞ 1
            Search([9, 8, 3], 3) ➞ 2
            Search([1, 2, 3], 4) ➞ -1

            Notes
            If the item is not present, return -1.
                */

            Console.WriteLine("\nEnter an array and the number you are searching for (target number), and I will return the index of the target number");
            Console.Write("Please enter an array of integers separated by commas: ");
            string input = Console.ReadLine(); //takes user's array as a temp string

            // puts string into array and converts to int array
            int[] array = input.Split(',').Select(int.Parse).ToArray();

            // target number
            Console.Write("Target Number: ");
            int target = int.Parse(Console.ReadLine());

            // target found
            if (SearchIndex(array, target) != -1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nTarget number: {target} is indexed at {SearchIndex(array, target)}\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else // Target Number not found
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n{SearchIndex(array, target)} | Target number: {target} was not found in the array [{input}].\n");
                Console.ForegroundColor = ConsoleColor.White;
            }

            // Try Again Loop
            while (true)
            {
                // ask user if they want to try again
                Console.WriteLine("\nWant to try again? (Y / N)");
                char answer = char.Parse(Console.ReadLine().ToUpper());

                // wants to continue
                if (answer == 'Y')
                {
                    goto StartPoint5;
                }

                // does not want to continue
                else if (answer == 'N')
                {
                    break;
                }

                // invaid entry
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEnter valid character");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
            }
            #endregion

            ClosingMessage(); Console.ReadKey();

        } 
        

        // Part 4
        static void Calculations(out double total, out double average, int[] array1, int arraySize)
        {
            total = 0;
            average = 0;

            foreach (int num in array1)
            {
                total += num;
            }

            average = total / arraySize;
        }

        // Part 5
        static int SearchIndex(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i; // Return the index if the target is found
                }
            }
            return -1; // Return -1 if the target is not found
        }


    }
}
