//a type defined with partial modifier can include members
//through multiple source code files
partial class Interval
{
    public static Interval operator+(Interval lhs, Interval rhs)
    {
        return new Interval(lhs.Minutes + rhs.Minutes, lhs.Seconds + rhs.Seconds);
    }
}

class Program
{
    private static void Print(string label, object info)
    {
        Console.WriteLine("{0} = {1}", label, info);
    }

    public static void Main(string[] args)
    {
        Interval a = new Interval(6, 10);
        Interval b = new Interval(3, 5);
        Interval c = new Interval(5, 70);
        Interval d = b;
        Print("Interval a", a);
        Print("Interval b", b);
        Print("Interval c", c);
        Print("Interval d", d);
        Print("Total", a + b + c + d);
    }
}
