using System;

namespace OperatorsDemo
{
    class OperatorsDemo
    {
        static void Main(string[] args)
        {
            int counter = 10;

            // Unary
            // Increment operator ++
            // Postfix increment operator
            Console.WriteLine(counter);                             // 10 - initial value
            Console.WriteLine(counter++);                           // 10 - postfix increment operator performed
            Console.WriteLine(counter);                             // 11 - After above statement executed

            // Prefix increment operator
            Console.WriteLine(counter);                             // 11 - initial value
            Console.WriteLine(++counter);                           // 12 - prefix increment operator performed
            Console.WriteLine(counter);                             // 12 - After above statement executed

            // Decrement operator --
            // Postfix decrement operator
            Console.WriteLine(counter);                             // 12 - initial value
            Console.WriteLine(counter--);                           // 12 - postfix decrement operator performed
            Console.WriteLine(counter);                             // 11 - After above statement executed

            // Prefix decrement operator
            Console.WriteLine(counter);                             // 11 - initial value
            Console.WriteLine(--counter);                           // 10 - prefix decrement operator performed
            Console.WriteLine(counter);                             // 10 - After above statement executed

            // Binary
            int a = 10;
            int b = 5;



            // Addition operator +
            Console.WriteLine(a + b);                               // 15

            // Subtraction operator -
            Console.WriteLine(a - b);                               // 5

            // Multiplication operator *
            Console.WriteLine(a * b);                               // 50

            // Division operator /
            Console.WriteLine(a / b);                               // 2

            // Remainder operator %
            Console.WriteLine(a % b);                               // 0


            //Boolean operators

            bool True = true;
            bool False = false;

            // Logical negation operator !
            Console.WriteLine(!True);                               // False
            Console.WriteLine(!False);                              // True

            // Logical AND operator &
            Console.WriteLine(True & True);                         // True
            Console.WriteLine(True & False);                        // False
            Console.WriteLine(False & True);                        // False
            Console.WriteLine(False & False);                       // False

            // Logical exclusive OR operator ^
            Console.WriteLine(True ^ True);                         // False
            Console.WriteLine(True ^ False);                        // True
            Console.WriteLine(False ^ True);                        // True
            Console.WriteLine(False ^ False);                       // False

            // Logical OR operator |
            Console.WriteLine(True | True);                         // True
            Console.WriteLine(True | False);                        // True
            Console.WriteLine(False | True);                        // True
            Console.WriteLine(False | False);                       // False

            // Conditional logical AND operator &&
            Console.WriteLine(True && True);                        // True
            Console.WriteLine(True && False);                       // False
            Console.WriteLine(False && True);                       // False
            Console.WriteLine(False && False);                      // False

            // Conditional logical OR operator ||
            Console.WriteLine(True || True);                        // True
            Console.WriteLine(True || False);                       // True
            Console.WriteLine(False || True);                       // True
            Console.WriteLine(False || False);                      // False


            // Bitwise and shift operators
            int number = 8;

            // Left-shift operator <<
            Console.WriteLine(number << 1);                         // 16
            Console.WriteLine(number << 2);                         // 32

            //Right-shift operator >>
            Console.WriteLine(number >> 1);                         // 4
            Console.WriteLine(number >> 2);                         // 2

            // Comparison Operator

            // Less than operator <
            Console.WriteLine(5 < 10);                              // True
            Console.WriteLine(10 < 10);                             // False

            // Greater than operator >
            Console.WriteLine(5 > 10);                              // False
            Console.WriteLine(10 < 10);                             // False

            // Less than or equal operator <=
            Console.WriteLine(5 <= 10);                             // True
            Console.WriteLine(10 <= 10);                            // True

            // Greater than or equal operator >=
            Console.WriteLine(5 >= 10);                             // False
            Console.WriteLine(10 >= 10);                            // True

            // Equality Operator ==
            Console.WriteLine(5 == 10);                             // False
            Console.WriteLine(10 == 10);                            // True

            // Inequality Operator !=
            Console.WriteLine(5 != 10);                             // True
            Console.WriteLine(10 != 10);                            // False


            // Ternary Operator
            Console.WriteLine(counter > 10 ? "Counter is grater than 10" : "Counter is less than or equal to 10 "); // Counter is grater than 10



        }
    }
}
