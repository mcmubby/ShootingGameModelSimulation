using System;
using Weapon;

namespace Character
{
    public class Player : GameCharacter
    {
        private readonly IWeapon _weapon;
        private new int speed;
        private int position;

        public Player(IWeapon weapon)
        {
            _weapon = weapon;
            this.speed = 5;
            this.position = 0;
        }

        public override Bullet Shoot()
        {
            var bullet = _weapon.Shoot();
            Console.WriteLine("Shot fired!");
            return bullet;
        }

        public override void Run()
        {
            this.speed = 15;
            this.position+=this.speed;
            Console.WriteLine($"You have taken {this.speed} steps. Your current position is {this.position}");
        }

        public override void Walk()
        {
            this.speed = 5; 
            this.position+=this.speed;
            Console.WriteLine($"You have taken {this.speed} steps. Your current position is {this.position}");
        }
    }
}