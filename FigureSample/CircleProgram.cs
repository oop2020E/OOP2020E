using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace FigureSample
{
    public class CircleProgram
    {
        public void Run()
        {
            //TODO 100 CircleProgram overview

            Canvas c = new ConsoleCanvas("My circle-program");

            Canvas[] vc = new Canvas[10];
            vc[0] = new BitmapCanvas();
            vc[1] = new ConsoleCanvas("");
            foreach (Canvas item in vc)
            {


            }

            


            c.Clear();
            Line l = new Line(0, 0, 10, 10, 1);
            LineDrawer ld = new LineDrawer(c);
            BoxDrawer bd = new BoxDrawer(c);

            Box b = new Box(15, 4, 5, 5);
            bd.Draw(b);
            ld.DrawLine(l);
            Console.ReadKey();
        }


    }
}