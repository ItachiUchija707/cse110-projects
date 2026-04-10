public class Rectangle : Shapes
{
    private double _length = 0;
    private double _width = 0;

      public Rectangle(string color, double length, double width)
    {
        _color = color;
        _length = length;
        _width = width;
    }
    public override double GetArea()
    {
        return _length * _width;
    }
}