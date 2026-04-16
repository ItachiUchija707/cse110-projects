public abstract class Activity
{
    private string _date = "";
    private  double _minutes = 0;

    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public double GetMinutes()
    {
        return _minutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public abstract double GetSpeed();
    public abstract double GetDistance();
    public abstract double GetPace();
    public virtual string DisplayActivityInfo()
    {
        string fName = this.GetType().Name.Replace("Activity", "");
        return $"{this.GetDate()} {fName} ({this.GetMinutes()} min) - Distance: {this.GetDistance():0.00} miles, {this.GetSpeed():0.00} mph, {this.GetPace():0.00} min per mile";
    }
}