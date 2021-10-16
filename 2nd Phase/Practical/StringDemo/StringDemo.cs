using System;

namespace StringDemo
{
    class StringDemo
    {
        static void Main(string[] args)
        {
            // string initialization with value HelloWorld!
            string myString = "HelloWorld!";
            Console.WriteLine(myString);


            //String methods

            //Clone()
            string anotherString = myString.Clone().ToString();         // return same instance of String
            Console.WriteLine(anotherString);                           // HelloWorld!

            //Compare()
            Console.WriteLine(myString.CompareTo(anotherString));       // return 0 if equal , 1 if greater , or -1 if lesser

            //Concat()
            Console.WriteLine(String.Concat(myString, anotherString));   //  HelloWorld!HelloWorld!

            //ToLower()
            // convert to Lowercase
            Console.WriteLine(myString.ToLower()); // helloworld!



        }
    }
}
