using System;

namespace StringDemo
{
    class StringDemo
    {
        static void Main(string[] args)
        {
            // string initialization with value HelloWorld!
            string objMyString = "HelloWorld!";
            Console.WriteLine(objMyString);                                     // HelloWorld!


            //String methods

            // Clone()
            // provide same instance to another variable
            string objAnotherString = objMyString.Clone().ToString();           // return same instance of String
            Console.WriteLine(objAnotherString);                                // HelloWorld!

            // Contains()
            // Check if specified string contains or not
            Console.WriteLine(objMyString.Contains("Hello"));                   // True

            // IndexOf()
            // Finding index of particular string or char
            Console.WriteLine(objMyString.IndexOf("World!"));                   // 5

            // Insert()
            // Insert char or string at specified position
            Console.WriteLine(objMyString.Insert(5," "));                       // Hello World!                      

            // IsNullOrEmpty()
            // Check if specified string is Null or Empty
            Console.WriteLine(String.IsNullOrEmpty(objMyString));               // False

            // PadLeft()
            // Add padding at left side of string
            Console.WriteLine(objAnotherString.PadLeft(15,'-'));                // ----HelloWorld!

            // Remove()
            // Remove specified char or string from string
            Console.WriteLine(objAnotherString.Remove(0,5));                    // World!

            // Replace()
            // Replace old string with new string
            Console.WriteLine(objAnotherString.Replace("World",""));            // Hello!

            // SubString()
            // Substring from specific index
            Console.WriteLine(objAnotherString.Substring(0,2));                 // He

            // Compare()
            // Compare two string
            Console.WriteLine(objMyString.CompareTo(objAnotherString));         // return 0 if equal , 1 if greater , or -1 if lesser

            // Concat()
            // Merge Two String
            Console.WriteLine(String.Concat(objMyString, objAnotherString));    // HelloWorld!HelloWorld!

            // ToLower()
            // Convert to Lowercase
            Console.WriteLine(objMyString.ToLower());                           // helloworld!
            



        }
    }
}
