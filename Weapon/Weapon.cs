using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    abstract internal class Weapon : IWeapon, IRepairableWeapon
    {
        public int damage { get; set; }
        public string name { get; set; }
        public double durability { get; set; }
        public int lvl { get; set; }
        public int MaxDurability;
        

        public Weapon (int damage, string name, int durability, int LvL)
        {
            this.damage = damage;
            this.name = name;
            this.durability = durability;
            this.lvl = LvL;
            MaxDurability = durability;
        }

        public int Damage => damage;

        public string Name => name;

        public double Durability => durability;

        public int Lvl => lvl;

        public void Show()
        {
            Console.WriteLine($"Weapon - {Name} Damage - {Damage} Lvl - {lvl}");
        }
    }
}
