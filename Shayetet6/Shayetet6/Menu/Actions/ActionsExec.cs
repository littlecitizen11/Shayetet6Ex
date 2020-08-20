using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Shayetet6.Menu
{
    public class ActionsExec
    {
        public LauncherHandler Launcher { get; set; }
        public ValidationManager Validate { get; set; }

        public ActionsExec()
        {
            Launcher = new LauncherHandler();
            Validate = new ValidationManager();
        }

        public void AddToLauncher()
        {
            try
            {
                Console.WriteLine("Enter missile Type");
                Launcher.MissilesType();
                string missiletype = Validate.userValidation.StringInput();
                Validate.missileValidation.IsMissileExists(missiletype);
                var factorymissile = (MissileFactory)Activator.CreateInstance(Type.GetType("Shayetet6." + missiletype + "Factory"));
                var createmissile = factorymissile.Create();
                Launcher.Launch.AddToMissile(createmissile);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Caught : {0}", e.Message);
            }
        }
        public void ExitTheProgram()
        {
            Console.WriteLine("GG WP");
            Environment.Exit(0);
        }
        public void LaunchMissile()
        {
            try
            {
                int numofmissiles;
                string missiletype;
                Console.WriteLine("Enter Missile to Launch");
                Launcher.MissilesType();
                missiletype = Validate.userValidation.StringInput();
                if (missiletype != "TotalWar")
                {
                    Validate.missileValidation.IsMissileExists(missiletype);
                    Console.WriteLine("Enter number of missiles");
                    numofmissiles = Validate.userValidation.IntInput();
                }
                else
                {
                    numofmissiles = Launcher.Launch.MissileList.Count;
                }

                Enum.TryParse(missiletype, out Missles missle);

                LaunchByMissileType(missle, numofmissiles);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Caught : {0}", e.Message);
            }
        }
        public void MissilesInLauncher()
        {
            Launcher.NumOfMissiles();
        }
        public void LaunchByMissileType(Missles missiletype, int numofmissiles)
        {
            switch (missiletype)
            {
                case Missles.LongDistance:
                    {
                        Console.WriteLine("Enter distance");
                        int distance = Validate.userValidation.IntInput();
                        Launcher.LaunchLongMissile(missiletype.ToString(), numofmissiles, distance);
                        break;
                    }
                default:
                    Launcher.LaunchMissile(missiletype.ToString(), numofmissiles);
                    break;
            }
        }
        public void DeleteMissile()
        {
            try
            {
                int key;
                Console.WriteLine("Enter number of Missile do you want to delete");
                key = Validate.userValidation.IntInput();
                Launcher.Launch.DeleteMissles(key);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Caught : {0}", e.Message);
            }
        }
    }
}
