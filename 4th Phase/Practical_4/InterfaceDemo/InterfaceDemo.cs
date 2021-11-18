using System;

namespace InterfaceDemo
{
    interface IVehicle
    {
        void Start();
    }
    interface IBike : IVehicle
    {
        
        void Stop();
        void GearChange(int vaule);
    }

    class InterfaceDemo : IBike
    {
        int CurrentGear =0;
        public void Start()
        {
            Console.WriteLine("Bike Starts...");
        }
        public void Stop()
        {
            Console.WriteLine("Bike Stops");
        }
        public void GearChange(int value)
        {
            CurrentGear += value;
        }
        static void Main(string[] args)
        {
            InterfaceDemo objDemo = new InterfaceDemo();
            objDemo.Start();
            objDemo.GearChange(1);
            Console.WriteLine(objDemo.CurrentGear);
            objDemo.Stop();

        }
    }
}
