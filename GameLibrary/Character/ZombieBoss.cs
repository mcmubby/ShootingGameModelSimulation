using System;
using Weapon;

namespace Character
{
    public class ZombieBoss : GameCharacter
    {
        private readonly IWeapon _weapon;
        private new int speed;

        public ZombieBoss()
        {
            _weapon = new RocketLauncher();
            this.speed = 12;
        }
        public void Fly()
        {
            this.speed = 25;
        }

        public override Bullet Shoot()
        {
            var bullet = _weapon.Shoot();
            return bullet;
        }

        public override void Run()
        {
            this.speed = 20;
            Console.WriteLine($"You have taken {this.speed} steps");
        }

        public override void Walk()
        {
            this.speed = 12; 
            Console.WriteLine($"You have taken {this.speed} steps");
        }
    }
}