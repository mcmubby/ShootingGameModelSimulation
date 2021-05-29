using Weapon;

namespace Character
{
    public class Player : GameCharacter
    {
        private readonly IWeapon _weapon;
        private new int speed;

        public Player(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public override void Shoot()
        {
            var bullet = _weapon.Shoot();
            
        }

        public override void Run()
        {
            this.speed = 5;
        }

        public override void Walk()
        {
            this.speed = 10; 
        }
    }
}