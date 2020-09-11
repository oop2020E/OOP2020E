using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace FigureSample
{
    //TODO 130 introducér Figure
    
    class FOo
    {

    }
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

            List

            lst.Add(new ConsoleCanvas("Console"));
            lst.Add(new BitmapCanvas());

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