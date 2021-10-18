using System;

namespace DateTimeDemo
{
    class DateTimeDemo
    {
        static void Main(string[] args)
        {
            // initializing  object of DateTime
            DateTime objBirthday = new DateTime(2001, 3, 30);

            Console.WriteLine(objBirthday);                                         // 3/30/2001 12:00:00 AM

            //Properties
            Console.WriteLine(DateTime.Now);                                        // Will print current Date and Time
            Console.WriteLine(DateTime.Today);                                      // Will Print Current Date only
            Console.WriteLine(objBirthday.Date);                                    // 3/30/2001 12:00:00 AM
            Console.WriteLine(objBirthday.Year);                                    // 2001
            Console.WriteLine(objBirthday.Month);                                   // 3
            Console.WriteLine(objBirthday.Day);                                     // 30
            Console.WriteLine(objBirthday.DayOfWeek);                               // Friday
            Console.WriteLine(objBirthday.Hour);                                    // 0

            //Methods
            Console.WriteLine(objBirthday.Add(new TimeSpan(30,0,0,0,0)));           // 4/29/2001 12:00:00 AM
            Console.WriteLine(objBirthday.Subtract(new TimeSpan(30,0,0,0,0)));      // 2/28/2001 12:00:00 AM
            Console.WriteLine(objBirthday.AddDays(5));                              // 4/4/2001 12:00:00 AM
            Console.WriteLine(objBirthday.AddYears(20));                            // 3/30/2021 12:00:00 AM
            Console.WriteLine(objBirthday.CompareTo(DateTime.Now));                 // -1, -> -1 if date is lesser, 0 if date is equal and 1 if date is greater

            //Operators
            Console.WriteLine(objBirthday + new TimeSpan(30,0,0,0,0));              // 4/29/2001 12:00:00 AM
            Console.WriteLine(DateTime.Now - objBirthday);                          // 7507.14:22:27.0759242 -> value of returned Timespan
            Console.WriteLine(DateTime.Now == objBirthday);                         // False
            Console.WriteLine(DateTime.Now != objBirthday);                         // True
            Console.WriteLine(DateTime.Now > objBirthday);                          // True
            Console.WriteLine(DateTime.Now < objBirthday);                          // False
            Console.WriteLine(DateTime.Now >= objBirthday);                         // True
            Console.WriteLine(DateTime.Now <= objBirthday);                         // False



        }
    }
}
