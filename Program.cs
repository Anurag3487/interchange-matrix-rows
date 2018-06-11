using System;

namespace Matrix_Interchange_Any_Two_Rows
{
    class Program
    {
        static void Main(string[] args)
        {
            InterchangeAnyTwoRowsOfMatrix();
        }

        private static void InterchangeAnyTwoRowsOfMatrix()
        {
            Console.WriteLine("Please enter the number of rows and columns for the matrix:");

            var numberOfRows = int.Parse(Console.ReadLine());
            var numberOfColumns = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter the matrix:");
            int[,] matrix = new int[numberOfRows, numberOfColumns];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("The entered matrix is as follows:");
            DisplayTheMatrix(matrix);

            Console.WriteLine("\nEnter the indeces of the rows which you want to interchange:");

            var index1 = int.Parse(Console.ReadLine());
            var index2 = int.Parse(Console.ReadLine());

            int[,] array1 = new int[1, matrix.GetLength(1)];
            int[,] array2 = new int[1, matrix.GetLength(1)];

            for(int i=0;i<matrix.GetLength(1);i++)
            {
                array1[0, i] = matrix[index1, i];
                array2[0, i] = matrix[index2, i];

                matrix[index1, i] = array2[0, i];
                matrix[index2, i] = array1[0, i];
            }
            
            Console.WriteLine("\nArray1:");
            DisplayTheMatrix(array1);

            Console.WriteLine("\nArray2:");
            DisplayTheMatrix(array2);

            Console.WriteLine("\nThe interchanged matrix is as follows:");
            DisplayTheMatrix(matrix);

            Console.ReadLine();
        }

        private static void DisplayTheMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
