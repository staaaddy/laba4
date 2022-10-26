using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace task2
{
    public class Main
    {
        List<Tool> tools;
        public Main(Tool tool1, Tool tool2) : this(tool1, tool2, null) {


        }
        public Main (Tool tool1, Tool tool2, Tool tool3) {
            tools = new List<Tool>();
            tools.Add(tool1);
            tools.Add(tool2);
            if (tool3 != null)
            tools.Add(tool3);
        }
        public void showTree() {
            foreach (Tool tool in tools) {
                tool.ShowMethods();
            }
        }
    }
}