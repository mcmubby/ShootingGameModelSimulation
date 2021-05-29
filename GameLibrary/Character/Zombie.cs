using System;
using Weapon;

namespace Character
{
    public class Zombie : GameCharacter, IDisposable
    {
        private readonly IWeapon _weapon;
        private new int speed;

        public Zombie()
        {
            _weapon = new BareHand();
            this.speed = 3;
        }

        public override Bullet Shoot()
        {
            var bullet = _weapon.Shoot();
            return bullet;
        }

        public override void Run()
        {
            this.speed = 3;
            Console.WriteLine($"You have taken {this.speed} steps");
        }

        public override void Walk()
        {
            this.speed = 6; 
            Console.WriteLine($"You have taken {this.speed} steps");
        }

        public void Dispose()
        {
            Dispose();
            GC.SuppressFinalize(this);
        }
    }
}