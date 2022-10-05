using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    internal interface IThrowWeapon : IWeapon
    {
        public void ThrowWeapon();
    }
}
