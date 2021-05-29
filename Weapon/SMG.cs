using System;

namespace Weapon
{
    public class SMG : IWeapon
    {
        private int ammo;
        private int bulletDamage;
        private int firePowerMaxDistance;
        public SMG()
        {
            this.ammo = 90;
            this.bulletDamage = -20;
            this.firePowerMaxDistance = 10;
        }

        public void Reload()
        {
            this.ammo = 90;
        }

        public Bullet Shoot()
        {
            this.ammo-=5;
            var bullet = new Bullet(bulletDamage, firePowerMaxDistance);
            return bullet;
        }

        public void Upgarde()
        {
            Console.WriteLine("That's going to cost you some credits");
        }
    }
}