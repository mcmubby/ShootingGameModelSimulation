using System;

namespace Weapon
{
    public class Pistol : IWeapon
    {
        private int ammo;
        private int bulletDamage;
        private int firePowerMaxDistance;
        public Pistol()
        {
            this.ammo = 13;
            this.bulletDamage = -10;
            this.firePowerMaxDistance = 8;
        }

        public void Reload()
        {
            this.ammo = 13;
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