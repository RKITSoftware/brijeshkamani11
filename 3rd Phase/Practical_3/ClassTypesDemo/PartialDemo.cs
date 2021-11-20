using System;


namespace ClassTypesDemo
{
    partial class  PartialBox
    {
        // this part of class only Contains properties and static constructor
        static public int dimention;
        public float length { get; set; }
        public float height { get; set; }
        public float width { get; set; }

        
        static PartialBox()
        {
            dimention = 3;
            Console.WriteLine("Static Constructor called...");
        }
    }
    class PartialDemo
    {
        public static void main(string[] args)
        {
            PartialBox partialBox = new PartialBox(10,12,23);
            Console.WriteLine(partialBox);
        }
    }
}
