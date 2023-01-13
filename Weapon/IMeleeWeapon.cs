﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    internal interface IMeleeWeapon : IWeapon, IUpgradeableWeapon, IRepairableWeapon
    {
        public void Attack();
    }
}
