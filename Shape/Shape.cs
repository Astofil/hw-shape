namespace nineteenthLesson.Shape;
abstract class Shape
{
    protected string _color;
    protected Boolean _filled = true;
    public Shape()
    {

    }
    public Shape(string color, bool filled)
    {
        this._color=color;
        this._filled=filled;
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        this._color=color;
    }
    public Boolean IsFilled()
    {
        return true;
    }
    public void SetFilled(Boolean filled)
    {
        if(_color != null)
        {
            this._filled=filled;
        }
    }
    abstract public double GetArea();
    public abstract double GetPerimeter();
    public override string ToString()
    {
        return $"Shape[color={_color}, filled={_filled}]";
    }
}

