using System;
using System.Collections.Generic;

namespace GenericCollectionDemo
{
    class GenericCollectionDemo
    {
        static void Main(string[] args)
        {
            // List Demo
            // create list strings of 5 elements
            List<string> authors = new List<string>(5);

            // initialize with 2 elements
            authors.Add("Author 1");
            authors.Add("Author 2");

            // print element of list
            foreach (string a in authors)
                Console.WriteLine(a);

            // insert new member in list at specific position
            authors.Insert(1, "Author 3");
            // print element of list
            foreach (string a in authors)
                Console.WriteLine(a);

            // insert array of string  
            string[] newAuthors = { "Author 4", "Author 5" };
            // Insert array at position 2  
            authors.InsertRange(1, newAuthors);
            // print element of list
            foreach (string a in authors)
                Console.WriteLine(a);

            // finding specific elements of list
            int idx = authors.IndexOf("Author 1");
            if (idx > 0)
                Console.WriteLine($"Item index in List is: {idx}");
            else
                Console.WriteLine("Item not found");

            // sort elements
            authors.Sort();
            // print element of list
            foreach (string a in authors)
                Console.WriteLine(a);

            // search an elements
            int bs = authors.BinarySearch("Author 2");
            if (bs > 0)
                Console.WriteLine($"Item index in List is: {bs}");
            else
                Console.WriteLine("Item not found");
            // remove specific element
            authors.Remove("New Author1");
            // print element of list
            foreach (string a in authors)
                Console.WriteLine(a);

            // remove at specific position
            authors.RemoveAt(3);
            // print element of list
            foreach (string a in authors)
                Console.WriteLine(a);

            // remove all elements
            authors.Clear();
            // print element of list
            foreach (string a in authors)
                Console.WriteLine(a);


            


        }
    }
}
