using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Display.SDK
{
    public interface IPlugin
    {
        string Name { get; }
        void Draw(Graphics graphics, SolidBrush solidBrush, int x, int t, int width, int height);
    }
}
