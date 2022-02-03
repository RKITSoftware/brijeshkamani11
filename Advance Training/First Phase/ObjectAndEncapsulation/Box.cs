using System;

namespace ObjectAndEncapsulation
{
    class Box
    {
        #region Private Properties

        /// <summary>
        /// stores value of _volume
        /// </summary>
        private Double _volume;

        #endregion Private Properties

        #region Public Properties

        /// <summary>
        /// defines Length Of Box 
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// defines Width Of Box 
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// defines Height Of Box 
        /// </summary>
        public double Height { get; set; }

        #endregion Public Properties

        #region Constructors

        /// <summary>
        /// Default Constructor for Initializing default Values
        /// </summary>
        public Box()
        {

        }

        /// <summary>
        /// Constructor that Accept only one Argument to initialize All Properties
        /// </summary>
        /// <param name="value">
        /// contains value to initialize properties of Class
        /// </param>
        public Box(int value)
        {
            this.Length = this.Height = this.Width = value;
            _volume = CalculateVolume();
        }

        /// <summary>
        /// Constructor that Accept Three Arguments for initializing all Three Properties of Box.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
            this._volume = CalculateVolume();
        }

        #endregion Constructors

        #region Public Methods

        /// <summary>
        /// For Calculating Volume Of Box
        /// </summary>
        /// <returns>
        /// Volume of Box
        /// </returns>
        public double GetVolume()
        {
            return _volume;
        }

        override
        public string ToString()
        {
            return "{ Length: " + Length + ", Width: " + Width + ", Height: " + Height + " }";
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// For Calculate Volume Of Box
        /// </summary>
        /// <returns>
        /// Volume Of Box as Double
        /// </returns>
        private double CalculateVolume()
        {
            return this.Length * this.Width + this.Height;
        }
        #endregion Private Methods

    }

    class BoxDemo
    {
        #region Static mehods

        /// <summary>
        /// Starting point of This Project
        /// </summary>
        /// <param name="args">
        /// list of string that passed during Main calls.
        /// </param>
        static void Main(string[] args)
        {
            // Creating Object Of Class Box With Zero Parameters
            Box objBox = new Box();

            // Display All Data Of Object
            Console.WriteLine(objBox);

            // Creating Object Of Class Box With One Parameters
            objBox = new Box(5);

            // Printing Only Width Of Object
            Console.WriteLine(objBox.Width);

            // Creating Object Of Class Box With Three Parameters
            objBox = new Box(5, 4, 6);

            // Printing Volume Of Object
            Console.WriteLine(objBox.GetVolume());
        }

        #endregion Static mehods
    }
}
