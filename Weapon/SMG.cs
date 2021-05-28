namespace Weapon
{
    public class SMG : IWeapon
    {
        private int ammo;
        private int bulletDamage;
        public SMG()
        {
            this.ammo = 90;
            this.bulletDamage = -20;
        }

        public void Reload()
        {
            this.ammo = 90;
        }

        public Bullet Shoot()
        {
            this.ammo-=5;
            var bullet = new Bullet(bulletDamage);
            return bullet;
        }

        public void Upgarde()
        {
            throw new System.NotImplementedException();
        }
    }
}