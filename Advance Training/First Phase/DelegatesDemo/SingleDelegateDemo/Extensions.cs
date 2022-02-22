using System.Collections.Generic;


namespace SingleDelegateDemo
{
    /// <summary>
    /// A Class Contains All Extension methods For Entire Project.
    /// </summary>
    internal static class Extensions
    {
        #region Public Static Methods

        /// <summary>
        /// An Extension Method for List class to filter some values from List According to specified condition.
        /// </summary>
        /// <param name="list"> Current Object of List. </param>
        /// <param name="callbackFilterOnListDelegate"> A delegate that accepts FilterOnListDelegate Type Method. </param>
        /// <returns> A new List With all Filtered Items. </returns>
        public static List<int> Filter(this List<int> list, FilterOnListDelegate callbackFilterOnListDelegate)
        {
            List<int> resultList = new List<int>();
            
            foreach (int item in list)
            {
                // Passed callback Function will Called Here.
                if (callbackFilterOnListDelegate(item))
                {
                    resultList.Add(item);
                }
            }
            return resultList;
        }
        #endregion
    }
}
