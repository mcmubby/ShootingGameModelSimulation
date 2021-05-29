using System;

namespace Weapon
{
    internal class BareHand : IWeapon
    {
        public void Reload()
        {
            Console.WriteLine("You've got enough hands");
        }

        public Bullet Shoot()
        {
            Console.WriteLine("throw some punches will you");
            return new Bullet(5,1);
        }

        public void Upgarde()
        {
            Console.WriteLine("You'll have to hit the Gym for that.");
        }
    }
}