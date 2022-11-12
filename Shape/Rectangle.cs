namespace nineteenthLesson.Shape;
using nineteenthLesson.Shape;
public class Rectangle : Shape
{
    protected double _width;
    protected double _length;
    public Rectangle()
    {

    }
    public Rectangle(double width, double length)
    {
        this._width=width;
        this._length=length;
    }
    public Rectangle(double width, double length, string color, Boolean filled) : base(color, filled)
    {
        this._width=width;
        this._length=length;
    }
    public double GetWidth()
    {
        return this._width;
    }
    public void SetWidth(double width)
    {
        this._width=width;
    }
    public double GetLength()
    {
        return _length;
    }
    public void SetLength(double length)
    {
        this._length=length;
    }
    public override double GetArea()
    {
        return _width*_length;
    }
    public override double GetPerimeter()
    {
        return 2*(_width+_length);
    }
    public override string ToString()
    {
        return $"Rectangle[Shape[color={_color}, filled={_filled}], width={_width}, length={_length}]";
    }
}
