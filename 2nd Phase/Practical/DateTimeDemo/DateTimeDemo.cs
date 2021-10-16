using System;

namespace DateTimeDemo
{
    class DateTimeDemo
    {
        static void Main(string[] args)
        {
            // initializing  object of DateTime
            DateTime birthDate = new DateTime(2001, 3, 30);

            Console.WriteLine(birthDate);           // 3/30/2001 12:00:00 AM


            //Subtract birthdate from current Date
            Console.WriteLine((DateTime.Now.Subtract(birthDate).TotalDays));    // 7504


        }
    }
}
