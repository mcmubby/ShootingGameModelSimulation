using Weapon;

namespace Character
{
    public abstract class GameCharacter
    {
        public double health;
        public int speed;
        public abstract void Walk();
        public abstract void Run();
        public abstract Bullet Shoot();
    }
}