using System;

namespace InheritanceDemo
{
    class Vehicle
    {
        #region Public Methods
        /// <summary>
        /// Controls Operation of Vehicle Starts
        /// </summary>
        public void Start()
        {
            Console.WriteLine("Bike Starts...");
        }
        #endregion Public Methods
    }

    class Bike : Vehicle
    {
        #region Public Properties

        /// <summary>
        /// Used to Store Value of CurrentGear
        /// </summary>
        public int CurrentGear;
        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// Controls Operation of Bike Stop
        /// </summary>
        public void Stop()
        {
            Console.WriteLine("Bike Stops");
        }

        /// <summary>
        /// Increase or Decrease Value of Current Gear
        /// </summary>
        /// <param name="value">
        /// Specify How Much Value to Add or Remove
        /// </param>
        public void AddGear(int value)
        {
            CurrentGear += value;
        }

        #endregion Public Methods
    }

    class Inheritance : Bike
    {
        #region Static methods
        
        /// <summary>
        /// Starting point of This Project
        /// </summary>
        /// <param name="args">
        /// list of string that passed during Main calls.
        /// </param>
        static void Main(string[] args)
        {
            // Creating Object of Sub Class
            Inheritance objInheritance = new Inheritance();

            // Access Method of Vehicle Class Using Subclass
            objInheritance.Start();

            // Access Method of Bike Class Using Subclass
            objInheritance.AddGear(1);
            Console.WriteLine(objInheritance.CurrentGear);

            // Calling Stop Method
            objInheritance.Stop();

        }

        #endregion Static methods
    }
}
