using System;

namespace LoopDemo
{
    class LoopDemo
    {
        static void Main(string[] args)
        {
            // while 
            // used While loop for reversing number
            int number = 1234;
            int reverse = 0;
            while (number > 0)                                   // block of while executes until number not greater than 0
            {
                reverse = (reverse * 10) + (number % 10);
                number /= 10;
            }
            Console.WriteLine(reverse);                         // 4321

            // do .. while

            number = 1234;
            reverse = 0;

            // Whole block executes at least one time
            do
            {
                reverse = (reverse * 10) + (number % 10);
                number /= 10;
            } while (number > 0);

            Console.WriteLine(reverse);                         // 4321


            int[] myArray = { 1, 2, 3, 4, 5 };
            
            // for loop
            // traversing all elements of array using for loop
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }


            // for-each loop
            foreach (int element in myArray)
            {
                Console.WriteLine(element);
            }


            // break
            // searching element on array using loop and break
            foreach (int element in myArray)
            {
                if(element == 2)
                {
                    Console.WriteLine("Element found");         // element found no need to iterate more
                    break;
                }
            }


            // continue
            // printing only odd numbers of an array
            foreach(int element in myArray)
            {
                if (element % 2 == 0)
                    continue;
                Console.WriteLine(element);                 // this statement will be skip is above condition is true
            }


        }
    }
}
