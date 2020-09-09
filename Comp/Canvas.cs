using System;

namespace Comp
{
    class Canvas
    {
        //TODO 10 Create Constructor
        //TODO 20 Customize draw-character

        public Canvas(string headline)
        {
            this.Headline = headline;
            Console.WindowHeight = 60;
            Console.WindowWidth = 140;
        }

        public string Headline { get; set; }

        public void PutPixel(int x, int y)
        {
            if (x >= 0 && y >= 0 && x < Console.WindowWidth && y + 1 < Console.WindowHeight)
            {
                int left = Console.CursorLeft;
                int top = Console.CursorTop;
                Console.SetCursorPosition(x, (Console.WindowHeight - 1) - y);
                Console.Write("x");
                Console.SetCursorPosition(left, top);
            }
        }

        //TODO 30 Create clear method
        public void Clear()
        {
            Console.Clear();
            Console.WriteLine("My circle program!");
        }
    }
}