using System;

namespace EnumDemo
{
    class EnumDemo
    {
        // This how we car create Enum
        enum Days
        {
            // Here Value of Monday will be 1
            MONDAY = 1,             
            TUESDAY,            // 2
            WEDNESDAY,          // 3
            THURSDAY,           // 4
            FRIDAY,             // 5
            SATURDAY,           // 6
            SUNDAY              // 7
        }
        static void Main(string[] args)
        {
            // This is how we can use Enum
            Days day = Days.SUNDAY;
            Console.WriteLine(day);                 // SUNDAY
            Console.WriteLine(Days.MONDAY);         // MONDAY
            Console.WriteLine((Days)3);             // WEDNESDAY
            Console.WriteLine((int)Days.FRIDAY);    // 5
            
        }
    }
}
