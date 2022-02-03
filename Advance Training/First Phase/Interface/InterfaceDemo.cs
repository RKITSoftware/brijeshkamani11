using System;

namespace Interface
{
    interface IVehicle
    {
        
        /// <summary>
        /// Abstract Start Method
        /// </summary>
        void Start();
        
    }

    // implement another Interface
    interface IBike : IVehicle
    {
        /// <summary>
        /// Abstract Stop Method
        /// </summary>
        void Stop();

        /// <summary>
        /// Abstract GearChange Method
        /// </summary>
        /// <param name="value">
        /// Value that used to chage Gear
        /// </param>
        void GearChange(int value);
    }

    class InterfaceDemo : IBike
    {
        #region public properties

        /// <summary>
        /// Stores value of current Gear
        /// </summary>
        int CurrentGear = 0;

        #endregion public properties

        #region public methods
        
        /// <summary>
        /// Implements Start Method of Interface
        /// </summary>
        public void Start()
        {
            Console.WriteLine("Bike Starts...");
        }

        /// <summary>
        /// Implements Stop Method of Interface
        /// </summary>
        public void Stop()
        {
            Console.WriteLine("Bike Stops");
        }

        /// <summary>
        /// Implements GearChange Method of Interface
        /// </summary>
        /// <param name="value">
        /// Value define number of Gears to change
        /// </param>
        public void GearChange(int value)
        {
            CurrentGear += value;
        }

        #endregion public methods
        
        #region Static Mehods

        /// <summary>
        /// Starting point of This Project
        /// </summary>
        /// <param name="args">
        /// list of string that passed during Main calls.
        /// </param>
        static void Main(string[] args)
        {
            InterfaceDemo objInterfaceDemo = new InterfaceDemo();
            objInterfaceDemo.Start();
            objInterfaceDemo.GearChange(1);
            Console.WriteLine(objInterfaceDemo.CurrentGear);
            objInterfaceDemo.Stop();

        }
        #endregion Static Methods
    }
}
