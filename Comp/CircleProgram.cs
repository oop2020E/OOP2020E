namespace Comp
{
    class CircleProgram
    {
        public static void Run()
        {
            //TODO 05 CircleProgram overview


            // Circle Code
            Canvas canvas = new Canvas("My circle program");
            canvas.Clear();

            Circle c1 = new Circle();
            c1.X = 70;
            c1.Y = 30;
            c1.Radius = 10;

            CircleDrawer cd = new CircleDrawer(canvas);

            cd.Draw(c1);

        }
    }
}