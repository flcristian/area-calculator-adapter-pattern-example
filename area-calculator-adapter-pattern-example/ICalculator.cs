using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_calculator_adapter_pattern_example
{
    public interface ICalculator
    {
        double GetArea(Shape shape);
    }
}
