public class Circle : Shapes
{
    private double _radius = 0;

    public Circle(string color, double radius)
    {
        _color = color;
        _radius = radius;
    }
    public override double GetArea()
    {
        return Math.PI * _radius*_radius;
    }
}