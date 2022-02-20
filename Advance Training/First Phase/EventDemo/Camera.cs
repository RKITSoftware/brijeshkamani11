using System;
using System.Drawing;

namespace EventDemo
{
    /// <summary>
    /// A Delegate for Handling OnSaveImage of <see cref="Camera"/> Class.
    /// </summary>
    /// <param name="objCamera"> Contains Object Of <see cref="Camera"/> Class </param>
    /// <param name="objImageArgument"> Contains Argument that passed while Event Occurs </param>
    delegate void OnImageSaveHandler(Camera objCamera, ImageArgument objImageArgument);

    /// <summary>
    /// Ideally There Should Be System Default Camera.
    /// For Demo Purpose Here I Just Created <see cref="Camera"/> Class.
    /// For Implementing Camera Feature Like Capturing and Saving Image.
    /// </summary>
    class Camera
    {
        #region Public Events

        /// <summary>
        /// An Event That Occurs Before Saving Image.
        /// </summary>
        public event OnImageSaveHandler OnImageSave;

        #endregion

        #region Public Methods

        /// <summary>
        /// For Capturing Live Image.
        /// </summary>
        public void CaptureImage()
        {
            // Ideally here should contains code for capturing ObjImage from current system camera.
            // For demo purpose I am just including saved ObjImage from solution path of this project.
            

            // Storing Captured Image into Event Argument.
            ImageArgument imageArgument = new() { ObjImage = Image.FromFile("../../../TestImage.png") };

            // Saving Stored Image.
            _saveImage(imageArgument);
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// For saving captured Image into default path of solution of this project.
        /// </summary>
        /// <param name="objImageArgument"> Store All necessary information related to captured Image. </param>
        private void _saveImage(ImageArgument objImageArgument)
        {
            // Callback to Subscriber Via Event.
            OnImageSave?.Invoke(this, objImageArgument);

            Console.WriteLine("Saving Image into solution Path of this project...");
            objImageArgument.ObjImage.Save("../../../ResultImage.png");
            Console.WriteLine("Image Saved successfully...");

        }

        #endregion
    }
}
