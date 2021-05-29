using System;
using Character;
using GameMode;
using Weapon;

namespace ShootingGameModelSimulation
{
    public class UserInteraction
    {
        private string Mode;
        private string Weapon;

        public void SelectGameMode()
        {
            Console.WriteLine($"Select the mode you'll like to play : \n1. Story \n2. Arena");
            Console.Write($"Enter 1 for Story mode or 2 for Arena : ");
            var gameMode = Console.ReadLine();

            switch (gameMode)
            {
                case "1":
                    var story = new Story();
                    Console.Clear();
                    story.StartMode();
                    this.Mode = "Story";
                break;

                case "2":
                    var arena = new Arena();
                    Console.Clear();
                    arena.StartMode();
                    this.Mode = "Arena";
                break;
            }

            var weapon = SelectWeapon();
            StartGame(weapon);
        }

        private void StartGame(IWeapon weapon)
        {
            var player = new Player(weapon);
            Console.WriteLine($"The game has started in {this.Mode} mode and you are equipped with a {this.Weapon} \n Goodluck!");
        }

        private IWeapon SelectWeapon()
        {
            Console.WriteLine($"Select weapon : \n1. Pistol \n2. SMG \n3. Rocket Launcher");
            Console.Write($"Enter 1 for Pistol, 2 for SMG, or 3 for Rocket Launcher : ");
            var playerWeapon = Console.ReadLine();
            IWeapon weapon = new BareHand();

            switch (playerWeapon)
            {
                case "1":
                    weapon = new Pistol();
                    this.Weapon = typeof(Pistol).ToString().Remove(0,7);
                break;

                case "2":
                    weapon = new SMG();
                    this.Weapon = typeof(SMG).ToString().Remove(0,7);
                break;

                case "3":
                    weapon = new RocketLauncher();
                    this.Weapon = typeof(RocketLauncher).ToString().Remove(0,7);
                break;
            }
            Console.Clear();
            return weapon;
        }
    }
}