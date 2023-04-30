using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practise.Task_3
{
    public class idealPrism : IShape
    {
        private readonly double _length;
        private readonly double _width;
        private readonly double _height;

        public idealPrism(double length, double width, double height)
        {
            _length = length;
            _width = width;
            _height = height;
        }

        public double calculateArea()
        {
            double area = 2 * (_length * _width + _length * _height + _width * _height);
            return area;
        }

        public double calculatePerimeter()
        {
            double perimeter = 4 * (_length + _width)+4*(_length + _height)+4*(_width+_height);
            return perimeter;
        }
    }
}
