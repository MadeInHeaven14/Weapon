using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    internal class OneHandedAxe : Weapon, IWeapon, IMeleeWeapon, IThrowWeapon
    {
        public OneHandedAxe() : base(30, "One-handed Axe", 3, 1)
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

        public void ThrowWeapon()
        {
            if (this.durability > 0)
            {
                this.durability -= 0.5;
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
