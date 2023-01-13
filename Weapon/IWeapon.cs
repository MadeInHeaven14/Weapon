using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    internal interface IWeapon
    {
        public int Damage { get; set;  }
        public string Name { get; }

        public void Show();
    }
}
