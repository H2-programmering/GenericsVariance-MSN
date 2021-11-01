using System;

namespace GenericsVariance.Animals
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override void Action()
        {
            Console.WriteLine("*Cat purrs...");
        }

        public override string Sound()
        {
            return "Meow";
        }
    }
}