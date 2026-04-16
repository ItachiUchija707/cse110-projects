public  class CyclingActivity : Activity
{
    private  double _speed = 0;

    public CyclingActivity(string date, double minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }


    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetDistance()
    {
        return (_speed * this.GetMinutes()) / 60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}