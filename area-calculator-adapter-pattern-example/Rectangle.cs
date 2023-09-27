namespace area_calculator_adapter_pattern_example
{
    public class Rectangle : Shape
    {
        private double _length;
        private double _width;

        public Rectangle(string type, double length, double width) : base(type)
        {
            _length = length;
            _width = width;
        }

        public double Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }
    }
}
