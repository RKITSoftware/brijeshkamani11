using System;
using System.Collections.Generic;

namespace MultiCastDelegates
{
    /// <summary>
    /// Contains Values For user Choices
    /// </summary>
    enum Choices
    {
        EvenOperation = 1, OddOperation, FindGreaterThanFive, DevidesByThree, RemoveEvenOperation, RemoveOddOperation, RemoveFindGreaterThanFive, RemoveDevidesByThree, RemoveAllOperationsAndContinue, ExitProgram, ShowChoices
    }

    /// <summary>
    /// It will Handle all List Operations
    /// </summary>
    /// <param name="list"> For perform an Operation or it. </param>
    delegate void PerfromListOperationsDelegate(List<int> list);

    /// <summary>
    /// Class Which Contains Main Method of This Application.
    /// </summary>
    internal class Program
    {
        #region Static Methods

        /// <summary>
        /// Entry point of Our Application.
        /// </summary>
        /// <param name="args"> Contains commands passed during execution of the Program. </param>
        static void Main(string[] args)
        {
            // Which will store all users Choices
            // SortedSet will automatically remove Duplicates and sort Elements in Ascending order.
            SortedSet<int> commandSet = new();
            PerfromListOperationsDelegate perfromListOperationsDelegate;
            List<int> list = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // will display all necessary Instruction before user Enters any commands.
            DisplayBeginingInstruction();


            // will go infinite until user wants to exit.
            while (true)
            {
            // for reset purpose
            Begineloop:

                // reset Delegate
                perfromListOperationsDelegate = new PerfromListOperationsDelegate(DisplayDefaultValues);
                try
                {
                    // Asking choice from user and merge choices with old commands.
                    commandSet.UnionWith(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
                }
                // occurs if User Enters command in wrong Formate or wrong data types.
                catch (FormatException fe)
                {
                    Console.WriteLine("Invalid Input. Please Try Again. Error: {0}", fe.Message);
                    Environment.Exit(Environment.ExitCode);
                }

                // copy commandSet into tempSet so we can modify commandSet members within loop.
                SortedSet<int> tempSet = new SortedSet<int>(commandSet);
                foreach (int command in tempSet)
                {
                    // Checking User Choices
                    switch (command)
                    {
                        // 1
                        case (int)Choices.EvenOperation:
                            perfromListOperationsDelegate += FindEven;
                            break;

                        // 2
                        case (int)Choices.OddOperation:
                            perfromListOperationsDelegate += FindOdd;
                            break;


                        // 3
                        case (int)Choices.FindGreaterThanFive:
                            perfromListOperationsDelegate += FindGreaterThanFive;
                            break;

                        // 4
                        case (int)Choices.DevidesByThree:
                            perfromListOperationsDelegate += FindDevidesByThree;
                            break;

                        // 5
                        case (int)Choices.RemoveEvenOperation:
                            if (commandSet.Contains((int)Choices.EvenOperation))
                            {
                                perfromListOperationsDelegate -= FindEven;
                                commandSet.Remove((int)Choices.RemoveEvenOperation);
                                commandSet.Remove((int)Choices.EvenOperation);
                            }
                            break;

                        // 6
                        case (int)Choices.RemoveOddOperation:
                            if (commandSet.Contains((int)Choices.OddOperation))
                            {
                                perfromListOperationsDelegate -= FindOdd;
                                commandSet.Remove((int)Choices.OddOperation);
                                commandSet.Remove((int)Choices.RemoveOddOperation);
                            }
                            break;

                        // 7
                        case (int)Choices.RemoveFindGreaterThanFive:
                            if (commandSet.Contains((int)Choices.FindGreaterThanFive))
                            {
                                perfromListOperationsDelegate -= FindGreaterThanFive;
                                commandSet.Remove((int)Choices.RemoveFindGreaterThanFive);
                                commandSet.Remove((int)Choices.FindGreaterThanFive);
                            }
                            break;

                        // 8
                        case (int)Choices.RemoveDevidesByThree:
                            if (commandSet.Contains((int)Choices.DevidesByThree))
                            {
                                perfromListOperationsDelegate -= FindDevidesByThree;
                                commandSet.Remove((int)Choices.RemoveDevidesByThree);
                                commandSet.Remove((int)Choices.DevidesByThree);
                            }
                            break;

                        // 9
                        case (int)Choices.RemoveAllOperationsAndContinue:
                            commandSet.Clear();
                            Console.WriteLine("\nEnter New Commands");
                            // starts from Beginning of the main loop.
                            goto Begineloop;

                        // 10
                        case (int)Choices.ExitProgram:
                            Environment.Exit(Environment.ExitCode);
                            break;

                        // 11
                        case (int)Choices.ShowChoices:
                            DisplayBeginingInstruction();
                            break;

                        default:
                            Console.WriteLine("\nInvalid Command Please Try Again:");
                            Environment.Exit(Environment.ExitCode);
                            break;
                    }
                }

                // will call all the functions users wants.
                perfromListOperationsDelegate(list);

                Console.WriteLine("\nWant to Add More Commands? Enter below");
            }

        }

        /// <summary>
        /// will display all necessary Instruction before user Enters any commands.
        /// </summary>
        private static void DisplayBeginingInstruction()
        {
            Console.WriteLine("What operations do you want to perform in the list...");
            Console.WriteLine("Write space separated commands in ascending order below...");
            Console.WriteLine("1. For Finding all Even numbers From The List.");
            Console.WriteLine("2. For Finding all Odd numbers From The List.");
            Console.WriteLine("3. For Finding values greater than 5 in List.");
            Console.WriteLine("4. For finding values which divides by 3 in List.");
            Console.WriteLine("5. For Remove Even Operation. ");
            Console.WriteLine("6. For Remove Odd Operation. ");
            Console.WriteLine("7. For Remove Greater Than 5 Operation. ");
            Console.WriteLine("8. For Remove Divide By three Operation. ");
            Console.WriteLine("9. For Remove All Operations & Enter New Command");
            Console.WriteLine("10. For Exit Program.");
            Console.WriteLine("11. Show Choices Again.");
        }

        /// <summary>
        /// Will Display Default value of List.
        /// </summary>
        /// <param name="list"> List object Which values going to be display. </param>
        private static void DisplayDefaultValues(List<int> list)
        {
            Console.WriteLine("Default Values in List is : {0}", string.Join(", ", list));
        }

        /// <summary>
        /// Will Display Default value of List which Divides by 3.
        /// </summary>
        /// <param name="list"> List object Which values going to be display. </param>
        private static void FindDevidesByThree(List<int> list)
        {
            Console.WriteLine("All values which divides by 3 in List are {0}.", string.Join(", ", list.FindAll(x => x % 3 == 0)));
        }

        /// <summary>
        /// Will Display Default value of List which are greater than 5.
        /// </summary>
        /// <param name="list"> List object Which values going to be display. </param>
        private static void FindGreaterThanFive(List<int> list)
        {
            Console.WriteLine("All values greater than 5 in List are {0}.", string.Join(", ", list.FindAll(x => x > 5)));
        }

        /// <summary>
        /// Will Display Default value of List which are odd.
        /// </summary>
        /// <param name="list"> List object Which values going to be display. </param>
        private static void FindOdd(List<int> list)
        {
            Console.WriteLine("All Odd Values on List are {0}.", string.Join(", ", list.FindAll(x => x % 2 != 0)));
        }

        /// <summary>
        /// Will Display Default value of List which even.
        /// </summary>
        /// <param name="list"> List object Which values going to be display. </param>
        private static void FindEven(List<int> list)
        {
            Console.WriteLine("All Even Values on List are {0}.", string.Join(", ", list.FindAll(x => x % 2 == 0)));
        }
    }
    #endregion
}
