using System;
using Weapon;

namespace ShootingGameModelSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var start = new UserInteraction();
            start.SelectGameMode();
        }
    }
}
