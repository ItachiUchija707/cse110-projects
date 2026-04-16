public  class RunningActivity : Activity
{
    private  double _distance = 0;

    public RunningActivity(string date, double minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }


    public override double GetSpeed()
    {
        return (_distance / this.GetMinutes()) * 60;
    }
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        return this.GetMinutes() / _distance;
    }
}