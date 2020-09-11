using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace FigureSample
{
    public abstract class Canvas
    {
        public abstract void PutPixel(int x, int y);
    }

    public class BitmapCanvas : Canvas
    {
        public BitmapCanvas() //:base ("BitmapCanvas")
        {

        }
        public override void PutPixel(int x, int y)
        {
            throw new NotImplementedException();
        }
    }

    //TODO 200 Canvas vil altid tegne i terminalen! -- hvad hvis jeg vil kunne vælge? -- introducer ConsoleCanvas og Canvas
    public class ConsoleCanvas :Canvas
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

        public void PutPixel(int x, int y)
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

        public void Clear()
        {
            Console.Clear();
            Console.WriteLine("My circle program!");
        }
        [DllImport("kernel32.dll", ExactSpelling = true)]

        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int HIDE = 0;
        private const int MAXIMIZE = 3;
        private const int MINIMIZE = 6;
        private const int RESTORE = 9;


        static void Maximize()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                ShowWindow(ThisConsole, MAXIMIZE);
            }
        }
    }
}