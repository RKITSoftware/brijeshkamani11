using System;

namespace EventDemo
{
    // for creating Event First We have to create delegate
    public delegate string EventHandler();

    class Event
    {
        // this is our Event
        event EventHandler OnWelcome;
        string WelcomeGreetings = "Thank you for joining.";

        public Event()
        {
            // After Creating Event We have to Attach Subscriber
            this.OnWelcome += new EventHandler(this.Greetings);
        }

        // This method will invoked after event is raised.
        public string Greetings()
        {
            return WelcomeGreetings;
        }
        static void Main(string[] args)
        {
            Event objEvent = new Event();
            Console.WriteLine(objEvent.OnWelcome());
        }
    }

}

