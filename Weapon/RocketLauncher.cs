namespace Weapon
{
    public class RocketLauncher : IWeapon
    {
        private int DealDamage()
        {
            return -50;
        }

        public void Reload()
        {
            throw new System.NotImplementedException();
        }

        public Bullet Shoot()
        {
            throw new System.NotImplementedException();
        }

        public void Upgarde()
        {
            throw new System.NotImplementedException();
        }
    }
}