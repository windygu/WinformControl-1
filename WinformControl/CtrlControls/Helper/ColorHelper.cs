using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CtrlControls.Helper
{
    public class ColorHelper
    {
        public static Color GetGray(Color color)
        {
            int a = color.A;
            int red = (((color.R * 0x84d) + (color.G * 0x1bf2)) + (color.B * 0x2d1)) / 0x2710;
            return Color.FromArgb(a, red, red, red);
        }

        public static Color GetColor(Color colorBase, int a, int r, int g, int b)
        {
            int a0 = colorBase.A;
            int r0 = colorBase.R;
            int g0 = colorBase.G;
            int b0 = colorBase.B;

            if (a + a0 > 255) { a = 255; } else { a = Math.Max(a + a0, 0); }
            if (r + r0 > 255) { r = 255; } else { r = Math.Max(r + r0, 0); }
            if (g + g0 > 255) { g = 255; } else { g = Math.Max(g + g0, 0); }
            if (b + b0 > 255) { b = 255; } else { b = Math.Max(b + b0, 0); }

            return Color.FromArgb(a, r, g, b);
        }
    }
}
