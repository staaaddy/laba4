using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace task2
{
    public abstract class Tool
    {
        protected int utility;
        protected int condition;
        protected int price;

        public virtual int UtilityCalculate() {
            return utility;
        }
        public virtual void Rep() {
            condition += 10;
        }

        public virtual int Sell() {
            return price;
        }

        public virtual void ShowMethods() {
            Console.WriteLine(GetType().Name);
            foreach (var method in GetType().GetMethods()) {
Console.WriteLine(method.Name);
            }
            Console.WriteLine();
        }
    }
}