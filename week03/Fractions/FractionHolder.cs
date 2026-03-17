public class FractionHolder
{
    private int _top;
    private int _bottom;

    public FractionHolder()
    {
        _top = 1;
        _bottom = 1;
    }

    public FractionHolder(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public FractionHolder(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void SetTop(int numerator)
    {
        _top = numerator;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetBottom(int denominator)
    {
        _bottom = denominator;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public string GetFractionString()
    {
        string fractionString = _top + "/" + _bottom;
        return fractionString;
    }

    public double GetDecimalValue()
    {
        double decimalValue = _top / _bottom;
        return decimalValue;
    }
} 