using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    internal class TwoHandedAxe : Weapon, IWeapon, IMeleeWeapon
    {
        public TwoHandedAxe() : base(45, "Two-handed Axe", 5, 1)
        {
            
        }

        public void Attack()
        {
            if (this.durability > 0)
            {
                this.durability -= 1;
                if (this.durability < 0)
                {
                    this.durability = 0;
                }
                Console.WriteLine($"Атакую оружием {this.Name}! Осталось {this.durability} прочности!");
            }

            else
            {
                Console.WriteLine("Невозможно атаковать! Предмет сломан!");
            }
        }
    }
}
