using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_calculator_adapter_pattern_example
{
    public class Calculator : ICalculator
    {
        public double GetArea(Shape shape)
        {
            switch (shape.Type.ToLower())
            {
                case "rectangle":
                    Rectangle rectangle = shape as Rectangle;
                    return rectangle.Length * rectangle.Width;
                case "triangle":
                    Triangle triangle = shape as Triangle;
                    return triangle.Side * triangle.Height / 2;
                default:
                    return 0;
            }
        }
    }
}
