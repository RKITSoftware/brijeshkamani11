using System;
using System.Drawing;

namespace EventDemo
{
    class FaceRecognition
    {
        #region Private Members
        private Rectangle _objRactangle;
        #endregion

        #region Public Methods
        /// <summary>
        /// For Testing Captured Image to Identify Face.
        /// </summary>
        /// <param name="objCamera"> Object of System Default <see cref="Camera"/> Class. </param>
        public void TestImage(Camera objCamera)
        {
            // Adding Method to OnIage Save Event.
            objCamera.OnImageSave += ObjCamera_OnImageSave;

            Console.WriteLine("Capturing Live Image...");
            objCamera.CaptureImage();

        }
        #endregion

        #region Protected Method
        protected void ObjCamera_OnImageSave(Camera objCamera, ImageArgument objImageArgument)
        {
            if (objImageArgument.ObjImage is not null)
            {
                // Creating Object Of Graphics Class For Drawing Rectangle On Face
                using (Graphics objGraphics = Graphics.FromImage(objImageArgument.ObjImage))
                {
                    // Creating Object of Pen Class With Red Color  for Drawing Rectangle On Face
                    using (Pen objPen = new(Color.FromArgb(255, 0, 0)))
                    {
                        Console.WriteLine("Identifying Face From Captured Image...");
                        
                        // Testing if Face Found or Not.
                        if (_isFaceFound(objImageArgument.ObjImage))
                        {
                            Console.WriteLine("Drawing Rectangle On Found Face...");
                            objGraphics.DrawRectangle(objPen, _objRactangle);
                        }
                        else
                        {
                            Console.WriteLine("Face not Found...");
                        }

                    }
                }

            }
        }
        #endregion

        #region Private Methods
        private bool _isFaceFound(Image image)
        {
            // Ideally here ObjImage should passed to trained Model.
            // For Demo purpose I just Created Rectangle that Fit to face of TestImage.
            _objRactangle.X = 100;
            _objRactangle.Y = 7;
            _objRactangle.Width = 90;
            _objRactangle.Height = 115;

            // This not should be always true.
            return true;

        }

        #endregion
    }
}
