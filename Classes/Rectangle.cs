using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shape_Builder.Classes
{
    public class Rectangle : Shape
    {
        private int mX;
        private int mY;
        private int mHeight;
        private int mWidth;

        public Rectangle(string _desc, string _fill, string _strokeCol, double _strokeWidth, int _x, int _y, int _width, int _height) : base(_desc, _fill, _strokeCol, _strokeWidth)
        {
            mX = _x;
            mY = _y;
            mHeight = _height;
            mWidth = _width;
        }

        public int Width
        {
            get { return mWidth; }
            set { mWidth = value; }
        }

        public int Height
        {
            get { return mHeight; }
            set { mHeight = value; }
        }


        public int Y
        {
            get { return mY; }
            set { mY = value; }
        }


        public int X
        {
            get { return mX; }
            set { mX = value; }
        }

        public override string getSVG()
        {
            return "<svg style='border: 1pt dashed #333' height='" + base.SvgHeight + "' width='" + base.SvgWidth +
                "'><rect x='" + mX + "' y='" + mY + "' width='" + mWidth + "' height='" + mHeight + "' style='fill:" + base.Fill + ";stroke:" + base.StrokeColor + ";stroke-Width:" +
                base.StrokeWidth + "'/></svg>";
        }

        public override double getArea()
        {
            double area = (Width * Height);
            return area;
        }
    }
}