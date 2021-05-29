using System;

namespace Weapon
{
    public class RocketLauncher : IWeapon
    {
        private int ammo;
        private int bulletDamage;
        private int firePowerMaxDistance;
        public RocketLauncher()
        {
            this.ammo = 5;
            this.bulletDamage = -200;
            this.firePowerMaxDistance = 100;
        }

        public void Reload()
        {
            this.ammo = 5;
        }

        public Bullet Shoot()
        {
            this.ammo-=1;
            var bullet = new Bullet(bulletDamage, firePowerMaxDistance);
            return bullet;
        }

        public void Upgarde()
        {
            Console.WriteLine("That's going to cost you some credits");
        }
    }
}