using System;
using Character;

namespace GameMode
{
    public class ZombieWave : IGameMode
    {
        public void StartMode()
        {
            StartWave();
        }

        private void StartWave()
        {
            var zombie = new Zombie();
            Console.WriteLine("A zombie is headed your way");
        }

        private void StartZombieBossWave()
        {
            var zombieBoss = new ZombieBoss();
            Console.WriteLine("You have enraged the Zombie Boss, prepare to die");
        }
    }
}