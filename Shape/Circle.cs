// namespace nineteenthLesson.Shape;
using nineteenthLesson.Shape;
public class Circle : Shape
{
    protected double _radius;
    public Circle()
    {

    }
    public Circle(double radius)
    {

    }
   
    public Circle(double radius, string color, Boolean filled) : base(color,filled)
    {
        this._radius=radius;
    }
    public double GetRadius()
    {
        return _radius;
    }
    public void SetRadius(double radius)
    {
        this._radius=radius;
    }
    public override double GetArea()
    {
        return 3.14*_radius*_radius;
    }
    public override double GetPerimeter()
    {
        return 2*3.14*_radius;
    }
    public override string ToString()
    {
        return $"Circle[Shape[color={_color}, filled={_filled}], radius={_radius}]";
    }
}