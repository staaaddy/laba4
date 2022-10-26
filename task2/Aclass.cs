using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace task2
{
    public class Aclass : Tool 
    {
        public override int UtilityCalculate() {
            return NoTool() + 10;
        }

        public int NoTool() {
            return utility + 10;
        }
    }
}