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

        public override void Shoot()
        {
            var bullet = _weapon.Shoot();
            
        }

        public override void Run()
        {
            this.speed = 12;
        }

        public override void Walk()
        {
            this.speed = 20; 
        }
    }
}