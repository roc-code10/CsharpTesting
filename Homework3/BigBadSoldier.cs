using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class BigBadSoldier : Soldier
    {
        public BigBadSoldier(string name, int age) : base(name, age)
        {
        }

        public new void Shooting(Soldier sodier)
        {
            base.Shooting(sodier);
            base.Shooting(sodier);
        }
    }
}
