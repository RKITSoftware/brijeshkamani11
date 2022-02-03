using System;

namespace AbstractDemo
{
    abstract class AbstractBox
    {
        #region Private Properties
        int _length;
        int _width;
        int _height;
        #endregion Private Properties

        #region Public Methods
        /// <summary>
        /// An Abstract Method
        /// </summary>
        abstract public void DrawBox();

        /// <summary>
        /// Override ToString Method to Display ALL Data.
        /// </summary>
        /// <returns>
        /// String that contains all data of an Object
        /// </returns>
        public override string ToString() => $@"Length:{_length} Width:{_width} Height:{_height}";
        #endregion Public Methods

    }

    class AbstractDemo : AbstractBox
    {
        #region Public Methods

        /// <summary>
        /// Overriding Abstract Method
        /// </summary>
        public override void DrawBox()
        {
            Console.WriteLine("Drawing Box...");
        }
        #endregion Public Methods

        #region Static mehods

        /// <summary>
        /// Starting point of This Project
        /// </summary>
        /// <param name="args">
        /// list of string that passed during Main calls.
        /// </param>
        static void Main(string[] args)
        {
            // We cannot create object of an Abstract class
            //AbstractBox abstractBox = new AbstractBox();
                       
            AbstractDemo objAbstractDemo = new AbstractDemo();
            objAbstractDemo.DrawBox();
        }
        #endregion Static mehods
    }
}
