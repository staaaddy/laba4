using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args) {
        Vegatable vegatable = new Vegatable();
        Fruit fruit = new Fruit();
        Meat meat = new Meat();
        vegatable.ShowProp();
        fruit.ShowProp();
        meat.ShowProp();
    }
}
}