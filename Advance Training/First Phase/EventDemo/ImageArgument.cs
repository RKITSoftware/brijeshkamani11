using System;
using System.Drawing;

namespace EventDemo
{
    /// <summary>
    /// This class Help To store Image Arguments temporary in Memory.
    /// </summary>
    class ImageArgument : EventArgs
    {
        #region Public Fields
        /// <summary>
        /// Store Object of <see cref="Image"/> Class.
        /// </summary>
        public Image ObjImage { get; set; }
        #endregion

    }
}
