using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    internal class BlackSmith : Human
    {
        public BlackSmith() : base("Кузнец", 50)
        {
        }

        public void Fix(IRepairableWeapon weapon)
        {
            weapon.Durability = weapon.MaxDurability;
            Console.WriteLine($"{weapon.Name} починен!");
        }

        public void Upgrade(IUpgradeableWeapon weapon)
        {
            weapon.Lvl += 1;
            weapon.Damage += 2;
            Console.WriteLine($"Уровень {weapon.Name}а повышен! Теперь у него {weapon.Lvl} lvl и {weapon.Damage} урона!");
        }
    }
}
