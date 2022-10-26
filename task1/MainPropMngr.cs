using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1 {
    public class MainPropMngr : PropManager 
    {
        Random random;
        public MainPropMngr() {
            random = new Random();
        }
        public override void Show(params object[] values) {
            foreach (object obj in values)
            {
                Console.ForegroundColor = (ConsoleColor)random.Next(0, 16);
                Console.WriteLine($"{obj.GetType()} - {obj}");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}