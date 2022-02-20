using System;

namespace EventDemo
{
    /// <summary>
    /// For Implementing Event Demo
    /// </summary>
    class EventDemo
    {
        #region Static Methods

        /// <summary>
        /// Entry Point of Our Program
        /// </summary>
        /// <param name="args"> Contains list of string passed during execution of Program. </param>
        static void Main(string[] args)
        {

            Console.WriteLine("Adding Default Camera into Program For Capturing Live Image...");

            // Ideally Here Should be System Default Camera For Demo Purpose I just Created Own Camera Class
            Camera objCamera = new Camera();

            // Creating  Object Of Our FaceRecognition Class
            FaceRecognition objFaceRecognition = new FaceRecognition();

            // Passing Object Of Camera Class for Capturing and Testing Image.
            objFaceRecognition.TestImage(objCamera);

        }
        #endregion
    }
}
