//Create a 2D array to store integers and print them in matrix format with proper formatting.
//How many rows? How many columns?

using System.Numerics;

namespace CCAD16_Assignment3_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rows would you like to create?");
            int userRows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many columns would you like to create");
            int userColumns = Convert.ToInt32(Console.ReadLine());

            //edge cases
            if (userRows <= 0 || userColumns <= 0)
            {
                Console.WriteLine("Please enter a number greater than 0");
                return;
            }

            //declare 2D array
            int[,] matrix = new int[userRows, userColumns];

            for (int i = 0; i < userRows; i++)
            {
                for (int j = 0; j < userColumns; j++)
                {
                    Console.WriteLine("Enter a number: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }           

            //print matrix
            Console.WriteLine("2D Array: ");
            for (int i = 0;i < userRows; i++)
            {
                for(int j = 0;j < userColumns; j++)
                {
                    Console.Write($"{matrix[i, j]}");
                    if (j < userColumns - 1)
                    {
                        Console.Write(" | ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
