using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args) {
            ApplicationLicense applicationLicense = new ApplicationLicense();
            while (true) {
                Console.Clear();
                Console.WriteLine(applicationLicense.Status);
                Console.WriteLine("Введіть ключ доступу - [trial/pro] ********");

                string[] msg = Console.ReadLine().Split(" ");
                if (msg.Length == 1) {
                    applicationLicense.VerCommon();
                    continue;
                }

                switch (msg[0]) {
                    case "trial":
                    if (!applicationLicense.VerTrial(msg[1]))
                    Console.WriteLine("Помилка");
                    break;
                    case "pro":
                    if (!applicationLicense.VerPro(msg[1]))
                    Console.WriteLine("Помилка");
                    break;

                    default: 
                    applicationLicense.VerCommon();
                    break;
                }
Console.WriteLine("...");
Console.ReadLine();
            }
        }
    }
}