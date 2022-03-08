using System;


namespace LambdaDemo
{
    public delegate int CubeDelegate(int x);
    class Program
    {
        static void Main(string[] args)
        {

            // Store lambda in Func Delegate
            // Printing square of int Using Lambda and Func Delegate
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5)); // 25

            // storing lambda in Action Delegate
            // Greeting using Lambda and Action Delegate
            Action<string> greeting = name => Console.WriteLine($"Hello {name}!");
            greeting("World"); // Hello World!

            // storing lambda in simple Delegate
            // Printing cube of int Using Lambda and simple Delegate
            CubeDelegate Cube = (x => x * x * x);
            Console.WriteLine(Cube(10)); // 1000

            // comparing value of two int using Lambda and Func Delegate
            Func<int, int, bool> testForEquality = (x, y) => x == y;
            Console.WriteLine(testForEquality(10, 10)); // True

            // checking that given string is not greater than given int value using Lambda and Func Delegate
            Func<int, string, bool> isTooLong = (int x, string s) => s.Length > x;
            Console.WriteLine(isTooLong(5, "Hello World")); // True

            // doubling value axis using Lambda and Func Delegate
            (int, int, int) axis = (1, 2, 3);
            Func<(int, int, int), (int, int, int)> doubleThem = x => (2 * x.Item1, 2 * x.Item2, 2 * x.Item3);
            Console.WriteLine(doubleThem(axis)); // (2, 4, 6)

            // specifying input type in Lambda
            // parsing value of string into int using lambda and Func Delegate
            Func<string, int> parse = (string s) => int.Parse(s);
            Console.WriteLine(parse("10")); // 10
        }
    }
}
