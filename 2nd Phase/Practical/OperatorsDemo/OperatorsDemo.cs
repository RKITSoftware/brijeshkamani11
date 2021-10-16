using System;

namespace OperatorsDemo
{
    class OperatorsDemo
    {
        static void Main(string[] args)
        {
            int counter = 10;
            
            // Increment operator ++
            // Postfix increment operator
            Console.WriteLine(counter);                             // 10 - initial value
            Console.WriteLine(counter++);                           // 10 - postfix increment operator performed
            Console.WriteLine(counter);                             // 11 - After above statement executed

            // Prefix increment operator
            Console.WriteLine(counter);                             // 11 - initial value
            Console.WriteLine(++counter);                           // 12 - prefix increment operator performed
            Console.WriteLine(counter);                             // 12 - After above statement executed

            // Ternary Operator
            Console.WriteLine(counter > 10 ? "Counter is grater than 10" : "Counter is less than or equal to 10 "); // Counter is grater than 10



        }
    }
}
