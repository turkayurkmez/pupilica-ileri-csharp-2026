using Display.SDK;
using System.Drawing;

namespace Display.Library
{
    public class Circle : IPlugin
    {
        public string Name => "Daire";

        public void Draw(Graphics graphics, SolidBrush solidBrush, int x, int t, int width, int height)
        {
           graphics.FillEllipse(solidBrush, x, t, width, height);
        }
    }

    public class Square : IPlugin
    {
        public string Name => "Kare";

        public void Draw(Graphics graphics, SolidBrush solidBrush, int x, int t, int width, int height)
        {
            graphics.FillRectangle(solidBrush, x, t, width, height);
        }
    }
}
