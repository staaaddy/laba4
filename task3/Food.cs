using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace task3
{
    public class Food
    {
        public int Utility {get; set;}
        public int Calorie {get; set;}

        public virtual void ShowProp() {
            Console.WriteLine(GetType().Name);
             foreach (var propInfo in GetType().GetProperties())
             {
                Console.WriteLine($"{propInfo.PropertyType} {propInfo.Name}");
             }
             Console.WriteLine();
        }
    }
}