using System;

namespace MethodDemo
{
    class MethodDemo
    {
        // Method Declaration & Definition
        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");

        }

        // Value Type Arguments
        static int IncrementAmountValueType(int amount)
        {
            amount += 1000;
            return amount;
        }




        // Reference Type Arguments
        static int IncrementAmountReferenceType(ref int amount)
        {
            amount += 1000;
            return amount;
        }



        // Optional Type Arguments
        static int AddAmount(int amount, int increment = 0)
        {
            amount += increment;
            return amount;
        }


        static void Main(string[] args)
        {
            // Method Calling
            PrintHelloWorld();


            int amount = 25000;


            //Value Type Argument Demo
            Console.WriteLine(IncrementAmountValueType(amount));        // 26000
            Console.WriteLine(amount);                                  // 25000 value of amount not changed


            // Refinance Type Argument Demo
            Console.WriteLine(IncrementAmountReferenceType(ref amount)); // 26000
            Console.WriteLine(amount);                                   // 26000 value of amount has been changed also


            // Optional Type Argument Demo
            Console.WriteLine(AddAmount(amount, 1000));                 // 27000
            Console.WriteLine(AddAmount(amount));                       // 26000 default value of increment is 0


        }
    }
}
