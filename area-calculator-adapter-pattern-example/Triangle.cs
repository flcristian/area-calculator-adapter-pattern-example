using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_calculator_adapter_pattern_example
{
    public class Triangle : Shape
    {
        private double _side;
        private double _height;

        public Triangle(string type, double side, double height) : base(type)
        {
            _side = side;
            _height = height;
        }

        public double Side
        {
            get { return _side; }
            set { _height = value; }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }
    }
}
