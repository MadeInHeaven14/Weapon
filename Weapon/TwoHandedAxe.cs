using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    internal class TwoHandedAxe : IMeleeWeapon, IRepairableWeapon, IUpgradeableWeapon
    {
        public int Damage { get; set; }
        public string Name { get; set; }
        public double Durability { get; set; }
        public double MaxDurability { get; set; }
        public int Lvl { get; set; }

        public TwoHandedAxe()
        {
            Damage = 55;
            Name = "Двуручный топор";
            Durability = 5;
            MaxDurability = 5;
            Lvl = 1;
        }


        public void Attack()
        {
            if (this.Durability > 0)
            {
                this.Durability -= 1;
                if (this.Durability < 0)
                {
                    this.Durability = 0;
                }
                Console.WriteLine($"Атакую оружием {this.Name}! Осталось {this.Durability} прочности!");
            }

            else
            {
                Console.WriteLine("Невозможно атаковать! Предмет сломан!");
            }
        }

        public void Show()
        {
            Console.WriteLine($"Weapon - {Name} Damage - {Damage} Durability - {Durability} Lvl - {Lvl}");
        }
    }
}
