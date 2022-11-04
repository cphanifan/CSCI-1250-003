using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class Circle
    {
        private double _radius;

        //constuctor
        public Circle(double radius)
        {
            if (radius < 0)
            {
                radius = radius * -1;
            }
            SetRadius(radius);
        }
        public double GetRadius()
        {
            return _radius;
        }
        public void SetRadius(double radius)
        {
            _radius = radius;
        }
        public double GetDiameter()
        {
            double diameter;
            diameter = _radius * 2;
            return diameter;
        }
        public double GetCircumference()
        {
            double circumference;
            circumference = 2 * Math.PI * _radius;
            return circumference;
        }
        public double GetArea()
        {
            double area;
            area = Math.PI * Math.Pow(_radius, 2);
            return area;
        }

    }
}
