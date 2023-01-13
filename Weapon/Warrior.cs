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

        public void AttackHuman(IMeleeWeapon weapon, Human human)
        {
            if (this.hp > 0)
            {
                if (human.hp > 0)
                {
                    Thread.Sleep(1500);
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
                    Console.WriteLine($"Невозможно атаковать! Враг мёртв!");
                }

            }

            else
            {
                Console.WriteLine($"Невозможно атаковать! Вы  мертвы!");
            }
        }

        public void ThrowWeaponInHuman(IThrowWeapon weapon, Human human)
        {
            if (this.hp > 0)
            {
                if (human.hp > 0)
                {
                    //Thread.Sleep(1500);
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
                    Console.WriteLine($"Невозможно атаковать! Враг мёртв!");
                }
            }

            else
            {
                Console.WriteLine($"Невозможно атаковать! Вы  мертвы!");
            }
        }
    }
}
