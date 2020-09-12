using System.Diagnostics;

namespace FigureSample
{
    public abstract class Canvas
    {
        public abstract void PutPixel(int x, int y);
        public virtual void Clear()
        {
        }
    }
}