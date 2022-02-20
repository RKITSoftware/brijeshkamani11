using System;
using System.Collections.Generic;

namespace SingleDelegateDemo
{
    /// <summary>
    /// A Delegate That will help to filter values from Integer Type List.
    /// </summary>
    /// <param name="item"> An Integer Element From List. </param>
    /// <returns> Boolean value that indicates whether an item satisfies the condition or not. </returns>
    public delegate bool FilterOnListDelegate(int item);

    /// <summary>
    /// Class Contains Main Method
    /// </summary>
    internal class Program
    {
        #region Private Static Methods

        /// <summary>
        /// An Entry Point of This Program.
        /// </summary>
        /// <param name="args"> Contains list of commands which passed during execution of this program. </param>
        private static void Main(string[] args)
        {
            // Temporary List for Demonstration.
            List<int> list = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Filtering all Even Values From list using Delegate and Anonymous Function.
            var resultList = list.Filter((item) => item % 2 == 0);
            Console.WriteLine("All Even Values on List are {0}.", string.Join(", ", resultList));   // 2, 4, 6, 8, 10

            // Filtering all Odd Values From list using Delegate and User Define Function.
            resultList = list.Filter(IsOdd);
            Console.WriteLine("All Odd Values on List are {0}.", string.Join(", ", resultList));    // 1, 3, 5, 7, 9

            // Filtering all Values which are Greater Than 5 From list using Delegate and User Define Function.
            resultList = list.Filter(GreaterThanFive);
            Console.WriteLine("All values greater than 5 in List are {0}.", string.Join(", ", resultList)); // 6, 7, 8, 9, 10

            // Filtering all Values which Divides by 3 From list using Delegate.
            FilterOnListDelegate filterOnList = DivideByThree;
            resultList = list.Filter(filterOnList);
            Console.WriteLine("All values which divides by 3 in List are {0}.", string.Join(", ", resultList)); // 3, 6, 9
        }

        /// <summary>
        /// Static Function to determine whether number is Odd or not.
        /// </summary>
        /// <param name="item"> contains any integer value </param>
        /// <returns> Boolean value that indicates Number is Odd or Not. </returns>
        private static bool IsOdd(int item)
        {
            return item % 2 != 0;
        }

        /// <summary>
        /// Static Function to determine whether number is greater than 5 or not.
        /// </summary>
        /// <param name="item"> contains any integer value </param>
        /// <returns> Boolean value that indicates Number is greater than 5 or not.  </returns>
        private static bool GreaterThanFive(int item)
        {
            return item > 5;
        }

        /// <summary>
        /// Static Function to Determine whether number is divisible by 3 or not.
        /// </summary>
        /// <param name="item"> contains any integer value </param>
        /// <returns> Boolean value that indicates Number is divisible by 3 or not. </returns>
        private static bool DivideByThree(int item)
        {
            return item % 3 == 0;
        }


        #endregion
    }
}
