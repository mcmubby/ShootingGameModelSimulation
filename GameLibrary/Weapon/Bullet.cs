namespace Weapon
{
    public class Bullet
    {
        private int _maxDistance;
        public int _bulletDamage { get; private set; }
        public Bullet(int bulletDamage, int maxDistance)
        {
            _maxDistance = maxDistance;
            _bulletDamage = bulletDamage;
        }
    }
}