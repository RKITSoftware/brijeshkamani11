using System;

namespace ConstructorDemo
{
    class Box
    {
        static public int dimention;
        public float length { get; set; }
        public float height { get; set; }
        public float width { get; set; }

        //static Constructor for static members
        static Box()
        {
            dimention = 3;
            Console.WriteLine("Static Constructor called...");
        }

        // parameterless constructor
        public Box()
        {
            this.length = this.height = this.width = 0;
            Console.WriteLine("parameterless constructor called...");
        }

        // parameterized constructor 
        public Box(float value)
        {
            this.length = this.height = this.width = value;
            Console.WriteLine("parameterized constructor called...");
        }

        public Box(float length, float width, float height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
            Console.WriteLine("parameterized constructor called...");
        }

        // copy Constructor 
        public Box(Box box)
        {
            this.length = box.length;
            this.width = box.width;
            this.height = box.height;
            Console.WriteLine("copy Constructor  called...");
        }

        public override string ToString() => $@"
Length:{length} Width:{width} Height:{height}
";
    }
    class ConstructorDemo
    {
        static void Main(string[] args)
        {
            Box objBox = new Box();
            Console.WriteLine(Box.dimention);
            Console.WriteLine(objBox);

            objBox = new Box(10);
            Console.WriteLine(objBox);


            objBox = new Box(10,12,13);
            Console.WriteLine(objBox);


            objBox = new Box(objBox);
            Console.WriteLine(objBox);


           

        }
    }
}
