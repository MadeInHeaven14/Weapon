using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    internal interface IRepairableWeapon : IWeapon
    {
        public double Durability { get; set; }
        public double MaxDurability { get; }
    }
}
