using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    internal class TwoHandedAxe : Weapon, IWeapon, IMeleeWeapon
    {
        public TwoHandedAxe() : base(45, "Two-handed Axe", 5)
        {
        }

        public void Attack()
        {
            if (durability > 0)
            {
                this.durability -= 1;
                if (this.durability < 0)
                {
                    this.durability = 0;
                }
                Console.WriteLine($"Атакую двуручным топором! Осталось {this.durability} прочности!");

            }

            else
            {
                Console.WriteLine("Невозможно атаковать! Почините оружие!");
            }
        }
    }
}
