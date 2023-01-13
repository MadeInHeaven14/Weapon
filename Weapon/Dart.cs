using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    internal class Dart : IWeapon, IThrowWeapon, IRepairableWeapon, IUpgradeableWeapon
    {
        public int Damage { get; set; }
        public string Name { get; set; }
        public double Durability { get; set; }
        public double MaxDurability { get; set; }
        public int count { get; set; }
        public int Lvl { get; set; }


        //public int Damage => damage;

        //public string Name => name;

        //public int Lvl => lvl;
        public Dart()
        {
            Damage = 30;
            Name = "Дротик";
            Durability = 1;
            MaxDurability = 1;
            Lvl = 1;
            count = 10;
        }

        public void Show()
        {
            Console.WriteLine($"Weapon - {Name} Damage - {Damage} Count - {count} Lvl - {Lvl}");
        }

            public void ThrowWeapon()
        {
            if (this.count > 0)
            {
                this.count -= 1;
                Console.WriteLine($"Атакую оружием {this.Name}! Осталось {this.count}!");
            }

            else
            {
                Console.WriteLine($"Невозможно атаковать! {this.Name}и закончились!");
            }
        }
    }
}
