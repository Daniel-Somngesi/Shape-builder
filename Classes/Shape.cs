using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shape_Builder.Classes
{
    public abstract class Shape
    {
        private string mDescription;
        private string mFill;
        private string mStrokeColor;
        private double mStrokeWidth;

        public Shape(string _desc, string _fill, string _strokeCol, double _strokeWidth)
        {
            mDescription = _desc;
            mFill = _fill;
            mStrokeColor = _strokeCol;
            mStrokeWidth = _strokeWidth;
        }

        public int SvgHeight
        {
            get { return 450; }
        }


        public int SvgWidth
        {
            get { return 450; }
        }


        public double StrokeWidth
        {
            get { return mStrokeWidth; }
            set { mStrokeWidth = value; }
        }


        public string StrokeColor
        {
            get { return mStrokeColor; }
            set { mStrokeColor = value; }
        }


        public string Fill
        {
            get { return mFill; }
            set { mFill = value; }
        }


        public string Description
        {
            get { return mDescription; }
            set { mDescription = value; }
        }

        public abstract double getArea();

        public abstract string getSVG();
    }
}