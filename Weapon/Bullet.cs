namespace Weapon
{
    public class Bullet
    {
        public int MaxDistance { get; private set; }
        private int _bulletDamage;
        public Bullet(int bulletDamage)
        {
            this.MaxDistance = 5;
            _bulletDamage = bulletDamage;
        }
    }
}