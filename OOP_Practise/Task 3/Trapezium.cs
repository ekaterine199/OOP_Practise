using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practise.Task_3
{
    public class Trapezium : IShape
    {
        private readonly double _firstSide;
        private readonly double _secondSide;
        private readonly double _height;

        public double calculateArea()
        {
            return _height * (_firstSide+_secondSide)/2;
        }

        public double calculatePerimeter()
        {
            return _firstSide + _secondSide + 2 * Math.Sqrt(Math.Pow((_secondSide - _firstSide) / 2, 2) + Math.Pow(_height, 2));

        }
    }
}
