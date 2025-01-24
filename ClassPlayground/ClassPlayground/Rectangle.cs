using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class Rectangle : Shape2D
    {
        public float width, height;
        public override float CalculateArea()
        {
            return width * height;
        }
        public override float CalculateAspectRatio()
        {
            return width / height;
        }
        public override bool ContainsPoint(float x, float y)
        {
            return x >= 0 && y >= 0 && x <= width && y <= height;
        }

        public Rectangle(float width, float height)
        {
            if (width == 0) this.width = 1;
            else if (width < 0)
            {
                this.width = -width;
            }
            else
            {
                this.width = width;
            }

            this.height = height;
        }
    }
}
