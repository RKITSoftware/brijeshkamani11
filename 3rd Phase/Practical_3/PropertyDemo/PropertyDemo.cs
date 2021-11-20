using System;

namespace PropertyDemo
{
    class Box
    {
        public float length { get; set; }
        public float height { get; set; }
        public float width { get; set; }

        
        public Box()
        {
            this.length = this.height = this.width = 0;
            
        }
        public Box(float length, float width, float height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
            
        }
        public override string ToString() => $@"
Length:{length} Width:{width} Height:{height}
";
    }


    class PropertyDemo
    {

        static void Main(string[] args)
        {
            Box objBox = new Box(10, 12, 13);
            Console.WriteLine(objBox);

            objBox.height = 10;

            Console.WriteLine("Height: " + objBox.height);
        }
    }
}
