using System;
using System.Runtime.InteropServices;

namespace FigureSample
{
    //TODO 200 Canvas vil altid tegne i terminalen! -- hvad hvis jeg vil kunne vælge? -- introducer ConsoleCanvas og Canvas
    public class ConsoleCanvas:Canvas
    {
        public ConsoleCanvas(string headline)
        {
            this.Headline = headline;
            //Console.WindowHeight = 60;
            //Console.WindowWidth = 140;
            Console.WindowHeight = 40;
            Console.WindowWidth = 80;
            Maximize();
        }

        public string Headline { get; set; }
        public char Ink { get; set; } = 'x';

        public override void PutPixel(int x, int y)
        {
            if (x >= 0 && y >= 0 && x < Console.WindowWidth && y + 1 < Console.WindowHeight)
            {
                int left = Console.CursorLeft;
                int top = Console.CursorTop;
                Console.SetCursorPosition(x, (Console.WindowHeight - 1) - y);
                Console.Write(Ink);
                Console.SetCursorPosition(left, top);
            }
        }

        public override void Clear()
        {
            Console.Clear();
            Console.WriteLine("My circle program!");
        }


        #region maximize
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int MAXIMIZE = 3;
        static void Maximize()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                ShowWindow(ThisConsole, MAXIMIZE);
            }
        }
        #endregion
    }
}