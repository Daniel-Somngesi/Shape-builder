using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shape_Builder.Classes
{
    public class Circle : Shape
    {
        private int mX;
        private int mY;
        private int mRadius;

        public Circle(string _desc, string _fill, string _strokeCol, double _strokeWidth, int _x, int _y, int _radius) : base(_desc, _fill, _strokeCol, _strokeWidth)
        {
            mX = _x;
            mY = _y;
            mRadius = _radius;
        }

        public int Radius
        {
            get { return mRadius; }
            set { mRadius = value; }
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

        public override double getArea()
        {
            double area = Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
            return area;
        }

        public override string getSVG()
        {
            return "<svg style='border: 1pt dashed #333' height='" + base.SvgHeight + "' width='" + base.SvgWidth +
                "'><circle cx='" + mX + "' cy='" + mY + "' r='" + mRadius + "' style='fill:" + base.Fill + ";stroke:" + base.StrokeColor + ";stroke-Width:" +
                base.StrokeWidth + "'/></svg>";
        }

    }
}