using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practise.Task_3
{
    public class Triangle : IShape
    {
        private readonly double _firstSide;
        private readonly double _secondSide;
        private readonly double _thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        public double calculateArea()
        {
            double halfPerimeter = (_firstSide + _secondSide + _thirdSide)/ 2;
            double areaTriangle = Math.Sqrt(halfPerimeter * (halfPerimeter - _firstSide) * (halfPerimeter - _secondSide) * (halfPerimeter - _thirdSide));
            return areaTriangle;
        }

        public double calculatePerimeter()
        {
            return _firstSide + _secondSide + _thirdSide;
        }
    }
}
