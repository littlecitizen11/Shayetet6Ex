using MenuBuilder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Shayetet6
{
    public class LauncherHandler
    {
        public Launcher Launch { get; set; }

        public LauncherHandler()
        {
            Launch = new Launcher();
        }
        public bool CheckSuccessProbabilityPercent(int thechniquecalc,int distance)
        {
            return (((thechniquecalc * distance) / 100) >= distance);
        }
        public void NumOfMissiles()
        {
            Console.WriteLine("There are : " + Launch.MissileList.Count + " Missles");
            foreach (var item in Launch.MissileList)
            {
                Console.Write(item.Name+" - > ");
            }
            Console.WriteLine("#");
        }
        public void MissilesType()
        {
            Console.Write("[Types : ");
            foreach (var item in Enum.GetValues(typeof(Missles)))
            {
                Console.Write(item+" ");
            }
            Console.WriteLine("]");
        }
        public void LaunchMissile(string missile,int numofmissiles)
        {
            int count = 0;
            try 
            {
                for (int i = 0; i < numofmissiles; i++)
                {
                    BaseMissile specificMissile = Launch.MissileList.Select(x => x).Where(x => x.IsLaunched == false&&x.Name==missile).First();
                    
                    if (specificMissile.MissileTechnique.IsSucceeded())
                        count++;
                    specificMissile.IsLaunched = true;
                }
            }
            catch(Exception e)
            { Console.WriteLine(e.Message); }
            Console.WriteLine(count+" Missile Launched !");

        }
        public void LaunchLongMissile(string missile, int numofmissiles, int distance)
        {
            int count = 0;
            try
            {
                for (int i = 0; i < numofmissiles; i++)
                {
                    BaseMissile specificMissile = Launch.MissileList.Where(y => y.IsLaunched == false && y.Name == missile).First();

                    if (specificMissile.MissileTechnique.IsSucceeded(distance))
                        count++;
                    specificMissile.IsLaunched = true;
                }
            }
            catch (Exception e)
            { Console.WriteLine(e.Message); }
            Console.WriteLine(count + " Missile Succeeded");

        }
    }
}
