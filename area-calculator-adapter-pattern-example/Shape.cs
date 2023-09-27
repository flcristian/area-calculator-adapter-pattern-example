using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_calculator_adapter_pattern_example
{
    public class Shape
    {
        private String _type;

        public Shape(String type)
        {
            _type = type;
        }

        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }
    }
}
