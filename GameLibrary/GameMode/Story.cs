using System;

namespace GameMode
{
    public class Story : IGameMode
    {
        public void StartMode()
        {
            Console.WriteLine("Story mode selected");
        }
    }
}