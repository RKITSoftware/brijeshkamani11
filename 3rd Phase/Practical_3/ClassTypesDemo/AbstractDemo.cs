using System;

namespace ClassTypesDemo
{
    abstract class AbstractBox
    {
        int length;
        int width;
        int height;

        abstract public void drawBox();

        public override string ToString() => $@"
Length:{length} Width:{width} Height:{height}
";

    }
    class AbstractDemo : AbstractBox
    {
        public override void drawBox()
        {
            Console.WriteLine("Drawing Box...");
        }
        static void Main(string[] args)
        {
            // We cannot create object of an Abstract class
            //AbstractBox abstractBox = new AbstractBox();

            AbstractDemo objDemo = new AbstractDemo();
            objDemo.drawBox();
        }
    }
}
