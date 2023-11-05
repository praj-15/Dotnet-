partial class Interval
{
    //read-only property
    public int Minutes { get; }

    public int Seconds { get; }

    public Interval(int min, int sec)
    {
        Minutes = min + sec / 60; //read-only property can only be assigned in a constructor
        Seconds = sec % 60;
    }

    public int Time()
    {
        return 60 * Minutes + Seconds;
    }

    public override string ToString()
    {
        if(Seconds < 10)
            return Minutes + ":0" + Seconds;
        return Minutes + ":" + Seconds;
    }

}
