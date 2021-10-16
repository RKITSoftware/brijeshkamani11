using System;

namespace ArrayDemo
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            // One Dimensional Array

            // Array Declaration with no Value
            int[] myArray = new int[5];
            Console.WriteLine(myArray.Length);                          // getting number of elements are in Array
            
            // Allocating values to Elements one by one
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = Convert.ToInt32(Console.ReadLine());       // Accessing Array via Index
            }
            
            //  Traversing Array
            foreach (int element in myArray)
            {
                Console.WriteLine(element);
            }
            
            // Declaring Array With Value
            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine(array.Length);                            // Finding number of elements in Array
            
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }

            
            // Two Dimensional Array
            int[,] array2D = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };   // Declaration and initialization

            //index 0 for number of rows
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                // index 1 for number of Columns
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write(array2D[i, j] + " ");                 // Accessing Array Elements via indexes
                }
                Console.WriteLine();
            }

            
            //Jagged Array
            int[][] jaggedArray = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 4 } };


            // getting all arrays one by one
            foreach(int[] row in jaggedArray)
            {
                // accessing arrays elements individually
                foreach(int element in row)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
