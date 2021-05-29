using Weapon;

namespace Character
{
    public class Zombie : GameCharacter
    {
        private readonly IWeapon _weapon;
        private new int speed;

        public Zombie()
        {
            _weapon = new BareHand();
            this.speed = 3;
        }

        public override void Shoot()
        {
            var bullet = _weapon.Shoot();
            
        }

        public override void Run()
        {
            this.speed = 3;
        }

        public override void Walk()
        {
            this.speed = 6; 
        }
    }
}