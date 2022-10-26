using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace task2
{
    public class Bclass : Tool
    {
        protected int chance = 50;
    Random random = new Random();

    public override int UtilityCalculate() {
        if (IsDo()) {
            return TryTo();
        }
        return 0;
    }

    public int TryTo() {
        return utility + 20;
    }

    public bool IsDo() {
        return random.Next(0, 101) <= chance ? true : false;
    }
    }
}