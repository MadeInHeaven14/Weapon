using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    internal class Dart : Weapon, IWeapon, IThrowWeapon, IRepairableWeapon 
    {
        public Dart() : base(20, "Dart", 1, 1)
        {
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
