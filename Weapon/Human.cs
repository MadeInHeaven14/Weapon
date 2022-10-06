using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Weapon
{
    abstract internal class Human
    {
        public string name { get; set; }
        public int hp { get; set; }
        public Human(string Name, int HP)
        {
            name = Name;
            hp = HP;
        }

        public void Show()
        {
            Console.WriteLine($"Human - {name} hp - {hp}");
        }
    }
}
