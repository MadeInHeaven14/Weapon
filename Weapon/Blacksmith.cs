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

        public void Fix(Weapon weapon)
        {
            weapon.durability = weapon.MaxDurability;
            Console.WriteLine($"{weapon.Name} починен!");
        }

        public void Upgrade(Weapon weapon)
        {
            weapon.lvl += 1;
            weapon.damage += 2;
            Console.WriteLine($"Уровень {weapon.Name}а повышен! Теперь у него {weapon.lvl} lvl и {weapon.damage} урона!");
        }
    }
}
