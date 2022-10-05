using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    internal class OneHandedAxe : Weapon, IWeapon, IMeleeWeapon, IThrowWeapon
    {
        public OneHandedAxe() : base(30, "One-handed Axe", 3)
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
                Console.WriteLine($"Атакую одноручным топором! Осталось {this.durability} прочности!");
            }

            else
            {
                Console.WriteLine("Невозможно атаковать! Почините оружие!");
            }
        }

        public void ThrowWeapon()
        {
            if (durability > 0)
            {
                this.durability -= 0.5;
                if (this.durability < 0)
                {
                    this.durability = 0;
                }
                Console.WriteLine($"Кидаю одноручный топор! Осталось {this.durability} прочности!");
            }

            else
            {
                Console.WriteLine("Невозможно атаковать! Почините оружие!");
            }
        }
    }
}
