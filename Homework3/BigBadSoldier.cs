﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class BigBadSoldier : Soldier
    {
        public BigBadSoldier(string name, int age) : base(name, age)
        {
        }

        public new void Shooting(Soldier sodier, int damage)
        {
            base.Shooting(sodier, damage);
            base.Shooting(sodier, damage);
        }
    }
}
