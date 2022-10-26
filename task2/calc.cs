using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace task2
{
    public class calc : Tool
    {
        public override int UtilityCalculate() {
            return TryTo_();
        }

        public override void Rep() {
            condition += 50;
        }

        public int TryTo_() {
            return utility + 20;
        }
    }
}