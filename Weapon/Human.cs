using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    internal class Human : IHuman
    {
        public string Name => throw new NotImplementedException();

        public int Hp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Attack(Weapon weapon, Human human)
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            throw new NotImplementedException();
        }
    }
}
