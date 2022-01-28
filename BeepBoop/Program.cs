using System;
using System.Threading;

namespace BeepBoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Randomizer randomizer = new Randomizer();

            WindowManager.hideWindow();

            while (true)
            {

                int amountOfBeeps = randomizer.GetAmountOfBeeps();
                
                for (int i = 0; i < amountOfBeeps; i++)
                {
                    AudioManager.SetMasterVolume(randomizer.GetRandomVolume());
                    Console.Beep();
                }
                
                Thread.Sleep(randomizer.GetBeepTimeout());

            }
        }
    }
}