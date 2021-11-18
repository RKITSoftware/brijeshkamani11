using System;

namespace InheritanceDemo
{
    class Vehicle
    {
        public void Start()
        {
            Console.WriteLine("Bike Starts...");
        }
    }
    class Bike : Vehicle
    {
        public int CurrentGear = 0;
        public void Stop()
        {
            Console.WriteLine("Bike Stops");
        }
        public void GearChange(int value)
        {
            CurrentGear += value;
        }
    }
    class InheritanceDemo : Bike
    {
        static void Main(string[] args)
        {
            InheritanceDemo objDemo = new InheritanceDemo();
            objDemo.Start();
            objDemo.GearChange(1);
            Console.WriteLine(objDemo.CurrentGear);
            objDemo.Stop();

        }
    }
}
