﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FigureSample;
using KG02_inheritance;

namespace OOP2020
{
    class Program
    {
        static void Main()
        {

            ICloneable ic = "Thomas";
            IEnumerable<char> chars = "Thomas";
            //new Demo().Run();
            CircleProgram cp = new CircleProgram();
            cp.Run();
        }
    }
}
