namespace Weapon
{
    public interface IWeapon
    {
        void Reload();
        void Upgarde();
        Bullet Shoot();
    }
}