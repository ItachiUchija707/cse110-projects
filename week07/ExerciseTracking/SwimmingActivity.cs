public  class SwimmingActivity : Activity
{
    private  int _laps = 0;

    public SwimmingActivity(string date, double minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }


    public override double GetSpeed()
    {
        return (this.GetDistance() / this.GetMinutes()) * 60;
    }
    public override double GetDistance()
    {
        return _laps * 50.0 / 1000 * 0.62;
    }

    public override double GetPace()
    {
        return this.GetMinutes() / this.GetDistance();
    }
}