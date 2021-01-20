using System;

namespace Animals
{
    internal class Parrot : Animal
    {
        public Parrot(string name) : base(name)
        {
        }

        public override string Talk(string sentence)
        {
            Random random = new Random();
            int rnd = random.Next(1, 5);

            if (rnd == 1)
            {
                return $"I love Irish coffee!";
            }
            else
            {
                return sentence;
            }
        }

        public override string Pet()
        {
            return "Koko!";
        }
    }
}