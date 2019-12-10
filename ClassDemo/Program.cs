using System;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Lamp living = new Lamp();
            Lamp bedroom = new Lamp();

            Console.WriteLine($"Living: {living.getState()}");
            Console.WriteLine($"Living Lamp: {living}");

            living.on();
            bedroom.on();

            Console.WriteLine($"Living: {living.getState()}");

            // Print object
            Console.WriteLine($"Living Lamp: {living}");
            Console.WriteLine($"Living Lamp: {living.ToString()}");

            ////// LEDLAMP

            LedLamp wc = new LedLamp();
            wc.on();
            Console.WriteLine($"WC LedLamp: {wc}");
            wc.dim(20);
            Console.WriteLine($"WC LedLamp: {wc}");
            wc.off();
            Console.WriteLine($"WC LedLamp: {wc}");
            wc.on();
            Console.WriteLine($"WC LedLamp: {wc}");
        }
    }
}
