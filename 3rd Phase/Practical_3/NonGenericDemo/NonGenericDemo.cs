using System;
using System.Collections;

namespace NonGenericDemo
{
    class NonGenericDemo
    {
        static void Main(string[] args)
        {
            //HashTable
            // declaring
            Hashtable ht = new Hashtable();
            
            // initializing with value
            ht.Add("1","One");

            // printing value
            foreach (DictionaryEntry e in ht)
            {
                Console.WriteLine("{0}, {1}", e.Key, e.Value);
            }

            // checking if its contains key or not
            Console.WriteLine(ht.ContainsKey("1"));
            
            // accessing value using key
            string value = (string)ht["1"];
            Console.WriteLine(value);
        }
    }
}
