using System;

namespace FigureSample
{
    public class LineDrawer
    {
        private readonly Canvas _canvas;
        public LineDrawer(Canvas c)
        {
            _canvas = c;
        }
        public void DrawLine(Line l)
        {
            if(l.Thickness<=1.0)
                DrawLine(l.X, l.Y, l.XEnd, l.YEnd, _canvas);
            else
                DrawLineT(l.X,l.Y,l.XEnd,l.YEnd, l.Thickness, _canvas);
        }
        private void DrawLineT(int x1, int y1, int x2, int y2, double t, Canvas c)
        {
            var dx = x2 - x1;
            var dy = y2 - y1;
            var nlen = Math.Sqrt(dx * dx + dy * dy);
            (int x, int y) tstart = ((int)(-dy / nlen*t), (int)(dx / nlen*t));
            (int x, int y) tend = ((int)(dy / nlen*t), (int)(-dx / nlen*t));
            
            double slope = (double)(y2 - y1) / (double)(x2 - x1);

            if (slope < 1 && slope > -1)
            {
                if (x1 > x2)
                    DrawLineT(x2, y2, x1, y1,t, c);
                int inc = y1 > y2 ? -1 : 1;
                int m_new = 2 * ((y2 * inc) - (y1 * inc));
                int slope_error_new = m_new - (x2 - x1);

                for (int x = x1, y = y1; x <= x2; x++)
                {
                    var c1 = (tstart.x + x, tstart.y + y);
                    var c2 = (tend.x + x, tend.y + y);
                    DrawLine(c1, c2, c);

                    slope_error_new += m_new;
                    if (slope_error_new >= 0)
                    {
                        y += inc;
                        slope_error_new -= 2 * (x2 - x1);
                    }
                }
            }
            else
            {
                if (y1 > y2)
                    DrawLineT(x2, y2, x1, y1, t,c);
                int inc = x1 > x2 ? -1 : 1;
                int m_new = 2 * ((x2 * inc) - (x1 * inc));
                int slope_error_new = m_new - (y2 - y1);
                for (int x = x1, y = y1; y <= y2; y++)
                {
                    var c1 = (tstart.x + x, tstart.y + y);
                    var c2 = (tend.x + x, tend.y + y);
                    DrawLine(c1, c2, c);
                    slope_error_new += m_new;
                    if (slope_error_new >= 0)
                    {
                        x += inc;
                        slope_error_new -= 2 * (y2 - y1);
                    }
                }
            }
        }

        private void DrawLine((int, int) s, (int, int) e, Canvas c) => DrawLine(s.Item1, s.Item2, e.Item1, e.Item2, c);

        // Fra kilden: https://www.geeksforgeeks.org/bresenhams-line-generation-algorithm/
        //  - modificeret for: slope-håndtering og tegneretning
        // function for line generation 
        private void DrawLine(int x1, int y1, int x2, int y2, Canvas c)
        {
            double slope = (double) (y2 - y1) / (double) (x2 - x1);
            if (slope < 1 && slope>-1)
            {
                if (x1 > x2)
                    DrawLine(x2, y2, x1, y1, c);
                int inc = y1 > y2 ?  -1 : 1;
                int m_new = 2 * ((y2*inc) - (y1*inc));
                int slope_error_new = m_new - (x2 - x1);

                for (int x = x1, y = y1; x <= x2; x++)
                {
                    c.PutPixel(x, y);
                    slope_error_new += m_new;
                    if (slope_error_new >= 0)
                    {
                        y+=inc;
                        slope_error_new -= 2 * (x2 - x1);
                    }
                }
            }
            else
            {
                if (y1 > y2)
                    DrawLine(x2, y2, x1, y1, c);
                int inc = x1 > x2 ? -1 : 1;
                int m_new = 2 * ((x2*inc) - (x1*inc));
                int slope_error_new = m_new - (y2 - y1);
                for (int x = x1, y = y1; y <= y2; y++)
                {
                    c.PutPixel(x, y);
                    slope_error_new += m_new;
                    if (slope_error_new >= 0)
                    {
                        x+=inc;
                        slope_error_new -= 2 * (y2 - y1);
                    }
                }
            }
        }
    }
}