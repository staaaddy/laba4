﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args) {
            MainPropMngr mainPropMngr = new MainPropMngr();
            mainPropMngr.Show(7, "safsf", DateTime.Now);
        }
    }
}