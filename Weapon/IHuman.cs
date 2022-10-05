using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    internal interface IHuman
    {
        public string Name { get; }
        public int Hp {get; set;}
        public void Attack(Weapon);
        public void Show();

    }
}
