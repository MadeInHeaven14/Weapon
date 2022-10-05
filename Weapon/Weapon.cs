using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    abstract internal class Weapon : IWeapon
    {
        public int damage { get; set; }
        public string name { get; set; }
        public double durability { get; set; }
        public int MaxDurability;
        

        public Weapon (int damage, string name, int durability)
        {
            this.damage = damage;
            this.name = name;
            this.durability = durability;
            MaxDurability = durability;
        }

        public int Damage => damage;

        public string Name => name;

        public double Durability => durability;

        public void Show()
        {
            Console.WriteLine($"Weapon - {Name} Damage - {Damage}");
        }
    }
}
