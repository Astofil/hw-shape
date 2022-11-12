namespace nineteenthLesson.Shape;
using nineteenthLesson.Shape;
public class Square : Rectangle
{
    protected double _side;
    public Square()
    {

    }
    public Square(double side)
    {
        //this._side=side;
    }
    public Square(double side, string color, Boolean filled, double width, double length) : base(width, length)
    {
        this._side=side;
        this._color=color;
        this._filled=filled;
    }
    public double GetSide()
    {
        return _side;
    }
    public void SetSide(double side)
    {
        this._side=side;
    }
    public void SetWidth(double side)
    {
        this._width=side;
    }
    public void SetLength(double side)
    {
        this._length=side;
    }
    public override string ToString()
    {
        return $"Square[Rectangle[Shape[color={_color}, filled={_filled}], width={_width}, length={_length}]]";
    }
}