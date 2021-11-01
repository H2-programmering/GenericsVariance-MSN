using System;

namespace GenericsVariance.Animals
{
    public class Bird : Animal
    {
        public Bird(string name) : base(name)
        {
        }

        public override void Action()
        {
            Console.WriteLine("*Bird flaps wings...");
        }

        public override string Sound()
        {
            return "Tweet";
        }
    }
}