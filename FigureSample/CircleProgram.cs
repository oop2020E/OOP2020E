using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace FigureExample
{
    //TODO 130 introducér Figure
    
    public class CircleProgram
    {
        public void Run()
        {
            //TODO 100 CircleProgram overview

            Canvas c = new Canvas("My circle-program");
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