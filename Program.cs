using System;
/*
 * This program allows to create a matrix
 * with the parameters that the user enters 
 * and to modify each of them.
 * 
 * @autor Kemil Beltre
 */

namespace SolutionMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            menuMatrix();
            Console.ReadKey(true);
        }

        private static void indexMatrix(out int sizeRows, out int sizeCol, out int [,] matrix)
        {
            Console.WriteLine("How many rows will the matrix have?");
            sizeRows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many columns will the matrix have?");
            sizeCol = Convert.ToInt32(Console.ReadLine());
            
             matrix = new int[sizeRows,sizeCol];

            for (int indexRows = 0; indexRows < sizeRows; indexRows++)
            {
                for (int indexCol = 0; indexCol < sizeCol; indexCol++)
                {
                    Console.WriteLine("Enter the index data [" + indexRows + "," + indexCol + "]:");
                    matrix[indexRows, indexCol] = Convert.ToInt32(Console.ReadLine());
                }
            }

        }

        private static void menuMatrix() 
        {
            int rowUser, colUser, element, replace, counter, option;
            bool isFound;
            indexMatrix(out int sizeRows, out int sizeCol, out int[,] matrix);

            do
            {
                Console.WriteLine("1. Modify an element by its indices");
                Console.WriteLine("2. Modify an element by its matches");
                Console.WriteLine("3. Show matrix data");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Choose an option");
                option = Convert.ToInt32(Console.ReadLine());
                Console.Clear(); 

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the row index: ");
                        rowUser = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter the column index: ");
                        colUser = Convert.ToInt32(Console.ReadLine());

                        if (rowUser < sizeRows && colUser < sizeCol)
                        {
                            Console.WriteLine("Enter the new index element [" + rowUser + "," + colUser + "]: ");
                            matrix[rowUser, colUser] = Convert.ToInt32(Console.ReadLine()); 
                        }
                        else
                        {
                            Console.WriteLine("Index [" + rowUser + "," + colUser + "] no found.");
                        }

                        break;

                    case 2:
                        counter = 0;
                        isFound = false; 
                        Console.WriteLine("Enter the number to be replaced: ");
                        element = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter replacement number: ");
                        replace = Convert.ToInt32(Console.ReadLine());

                        for (int indexRows = 0; indexRows < sizeRows; indexRows++)
                        {
                            for (int indexCol = 0; indexCol < sizeCol; indexCol++)
                            {
                                if (matrix[indexRows, indexCol] == element)
                                {
                                    isFound = true;
                                    counter++;
                                    matrix[indexRows, indexCol] = replace;
                                }

                            }
                            if (isFound == true)
                            {
                                Console.WriteLine("The following were found: " + counter + " matches: " + element + " and replaced by " + replace);
                            }
                            else
                            {
                                Console.WriteLine("Try again " + element);
                            }
                        }
                        break;

                    case 3:
                        for (int indexRows = 0; indexRows < sizeRows; indexRows++)
                        {
                            for (int indexCol = 0; indexCol < sizeCol; indexCol++)
                            {
                                Console.Write(" " + matrix[indexRows, indexCol]);
                            }
                            Console.WriteLine();
                        }

                        break;
                    case 4:
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        Console.WriteLine("NOT FOUND");
                        break;

                }
            } while (option != 4);

        }



    }
}
