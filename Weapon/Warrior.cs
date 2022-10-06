using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    internal class Warrior : Human
    {
        public Warrior() : base("Воин", 100)
        {
        }

        public void Attack(IMeleeWeapon weapon, Human human)
        {
            if (human.hp > 0)
            {
                weapon.Attack();
                human.hp -= weapon.Damage;
                if (human.hp < 0)
                {
                    human.hp = 0;
                }
                Console.WriteLine($"У {human.name} осталось {human.hp} hp!");
            }

            else
            {
                Console.WriteLine("Невозможно атаковать!");
            }
        }

        public void ThrowWeapon(IThrowWeapon weapon, Human human)
        {

            if (human.hp > 0)
            {
                weapon.ThrowWeapon();
                human.hp -= weapon.Damage;
                if (human.hp < 0)
                {
                    human.hp = 0;
                }
                Console.WriteLine($"У {human.name} осталось {human.hp} hp!");
            }

            else
            {
                Console.WriteLine($"Невозможно атаковать! {human.name} мёртв");
            }
        }
    }
}
