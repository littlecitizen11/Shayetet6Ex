using Shayetet6.Thechnique;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shayetet6
{
    public class Launcher
    {
        public List<BaseMissile> MissileList { get; set; }
        public List<IThechnique> Thechniques { get; set; }
        public Launcher()
        {
            MissileList = new List<BaseMissile>();
            Thechniques = new List<IThechnique>();
            Thechniques = new ThechniqueHandler().Thechniques;
        }
        public bool IsEmpty()
        {
            return MissileList.Count == 0;
        }
        public void PrintTechniques()
        {
            Console.WriteLine("Thechniques Types:");
            foreach (var item in Thechniques)
            {
                Console.Write(item.Name+" -> "); 
            }
            Console.WriteLine("#");
        }

        public void DeleteMissles(int missilespot)
        {

            if (!IsEmpty() && MissileList[missilespot]!=null)
            { Console.WriteLine(MissileList[missilespot].Name + " Missile is deleting.... !"); MissileList.RemoveAt(missilespot);  }
            else
                Console.WriteLine("there are no missiles");
        }

        public void AddToMissile(BaseMissile missiletoadd)
        {
            MissileList.Add(missiletoadd);
        }
    }
}
