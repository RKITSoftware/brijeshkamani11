using System;

namespace ClassTypesDemo
{
    partial class PartialBox
    {
        // Rest of parts of PartialBox covers here...
        public PartialBox(float length, float width, float height)
        {
            this.length = length;
            this.width = width;
            this.height = height;

        }

        // copy Constructor 
        public PartialBox(PartialBox box)
        {
            this.length = box.length;
            this.width = box.width;
            this.height = box.height;

        }
        public override string ToString() => $@"
Length:{length} Width:{width} Height:{height}
";
    }
}

