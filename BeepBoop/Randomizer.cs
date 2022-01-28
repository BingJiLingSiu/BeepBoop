using System;

namespace BeepBoop
{
    public class Randomizer
    {
        private Random random = new Random();

        public int GetBeepTimeout()
        {
            return random.Next(0, 60) * 1000;
        }

        public int GetAmountOfBeeps()
        {
            return random.Next(0, 8);
        }

        public float GetRandomVolume()
        {
            return (float) random.Next(0, 100);
        }
    }
}